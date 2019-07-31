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
    public partial class ReturnForm : Form
    {
        public Member ActiveMember;
        private List<Rental> RentalList;
        private int ScrollPosition = 0;

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            try
            {
                RentalList = RentalDB.GetRentalsOf(ActiveMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }

            ScrollDisplay(ScrollPosition);
            lbl_TotalRentals.Text = RentalList.Count.ToString();
        }

        private void ScrollDisplay(int Pos)
        {
            int numToDisplay = 3;
            if (RentalList.Count - Pos < 3)
            {
                numToDisplay = RentalList.Count - Pos;
            }

            grp_Rental1.Enabled = false;
            grp_Rental2.Enabled = false;
            grp_Rental3.Enabled = false;

            if (numToDisplay >= 1)
            {
                grp_Rental1.Enabled = true;
                try
                {
                    lbl_Title1.Text = MovieDB.GetMovie(int.Parse(RentalList[Pos].movie_number)).movie_title.Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                }
                lbl_date1.Text = RentalList[Pos].media_return_date;

                if (numToDisplay >= 2)
                {
                    grp_Rental2.Enabled = true;
                    lbl_Title2.Text = MovieDB.GetMovie(int.Parse(RentalList[Pos + 1].movie_number)).movie_title;
                    lbl_date2.Text = RentalList[Pos + 1].media_return_date;

                    if (numToDisplay >= 3)
                    {
                        grp_Rental3.Enabled = true;
                        lbl_Title3.Text = MovieDB.GetMovie(int.Parse(RentalList[Pos + 2].movie_number)).movie_title;
                        lbl_date3.Text = RentalList[Pos + 2].media_return_date;
                    }
                }
            }

            //checks if the up scroll button should be enabled
            if (RentalList.Count - (ScrollPosition + 1) >= 3)
            {
                btn_ScrollDown.Enabled = true;
            }
            else
            {
                btn_ScrollDown.Enabled = false;
            }

            //checks if the down scroll button should be enabled
            if (RentalList.Count - (ScrollPosition - 1) >= 3 && ScrollPosition - 1 >= 0)
            {
                btn_ScrollUp.Enabled = true;
            }
            else
            {
                btn_ScrollUp.Enabled = false;
            }
        }

        private void btn_ScrollUp_Click(object sender, EventArgs e)
        {
            ScrollDisplay(--ScrollPosition);
        }

        private void btn_ScrollDown_Click(object sender, EventArgs e)
        {
            ScrollDisplay(++ScrollPosition);
        }

        private void btn_return1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalDB.DeleteRental(RentalList[ScrollPosition]))
                {
                    MessageBox.Show("You have returned " + lbl_Title1.Text + ". Thank you, please come again.");
                }
                else
                {
                    MessageBox.Show("There was an error in returning your rental. Please try again or contact support.");
                }
            }
            catch (Exception)
            {

                throw;
            }

            LoadRentals();
        }

        private void btn_return2_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalDB.DeleteRental(RentalList[ScrollPosition + 1]))
                {
                    MessageBox.Show("You have returned " + lbl_Title2.Text + ". Thank you, please come again.");
                }
                else
                {
                    MessageBox.Show("There was an error in returning your rental. Please try again or contact support.");
                }
            }
            catch (Exception)
            {

                throw;
            }

            LoadRentals();
        }

        private void btn_return3_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentalDB.DeleteRental(RentalList[ScrollPosition + 2]))
                {
                    MessageBox.Show("You have returned " + lbl_Title3.Text + ". Thank you, please come again.");
                }
                else
                {
                    MessageBox.Show("There was an error in returning your rental. Please try again or contact support.");
                }
            }
            catch (Exception)
            {

                throw;
            }

            LoadRentals();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
