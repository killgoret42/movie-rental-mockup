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
    public static class MovieDB
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
        /// Returns a list of all Movies in the database.
        /// </summary>
        /// <returns></returns>
        public static List<Movie> GetMovies()
        {
            List<Movie> GenreList = new List<Movie>();

            OleDbConnection connection = GetConnection();

            string sqlString = 
                "Select id, genre_id, movie_title, description, " +
                "movie_year_made, movie_rating " +
                "from MOVIE;";

            OleDbCommand movieCommand = null;
            OleDbDataReader movieReader = null;

            List<Movie> movieList = new List<Movie>();
                
            try
            {
                connection.Open();

                using (movieCommand = new OleDbCommand(sqlString, connection))
                {
                    //Execute the SQL and return a DataReader
                    using ((movieReader = movieCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        //read through every record returned
                        while (movieReader.Read())
                        {
                            //Build movie object with data from the database
                            Movie objMovie = new Movie();
                            objMovie.id = movieReader["id"].ToString();
                            objMovie.genre_id = movieReader["genre_id"].ToString();
                            objMovie.movie_title = movieReader["movie_title"].ToString();
                            objMovie.description = movieReader["description"].ToString();
                            objMovie.movie_year_made = movieReader["movie_year_made"].ToString();
                            objMovie.movie_rating = movieReader["movie_rating"].ToString();

                            //Add movie to collection
                            movieList.Add(objMovie);
                        }
                    }
                }
                return movieList;
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
        /// Returns a single movie, identified by 'movieId'
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public static Movie GetMovie(int movieId)
        {
            string sqlString = 
                "Select id, genre_id, movie_title, description, " +
                "movie_year_made, movie_rating " +
                "from MOVIE " +
                "where id = @id;";

            OleDbConnection connection = GetConnection();

            OleDbCommand movieCommand = null;
            OleDbDataReader movieReader = null;
            Movie objMovie = new Movie();

            try
            {
                connection.Open();

                using (movieCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    movieCommand.Parameters.AddWithValue("@id", movieId.ToString());
                    //Execute the SQL and return a DataReader
                    using ((movieReader = movieCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                    {
                        //Build movie object with data from the database
                        movieReader.Read();
                        objMovie.id = movieReader["id"].ToString();
                        objMovie.genre_id = movieReader["genre_id"].ToString();
                        objMovie.movie_title = movieReader["movie_title"].ToString();
                        objMovie.description = movieReader["description"].ToString();
                        objMovie.movie_year_made = movieReader["movie_year_made"].ToString();
                        objMovie.movie_rating = movieReader["movie_rating"].ToString();
                    }
                }

                return objMovie;
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
        /// <param name="newMovie"></param>
        /// <returns></returns>
        public static bool AddMovie(Movie newMovie)
        {
            string sqlString = 
                "Insert into MOVIE values(" +
                "@id, @genre_id, @movie_title, @description, " +
                "@movie_year_made, @movie_rating );";

            OleDbConnection connection = GetConnection();

            OleDbCommand movieCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (movieCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    movieCommand.Parameters.AddWithValue("@id", newMovie.id);
                    movieCommand.Parameters.AddWithValue("@genre_id", newMovie.genre_id);
                    movieCommand.Parameters.AddWithValue("@movie_title", newMovie.movie_title);
                    movieCommand.Parameters.AddWithValue("@description", newMovie.description);
                    movieCommand.Parameters.AddWithValue("@movie_year_made", newMovie.movie_year_made);
                    movieCommand.Parameters.AddWithValue("@movie_rating", newMovie.movie_rating);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = movieCommand.ExecuteNonQuery();      
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
        /// Changes the information of the Movie with id objMovie.id if it exists.
        /// </summary>
        /// <param name="objMovie"></param>
        /// <returns></returns>
        public static bool UpdateMovie(Movie objMovie)
        {
            string sqlString = 
                "UPDATE MOVIE " +
                "set genre_id = @genre_id, " +
                "movie_title = @movie_title, " +
                "description = @description, " +
                "movie_year_made = @movie_year_made, " +
                "movie_rating = @movie_rating " +
                "where ID = @id";

            OleDbConnection connection = GetConnection();

            OleDbCommand movieCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (movieCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    movieCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                    movieCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                    movieCommand.Parameters.AddWithValue("@description", objMovie.description);
                    movieCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                    movieCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                    movieCommand.Parameters.AddWithValue("@id", objMovie.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = movieCommand.ExecuteNonQuery();
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
        /// Deletes Movie with id objMovie.id from the database if it exists.
        /// </summary>
        /// <param name="objMovie"></param>
        /// <returns></returns>
        public static bool DeleteMovie(Movie objMovie)
        {
            string sqlString = "DELETE from MOVIE where id = @id";

            OleDbConnection connection = GetConnection();

            OleDbCommand movieCommand = null;
            int rowsAffected = 0;

            try
            {
                connection.Open();

                using (movieCommand = new OleDbCommand(sqlString, connection))
                {
                    //Set command parameter
                    movieCommand.Parameters.AddWithValue("@id", objMovie.id);

                    //Execute the SQL and return the number of rows affected
                    rowsAffected = movieCommand.ExecuteNonQuery();
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
