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
    public partial class MainMenuForm : Form
    {
        private Member ActiveMember = null;
        
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_GenreUI_Click(object sender, EventArgs e)
        {
            GenreDataForm Form = new GenreDataForm();
            Form.ShowDialog();
        }

        private void btn_MemberUI_Click(object sender, EventArgs e)
        {
            MemberDataForm Form = new MemberDataForm();
            Form.ShowDialog();
        }

        private void btn_MovieUI_Click(object sender, EventArgs e)
        {
            MovieDataForm Form = new MovieDataForm();
            Form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btn_Movies_Click(object sender, EventArgs e)
        {
            BrowseForm Form = new BrowseForm();
            Form.ActiveMember = ActiveMember;
            Form.ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            Login();
            if (ActiveMember == null)
            {
                Close();
            }
        }

        private void Login()
        {
            LoginForm Form = new LoginForm();

            Form.Account = ActiveMember;
            Form.ShowDialog();

            ActiveMember = Form.Account;

            if (ActiveMember != null)
            {
                ActiveMemberLabel.Text = ActiveMember.firstname.Trim() + " " + ActiveMember.lastname.Trim();

                if (ActiveMember.admin == "true")
                {
                    grp_editData.Visible = true;
                }
                else
                {
                    grp_editData.Visible = false;
                }
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
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
