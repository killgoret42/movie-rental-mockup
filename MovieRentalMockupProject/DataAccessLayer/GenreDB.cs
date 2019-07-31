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
    public static class GenreDB
    {
        private const string connectionString = 
            "Provider = Microsoft.ACE.OLEDB.12.0;" +
            "Data Source =" + @"..\..\MovieDatabase.accdb";

        /// <summary>
        /// Initializes connection using the static variable connectionString
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
        
        /// <summary>
        /// Returns a list of all Genres in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Genre> GetGenres()
        {
            List<Genre> genreList = new List<Genre>();

            OleDbConnection connection = GetConnection();

            string sqlString = "Select id, title " +
                               "from GENRE;";

            OleDbCommand genreCommand = null;
            OleDbDataReader genreReader = null;
                
            try
            {
                connection.Open();
                using (genreCommand = new OleDbCommand(sqlString, connection))
                {
                    //Execute the SQL and return a DataReader
                    using ((genreReader = genreCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        //read through every record returned
                        while (genreReader.Read())
                        {
                            //create genre object, give it the information we got from the SQL command, and add the object to the list
                            Genre objGenre = new Genre();
                            objGenre.id = genreReader["id"].ToString();
                            objGenre.name = genreReader["title"].ToString();
                            genreList.Add(objGenre);
                        }
                    }
                }

                return genreList;
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
        /// Returns a single genre, identified by 'id'
        /// </summary>
        /// <param name="genreNumber"></param>
        /// <returns></returns>
        public static Genre GetGenre(int genreNumber)
        {
            string sqlString = 
                "Select id, title " +
                "from GENRE " +
                "where id = @id;";

            OleDbConnection connection = GetConnection();

            OleDbCommand genreCommand = null;
            OleDbDataReader genreReader = null;
            Genre objGenre = new Genre();

            try
            {
                connection.Open();

                using (genreCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    genreCommand.Parameters.AddWithValue("@id", genreNumber);
                    //Execute the SQL and return a DataReader
                    using ((genreReader = genreCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        genreReader.Read();
                        objGenre.id = genreReader["id"].ToString();
                        objGenre.name = genreReader["title"].ToString();
                    }
                }

                return objGenre;
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
        /// Adds newGenre to the database
        /// </summary>
        /// <param name="newGenre"></param>
        /// <returns></returns>
        public static bool AddGenre(Genre newGenre)
        {
            string sqlString = 
                "Insert into GENRE values(" +
                "@id, @name)";

            OleDbConnection connection = GetConnection();

            OleDbCommand genreCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (genreCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameters
                    genreCommand.Parameters.AddWithValue("@id", newGenre.id);
                    genreCommand.Parameters.AddWithValue("@name", newGenre.name);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = genreCommand.ExecuteNonQuery();      
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

        /// <summary>
        /// Changes the information of the Genre with id objGenre.id if it exists.
        /// </summary>
        /// <param name="objGenre"></param>
        /// <returns></returns>
        public static bool UpdateGenre(Genre objGenre)
        {
            string sqlString = 
                "UPDATE GENRE " +
                "set title = @title " +
                "where id = @id";
            OleDbConnection connection = GetConnection();

            OleDbCommand genreCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (genreCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    genreCommand.Parameters.AddWithValue("@title", objGenre.name);
                    genreCommand.Parameters.AddWithValue("@id", objGenre.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = genreCommand.ExecuteNonQuery();
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

        /// <summary>
        /// Deletes Genre with id objGenre.id from the database if it exists.
        /// </summary>
        /// <param name="objGenre"></param>
        /// <returns></returns>
        public static bool DeleteGenre(Genre objGenre)
        {
            string sqlString = 
                "DELETE from GENRE " +
                "where id = @id";

            OleDbConnection connection = GetConnection();

            OleDbCommand genreCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (genreCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    genreCommand.Parameters.AddWithValue("@id", objGenre.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = genreCommand.ExecuteNonQuery();
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
