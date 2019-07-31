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
    public partial class BrowseForm : Form
    {
        public Member ActiveMember;
        private List<Movie> MovieList;
        private List<Genre> genreList;
        private int ScrollPosition = 0; //when in position 0, it should try to show movies 0 - 2 from MovieList
        public BrowseForm()
        {
            InitializeComponent();
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            MovieList = MovieDB.GetMovies();
            genreList = GenreDB.GetGenres();

            ScrollDisplay(0);
        }

        private void ScrollDisplay(int Pos)
        {
            int numToDisplay = 3;
            if (MovieList.Count - Pos < 3)
            {
                numToDisplay = MovieList.Count - Pos;
            }

            grp_Movie1.Enabled = false;
            grp_Movie2.Enabled = false;
            grp_Movie3.Enabled = false;

            if (numToDisplay >= 1)
            {
                grp_Movie1.Enabled = true;
                lbl_Title1.Text = MovieList[Pos].movie_title;
                lbl_Genre1.Text = genreList.Find(x => x.id == MovieList[Pos].genre_id).name;
                lbl_Rating1.Text = "Rating: " + MovieList[Pos].movie_rating;
                txt_Desc1.Text = MovieList[Pos].description;

                if (numToDisplay >= 2)
                {
                    grp_Movie2.Enabled = true;
                    lbl_Title2.Text = MovieList[Pos + 1].movie_title;
                    lbl_Genre2.Text = genreList.Find(x => x.id == MovieList[Pos + 1].genre_id).name;
                    lbl_Rating2.Text = "Rating: " + MovieList[Pos + 1].movie_rating;
                    txt_Desc2.Text = MovieList[Pos + 1].description;

                    if (numToDisplay >= 3)
                    {
                        grp_Movie3.Enabled = true;
                        lbl_Title3.Text = MovieList[Pos + 2].movie_title;
                        lbl_Genre3.Text = genreList.Find(x => x.id == MovieList[Pos + 2].genre_id).name;
                        lbl_Rating3.Text = "Rating: " + MovieList[Pos + 2].movie_rating;
                        txt_Desc3.Text = MovieList[Pos + 2].description;
                    }
                }
            }

            //checks if the right scroll button should be enabled
            if (MovieList.Count - (ScrollPosition + 1) >= 3)
            {
                btn_ScrollRight.Enabled = true;
            }
            else
            {
                btn_ScrollRight.Enabled = false;
            }

            //checks if the left scroll button should be enabled
            if (MovieList.Count - (ScrollPosition - 1) >= 3 && ScrollPosition - 1 >= 0)
            {
                btn_ScrollLeft.Enabled = true;
            }
            else
            {
                btn_ScrollLeft.Enabled = false;
            }
        }

        private void btn_Rent1_Click(object sender, EventArgs e)
        {
            Rental newRental = new Rental();
            newRental.movie_number = MovieList[ScrollPosition].id;
            newRental.member_number = ActiveMember.id;
            Rental existingRental = RentalDB.GetRental(newRental.movie_number, newRental.member_number);
            if (existingRental is null)
            {
                //the member is NOT currently renting that movie
                newRental.media_checkout_date = DateTime.Now.ToString();
                newRental.media_return_date = DateTime.Now.AddDays(30).ToString();
                RentalDB.AddRental(newRental);
                MessageBox.Show("You have rented " + lbl_Title1.Text + ", and it is due back by " + newRental.media_return_date + ". Thank you, please come again.");
            }
            else
            {
                //the member IS currently renting that movie
                MessageBox.Show("You are already renting " + lbl_Title1.Text + ". It was checked out at "
                    + existingRental.media_checkout_date + "and it is due back by " + existingRental.media_return_date +
                    ". You may not rent multiple copies of the same movie.");
            }
        }

        private void btn_Rent2_Click(object sender, EventArgs e)
        {
            Rental newRental = new Rental();
            newRental.movie_number = MovieList[ScrollPosition + 1].id;
            newRental.member_number = ActiveMember.id;
            Rental existingRental = RentalDB.GetRental(newRental.movie_number, newRental.member_number);
            if (existingRental is null)
            {
                //the member is NOT currently renting that movie
                newRental.media_checkout_date = DateTime.Now.ToString();
                newRental.media_return_date = DateTime.Now.AddDays(30).ToString();
                RentalDB.AddRental(newRental);
                MessageBox.Show("You have rented " + lbl_Title2.Text + ", and it is due back by " + newRental.media_return_date + ". Thank you, please come again.");
            }
            else
            {
                //the member IS currently renting that movie
                MessageBox.Show("You are already renting " + lbl_Title2.Text + ". It was checked out at "
                    + existingRental.media_checkout_date + "and it is due back by " + existingRental.media_return_date +
                    ". You may not rent multiple copies of the same movie.");
            }
        }

        private void btn_Rent3_Click(object sender, EventArgs e)
        {
            Rental newRental = new Rental();
            newRental.movie_number = MovieList[ScrollPosition + 2].id;
            newRental.member_number = ActiveMember.id;
            Rental existingRental = RentalDB.GetRental(newRental.movie_number, newRental.member_number);
            if (existingRental is null)
            {
                //the member is NOT currently renting that movie
                newRental.media_checkout_date = DateTime.Now.ToString();
                newRental.media_return_date = DateTime.Now.AddDays(30).ToString();
                RentalDB.AddRental(newRental);
                MessageBox.Show("You have rented " + lbl_Title3.Text + ", and it is due back by " + newRental.media_return_date + ". Thank you, please come again.");
            }
            else
            {
                //the member IS currently renting that movie
                MessageBox.Show("You are already renting " + lbl_Title3.Text + ". It was checked out at "
                    + existingRental.media_checkout_date + "and it is due back by " + existingRental.media_return_date + 
                    ". You may not rent multiple copies of the same movie.");
            }
        }

        private void btn_ScrollLeft_Click(object sender, EventArgs e)
        {
            ScrollDisplay(--ScrollPosition);
        }

        private void btn_ScrollRight_Click(object sender, EventArgs e)
        {
            ScrollDisplay(++ScrollPosition);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ShowRentals_Click(object sender, EventArgs e)
        {
            ReturnForm Form = new ReturnForm();
            Form.ActiveMember = ActiveMember;
            Form.ShowDialog();
        }
    }
}
