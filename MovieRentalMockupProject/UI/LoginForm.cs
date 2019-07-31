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
    public partial class LoginForm : Form
    {
        public Member Account;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool memberFound = false;
            foreach (Member m in MemberDB.GetMembers())
            {
                if (m.login_name.ToLower() == txt_LoginName.Text.Trim().ToLower() && m.password == txt_Password.Text.Trim())
                {
                    MessageBox.Show("You have been successfully logged in.\n\n" + "Welcome, " + m.firstname.Trim() + " " + m.lastname.Trim() + ". Have a nice day.");
                    Account = m;
                    memberFound = true;
                    Close();
                    break;
                }
            }

            if (!memberFound)
            {
                MessageBox.Show("This login name and password combo was not found.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NewMember_Click(object sender, EventArgs e)
        {
            CreateMemberForm Form = new CreateMemberForm();
            Form.ShowDialog();
        }
    }
}
