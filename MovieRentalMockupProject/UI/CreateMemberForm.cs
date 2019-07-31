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
    public partial class CreateMemberForm : Form
    {
        /// <summary>
        /// returns a member object based off information input by the user. NOTE: if the information is incorrect, a null member object
        /// is returned
        /// </summary>
        /// <returns></returns>
        private Member GetMemberObjFromUI()
        {
            Member newMember = new Member();

            //code to find what the member number should be
            newMember.id = (MemberDB.GetHighestMemberID() + 1).ToString();

            newMember.joindate = DateTime.Now.ToString();
            newMember.firstname = txt_FirstName.Text.Trim();
            newMember.lastname = txt_LastName.Text.Trim();
            newMember.address = txt_Address.Text.Trim();
            newMember.city = txt_City.Text.Trim();
            newMember.state = msk_State.Text.Trim();
            newMember.zipcode = msk_ZipCode.Text.Trim();
            newMember.phone = msk_Phone.Text.Trim();
            newMember.member_status = "A";
            newMember.login_name = txt_Login.Text.Trim();
            newMember.password = txt_Password.Text.Trim();
            newMember.email = txt_Email.Text.Trim();

            if (rad_Regular.Checked)
            {
                newMember.subscription_id = "0";
            }
            else if (rad_Premium.Checked)
            {
                newMember.subscription_id = "1";
            }
            else if (rad_Deluxe.Checked)
            {
                newMember.subscription_id = "2";
            }
            else
            {
                MessageBox.Show("No Subscription Type was checked. Make sure all information has been entered before performing an operation.");
                return null;
            }

            newMember.admin = "false";

            return newMember;
        }

        public CreateMemberForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMem = GetMemberObjFromUI();

                if (newMem != null)
                {

                    //check if the username is taken
                    bool memberExists = false;
                    foreach (Member m in MemberDB.GetMembers())
                    {
                        if (m.login_name.ToLower() == newMem.login_name.ToLower()) //if that login name is in use
                        {
                            memberExists = true;
                            MessageBox.Show("Sorry, but that login name is already in use. Please choose a different one.");
                            break; //break out of the for loop, so we don't spend time looking at each account
                        }
                    }

                    //if the username is not taken, attempt to add the new member to the database
                    if (!memberExists)
                    {
                        if (MemberDB.AddMember(GetMemberObjFromUI()))
                        {
                            MessageBox.Show("Your account has been successfully created. You may now login to your new account");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Account creation failed. Make sure all information has been entered, and try again. If you continue " +
                                "receiving this error message, please contact technical support.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a technical error during the operation.\n\nMessage:\n" + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
