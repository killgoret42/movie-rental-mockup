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
    public partial class GenreDataForm : Form
    {
        private Genre GetGenreObjFromUI()
        {
            Genre newGenre = new Genre();
            newGenre.id = txt_ID.Text.Trim();
            newGenre.name = txt_Name.Text.Trim();

            return newGenre;
        }

        public GenreDataForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (GenreDB.AddGenre(GetGenreObjFromUI()))
            {
                MessageBox.Show("Add Successful.");
            }
            else
            {
                MessageBox.Show("Add Failed.");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (GenreDB.DeleteGenre(GetGenreObjFromUI()))
            {
                MessageBox.Show("Delete Successful.");
            }
            else
            {
                MessageBox.Show("Delete Failed.");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_Name.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (GenreDB.UpdateGenre(GetGenreObjFromUI()))
            {
                MessageBox.Show("Update Successful.");
            }
            else
            {
                MessageBox.Show("Update Failed.");
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Genre g in GenreDB.GetGenres())
            {
                //put each genre object into a datagridview row object
                DataGridViewRow newRow = new DataGridViewRow();

                //creates cells using dataGridView1 as a template
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = g.id;
                newRow.Cells[1].Value = g.name;

                dataGridView1.Rows.Add(newRow);
            }
        }
    }
}
