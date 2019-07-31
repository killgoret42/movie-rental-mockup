using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieDataForm : Form
    {
        private List<Genre> genreList;

        private Movie GetMovieObjFromUI()
        {
            Movie newMovie = new Movie();
            
            newMovie.id = txt_Movienum.Text.Trim();
            int x;
            if (!int.TryParse(newMovie.id, out x))
            {
                MessageBox.Show("The movie number textbox must hold a number, and must not have any other characters");
                return null;
            }

            newMovie.movie_title = txt_Title.Text.Trim();
            newMovie.description = txt_Desc.Text.Trim();

            newMovie.movie_year_made = txt_YearMade.Text.Trim();
            if (!int.TryParse(newMovie.movie_year_made, out x))
            {
                MessageBox.Show("The year made textbox must hold a number, and must not have any other characters");
                return null;
            }

            if (cmb_Genre.SelectedIndex == 0)
            {
                MessageBox.Show("You must choose a genre to complete the operation");
                return null;
            }
            newMovie.genre_id = genreList[cmb_Genre.SelectedIndex - 1].id;

            if (cmb_Rating.SelectedIndex == 0)
            {
                MessageBox.Show("You must choose a rating to complete the operation");
                return null;
            }
            newMovie.movie_rating = cmb_Rating.Text;

            return newMovie;
        }

        public MovieDataForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = GetMovieObjFromUI();
                if (m != null)
                {
                    if (MovieDB.AddMovie(m))
                    {
                        MessageBox.Show("Add Successful.");
                    }
                    else
                    {
                        MessageBox.Show("Add Failed. Make sure all information has been entered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a technical error during the operation.\n\nMessage:\n" + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Movie m in MovieDB.GetMovies())
            {
                //put each genre object into a datagridview row object
                DataGridViewRow newRow = new DataGridViewRow();

                //creates cells using dataGridView1 as a template
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = int.Parse(m.id);
                newRow.Cells[1].Value = m.movie_title;
                newRow.Cells[2].Value = m.description;
                newRow.Cells[3].Value = int.Parse(m.movie_year_made);
                newRow.Cells[4].Value = genreList.Find(x => x.id == m.genre_id).name;
                newRow.Cells[5].Value = m.movie_rating;

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = GetMovieObjFromUI();
                if (m != null)
                {
                    if (MovieDB.UpdateMovie(m))
                    {
                        MessageBox.Show("Update Successful.");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed. Make sure all information has been entered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a technical error during the operation.\n\nMessage:\n" + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = new Movie();
                m.id = txt_Movienum.Text.Trim();
                if (m != null)
                {
                    if (MovieDB.DeleteMovie(m))
                    {
                        MessageBox.Show("Delete Successful.");
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed. Make sure all information has been entered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a technical error during the operation.\n\nMessage:\n" + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Movienum.Clear();
            txt_Title.Clear();
            txt_Desc.Clear();
            txt_YearMade.Clear();

            cmb_Genre.SelectedIndex = 0;
            cmb_Rating.SelectedIndex = 0;

            txt_Movienum.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MovieDataForm_Load(object sender, EventArgs e)
        {
            cmb_Rating.Items.Add("Select a rating");
            cmb_Rating.Items.Add("★☆☆☆☆");
            cmb_Rating.Items.Add("★★☆☆☆");
            cmb_Rating.Items.Add("★★★☆☆");
            cmb_Rating.Items.Add("★★★★☆");
            cmb_Rating.Items.Add("★★★★★");
            cmb_Rating.SelectedIndex = 0;

            genreList = GenreDB.GetGenres();
            cmb_Genre.Items.Add("Select a Genre");
            foreach (Genre g in genreList)
            {
                cmb_Genre.Items.Add(g.name);
            }
            cmb_Genre.SelectedIndex = 0;
        }
    }
}
