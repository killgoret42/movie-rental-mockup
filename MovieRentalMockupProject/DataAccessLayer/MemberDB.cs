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
    public static class MemberDB
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
        /// Returns a list of all Members in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Member> GetMembers()
        {
            List<Member> MemberList = new List<Member>();
            string SQLStatement = String.Empty;

            OleDbConnection connection = GetConnection();

            string sqlString = 
                "Select id, joindate, firstname, lastname, address, city, state, zipcode, " +
                "phone, member_status, login_name, password, email, " +
                "subscription_id, admin from MEMBER;";

            OleDbCommand memberCommand = null;
            OleDbDataReader memberReader = null;

            List<Member> memberList = new List<Member>();
                
            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Execute the SQL and return a DataReader
                    using ((memberReader = memberCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        //read through every record returned
                        while (memberReader.Read())
                        {
                            //Build member object with data from the database
                            Member objMember = new Member();
                            objMember.id =              memberReader["id"].ToString();
                            objMember.joindate =            memberReader["joindate"].ToString();
                            objMember.firstname =           memberReader["firstname"].ToString();
                            objMember.lastname =            memberReader["lastname"].ToString();
                            objMember.address =             memberReader["address"].ToString();
                            objMember.city =                memberReader["city"].ToString();
                            objMember.state =               memberReader["state"].ToString();
                            objMember.zipcode =             memberReader["zipcode"].ToString();
                            objMember.phone =               memberReader["phone"].ToString();
                            objMember.member_status =       memberReader["member_status"].ToString();
                            objMember.login_name =          memberReader["login_name"].ToString();
                            objMember.password =            memberReader["password"].ToString();
                            objMember.email =               memberReader["email"].ToString();
                            objMember.subscription_id =     memberReader["subscription_id"].ToString();
                            objMember.admin =               memberReader["admin"].ToString();

                            //Add member to collection
                            memberList.Add(objMember);
                        }
                    }
                }
                return memberList;
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
        /// Returns a single member, identified by 'number' (NOTE: currently unusable, because 'number' was removed from the database and replaced with 'id')
        /// </summary>
        /// <param name="memberNumber"></param>
        /// <returns></returns>
        public static Member GetMember(int memberNumber)
        {
            string sqlString = 
                "Select number, joindate, firstname, lastname, address, city, state, zipcode, " +
                "phone, member_status, login_name, password, email, " +
                "subscription_id, admin " +
                "from MEMBER " +
                "where number = @number;";

            OleDbConnection connection = GetConnection();

            OleDbCommand memberCommand = null;
            OleDbDataReader memberReader = null;
            Member objMember = new Member();

            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    memberCommand.Parameters.AddWithValue("@customer_id", memberNumber);
                    //Execute the SQL and return a DataReader
                    using ((memberReader = memberCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        objMember.id = memberReader["number"].ToString();
                        objMember.joindate = memberReader["joindate"].ToString();
                        objMember.firstname = memberReader["firstname"].ToString();
                        objMember.lastname = memberReader["lastname"].ToString();
                        objMember.address = memberReader["address"].ToString();
                        objMember.city = memberReader["city"].ToString();
                        objMember.state = memberReader["state"].ToString();
                        objMember.zipcode = memberReader["zipcode"].ToString();
                        objMember.phone = memberReader["phone"].ToString();
                        objMember.member_status = memberReader["member_status"].ToString();
                        objMember.login_name = memberReader["login_name"].ToString();
                        objMember.password = memberReader["password"].ToString();
                        objMember.email = memberReader["email"].ToString();
                        objMember.subscription_id = memberReader["subscription_id"].ToString();
                        objMember.admin = memberReader["admin"].ToString();

                    }
                }

                return objMember;
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
        /// Returns the id of the highest member
        /// </summary>
        /// <returns></returns>
        public static int GetHighestMemberID()
        {
            string sqlString = 
                "Select MAX(id) AS id " +
                "from Member;";

            OleDbConnection connection = GetConnection();

            OleDbCommand memberCommand = null;
            OleDbDataReader memberReader = null;
            Member objMember = new Member();

            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Execute the SQL and return a DataReader
                    using ((memberReader = memberCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        memberReader.Read();
                        return int.Parse(memberReader["id"].ToString());
                    }
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
        /// Adds newMember to the database
        /// </summary>
        /// <param name="newMember"></param>
        /// <returns></returns>
        public static bool AddMember(Member newMember)
        {
            string sqlString = 
                "Insert into MEMBER values(" +
                "@id, @joindate, @firstname, @lastname, @address, @city, @state, @zipcode, " +
                "@phone, @member_status, @login_name, @password, @email, " +
                "@subscription_id, @admin);";


            OleDbConnection connection = GetConnection();

            OleDbCommand memberCommand = null;
            Member objMember = new Member();
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameters
                    memberCommand.Parameters.AddWithValue("@id", newMember.id);
                    memberCommand.Parameters.AddWithValue("@joindate", newMember.joindate);
                    memberCommand.Parameters.AddWithValue("@firstname", newMember.firstname);
                    memberCommand.Parameters.AddWithValue("@lastname", newMember.lastname);
                    memberCommand.Parameters.AddWithValue("@address", newMember.address);
                    memberCommand.Parameters.AddWithValue("@city", newMember.city);
                    memberCommand.Parameters.AddWithValue("@state", newMember.state);
                    memberCommand.Parameters.AddWithValue("@zipcode", newMember.zipcode);
                    memberCommand.Parameters.AddWithValue("@phone", newMember.phone);
                    memberCommand.Parameters.AddWithValue("@member_status", newMember.member_status);
                    memberCommand.Parameters.AddWithValue("@login_name", newMember.login_name);
                    memberCommand.Parameters.AddWithValue("@password", newMember.password);
                    memberCommand.Parameters.AddWithValue("@email", newMember.email);
                    memberCommand.Parameters.AddWithValue("@subscription_id", newMember.subscription_id);
                    memberCommand.Parameters.AddWithValue("@admin", newMember.admin);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = memberCommand.ExecuteNonQuery();      
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
        /// Changes the information of the Member with id objMember.id if it exists.
        /// </summary>
        /// <param name="objMember"></param>
        /// <returns></returns>
        public static bool UpdateMember(Member objMember)
        {
            string sqlString = 
                "UPDATE MEMBER " +
                "SET joindate = @joindate, " +
                "firstname = @firstname, " +
                "lastname = @lastname, " +
                "address = @address, " +
                "city = @city, " +
                "state = @state, " +
                "zipcode = @zipcode, " +
                "phone = @phone, " +
                "member_status = @member_status, " +
                "login_name = @login_name, " +
                "[password] = @password, " +
                "email = @email, " +
                "subscription_id = @subscription_id, " +
                "admin = @admin " +
                "where id = @id;";
            OleDbConnection connection = GetConnection();

            OleDbCommand memberCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameters
                    memberCommand.Parameters.AddWithValue("@joindate", objMember.joindate);
                    memberCommand.Parameters.AddWithValue("@firstname", objMember.firstname);
                    memberCommand.Parameters.AddWithValue("@lastname", objMember.lastname);
                    memberCommand.Parameters.AddWithValue("@address", objMember.address);
                    memberCommand.Parameters.AddWithValue("@city", objMember.city);
                    memberCommand.Parameters.AddWithValue("@state", objMember.state);
                    memberCommand.Parameters.AddWithValue("@zipcode", objMember.zipcode);
                    memberCommand.Parameters.AddWithValue("@phone", objMember.phone);
                    memberCommand.Parameters.AddWithValue("@member_status", objMember.member_status);
                    memberCommand.Parameters.AddWithValue("@login_name", objMember.login_name);
                    memberCommand.Parameters.AddWithValue("@password", objMember.password);
                    memberCommand.Parameters.AddWithValue("@email", objMember.email);
                    memberCommand.Parameters.AddWithValue("@subscription_id", objMember.subscription_id);
                    memberCommand.Parameters.AddWithValue("@admin", objMember.admin);
                    memberCommand.Parameters.AddWithValue("@id", objMember.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = memberCommand.ExecuteNonQuery();
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
        /// Deletes Member with id objMember.id from the database if it exists.
        /// </summary>
        /// <param name="objMember"></param>
        /// <returns></returns>
        public static bool DeleteMember(Member objMember)
        {
            string sqlString = "DELETE * from MEMBER where id = @id";

            OleDbConnection connection = GetConnection();

            OleDbCommand memberCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (memberCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    memberCommand.Parameters.AddWithValue("@id", objMember.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = memberCommand.ExecuteNonQuery();
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
