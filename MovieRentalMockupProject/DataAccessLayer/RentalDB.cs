using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MeramecNetFlixProject.BusinessObjects;

namespace MeramecNetFlixProject.DataAccessLayer
{
    public static class RentalDB
    {
/*
if the program is compiled as debug, it will get put under /bin/debug , and the database file that gets put next to it is overridden on every compile, so any changes made won't be permanent.
this could be useful for testing purposes, but it might not. Right now I want to test permanent changes, so I'm using this connection string here for debug. The release version will need to
use a different connection string, since the database file will be in a different location. If i want to switch between permanent and non permanent changes, I can test with release instead of
debug.
*/
#if DEBUG
        private const string connectionString =
            "Provider = Microsoft.ACE.OLEDB.12.0;" +
            "Data Source =" + @"..\..\MovieDatabase.accdb";
#else
        private const string connectionString = 
            "Provider = Microsoft.ACE.OLEDB.12.0;" +
            "Data Source =" + @"MovieDatabase.accdb";
#endif

        /// <summary>
        /// Initializes connection using the static variable connectionString
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        /// <summary>
        /// Returns a list of all Rentals in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Rental> GetRentals()
        {
            List<Rental> RentalList = new List<Rental>();

            OleDbConnection connection = GetConnection();

            string sqlString = 
                "Select movie_number, member_number, media_checkout_date, media_return_date" +
                "from Rental;";

            OleDbCommand rentalCommand = null;
            OleDbDataReader rentalReader = null;

            List<Rental> rentalList = new List<Rental>();
                
            try
            {
                connection.Open();

                using (rentalCommand = new OleDbCommand(sqlString, connection))
                {
                    //Execute the SQL and return a DataReader
                    using ((rentalReader = rentalCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        //read through every record returned
                        while (rentalReader.Read())
                        {
                            //Build Rental object with data from the database
                            Rental objRental = new Rental();
                            objRental.movie_number = rentalReader["movie_number"].ToString();
                            objRental.member_number = rentalReader["member_number"].ToString();
                            objRental.media_checkout_date = rentalReader["media_checkout_date"].ToString();
                            objRental.media_return_date = rentalReader["media_return_date"].ToString();

                            //Add Rental to collection
                            rentalList.Add(objRental);
                        }
                    }
                }

                return rentalList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure to close the connection, even if there is an exception
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Returns a list of all rentals that belong to a specified member
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static List<Rental> GetRentalsOf(Member member)
        {
            OleDbConnection connection = GetConnection();

            string sqlString = 
                "Select movie_number, member_number, media_checkout_date, media_return_date " +
                "from RENTAL " +
                "where member_number = @member_number;";

            OleDbCommand rentalCommand = null;
            OleDbDataReader rentalReader = null;

            List<Rental> rentalList = new List<Rental>();

            try
            {
                connection.Open();

                using (rentalCommand = new OleDbCommand(sqlString, connection))
                {
                    rentalCommand.Parameters.AddWithValue("@member_number", member.id);

                    //Execute the SQL and return a DataReader
                    using ((rentalReader = rentalCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {

                        while (rentalReader.Read())
                        {
                            Rental objRental = new Rental();
                            objRental.movie_number = rentalReader["movie_number"].ToString();
                            objRental.member_number = rentalReader["member_number"].ToString();
                            objRental.media_checkout_date = rentalReader["media_checkout_date"].ToString();
                            objRental.media_return_date = rentalReader["media_return_date"].ToString();

                            //Add rental to collection
                            rentalList.Add(objRental);
                        }
                    }
                }

                return rentalList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure to close the connection, even if there is an exception
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        ///Returns the Rental of a specified movie that belongs to a specified member, if it exists. if there is no match, it returns a null Rental
        /// </summary>
        /// <param name="rentalNumber"></param>
        /// <returns></returns>
        public static Rental GetRental(string movie_number, string member_number)
        {
            string sqlString = 
                "Select movie_number, member_number, media_checkout_date, media_return_date " +
                "from RENTAL " +
                "where movie_number = @movie_number AND member_number = @member_number";

            OleDbConnection connection = GetConnection();

            OleDbCommand rentalCommand = null;
            OleDbDataReader rentalReader = null;
            Rental objRental = new Rental();

            try
            {
                connection.Open();

                using (rentalCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    rentalCommand.Parameters.AddWithValue("@movie_number", movie_number);
                    rentalCommand.Parameters.AddWithValue("@member_number", member_number);
                    //Execute the SQL and return a DataReader
                    using ((rentalReader = rentalCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        if (rentalReader.HasRows)
                        {
                            rentalReader.Read();
                            objRental.movie_number = rentalReader["movie_number"].ToString();
                            objRental.member_number = rentalReader["member_number"].ToString();
                            objRental.media_checkout_date = rentalReader["media_checkout_date"].ToString();
                            objRental.media_return_date = rentalReader["media_return_date"].ToString();
                        }
                        else
                        {
                            objRental = null;
                        }

                    }
                }

                return objRental;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure to close the connection, even if there is an exception
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Adds newMovie to the database
        /// </summary>
        /// <param name="newRental"></param>
        /// <returns></returns>
        public static bool AddRental(Rental newRental)
        {
            string sqlString = 
                "Insert into RENTAL values(" +
                "@movie_number, @member_number, @media_checkout_date, @media_return_date);";

            OleDbConnection connection = GetConnection();

            OleDbCommand rentalCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (rentalCommand = new OleDbCommand(sqlString, connection))
                {
                    rentalCommand.Parameters.AddWithValue("@movie_number", newRental.movie_number);
                    rentalCommand.Parameters.AddWithValue("@member_number", newRental.member_number);
                    rentalCommand.Parameters.AddWithValue("@media_checkout_date", newRental.media_checkout_date);
                    rentalCommand.Parameters.AddWithValue("@media_return_date", newRental.media_return_date);
                    //rentalCommand.Parameters.AddWithValue("@trailer", newRental.trailer ?? (object)DBNull.Value);

                    rowsAffected = rentalCommand.ExecuteNonQuery();      
                }

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure to close the connection, even if there is an exception
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        ///// <summary>
        ///// unused. the code here won't work anyway: this is just a placeholder incase i want to fix this up and use it later
        ///// </summary>
        ///// <param name="rentalNumber"></param>
        ///// <returns></returns>
        //public static bool UpdateRental(Rental newRental)
        //{
        //    string sqlString = "UPDATE MOVIE " + Environment.NewLine +
        //                        "set rental_id = @rental_id, " + Environment.NewLine +
        //                        "    description = @description, " + Environment.NewLine +
        //                        "    rental_year_made = @rental_year_made, " + Environment.NewLine +
        //                        "    rental_rating = @rental_rating, " + Environment.NewLine +
        //                        "    media_type = @media_type," + Environment.NewLine +
        //                        "    rental_retail_cost = @rental_retail_cost, " + Environment.NewLine +
        //                        "    copies_on_hand = @copies_on_hand, " + Environment.NewLine +
        //                        "    image = @image, " + Environment.NewLine +
        //                        "    trailer = @trailer " + Environment.NewLine +
        //                        "where rental_number = @rental_number";
        //    OleDbConnection connection = GetConnection();

        //    OleDbCommand rentalCommand = null;
        //    int rowsAffected = 0;

        //    try
        //    {
        //        connection.Open();

        //        using (rentalCommand = new OleDbCommand(sqlString, connection))
        //        {
        //            //Set command parameter

        //            //Execute the SQL and return the number of rows affected
        //            rowsAffected = rentalCommand.ExecuteNonQuery();
        //        }

        //        if (rowsAffected > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection.State != System.Data.ConnectionState.Closed)
        //        {
        //            connection.Close();
        //        }
        //    }
        //} 

        /// <summary>
        /// Deletes Rental with movie number objRental.movie_number, and member number objRental.member_number from the database if it exists.
        /// </summary>
        /// <param name="objRental"></param>
        /// <returns></returns>
        public static bool DeleteRental(Rental objRental)
        {
            string sqlString = "DELETE from RENTAL " +
                "where movie_number = @movie_number AND member_number = @member_number";

            OleDbConnection connection = GetConnection();

            OleDbCommand rentalCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (rentalCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    rentalCommand.Parameters.AddWithValue("@movie_number", objRental.movie_number);
                    rentalCommand.Parameters.AddWithValue("@member_number", objRental.member_number);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = rentalCommand.ExecuteNonQuery();
                }

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //make sure to close the connection, even if there is an exception
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}
