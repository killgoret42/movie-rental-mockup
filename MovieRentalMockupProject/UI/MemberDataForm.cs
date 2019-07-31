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
    public partial class MemberDataForm : Form
    {
        private Member GetMemberObjFromUI()
        {
            Member newMember = new Member();

            newMember.id = txt_MemberNumber.Text.Trim();

            int x;
            if (!Int32.TryParse(newMember.id, out x))
            { //true: the member number text box does not hold an integer
                MessageBox.Show("The member number text box must hold a number with no extra text");
                return null;
            }
            newMember.joindate = msk_JoinDate.Text.Trim();
            newMember.firstname = txt_FirstName.Text.Trim();
            newMember.lastname = txt_LastName.Text.Trim();
            newMember.address = txt_Address.Text.Trim();
            newMember.city = txt_City.Text.Trim();
            newMember.state = msk_State.Text.Trim();
            newMember.zipcode = msk_ZipCode.Text.Trim();
            newMember.phone = msk_Phone.Text.Trim();

            if (rad_Active.Checked)
            {
                newMember.member_status = "A";
            }
            else if (rad_Inactive.Checked)
            {
                newMember.member_status = "I";
            }
            else
            {
                MessageBox.Show("No Member status was checked. Make sure all information has been entered before performing an operation.");
                return null;
            }

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

            if (chk_Admin.Checked)
            {
                newMember.admin = "true";
            }
            else
            {
                newMember.admin = "false";
            }

            return newMember;
        }

        public MemberDataForm()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Member m in MemberDB.GetMembers())
            {
                //put each genre object into a datagridview row object
                DataGridViewRow newRow = new DataGridViewRow();

                //creates cells using dataGridView1 as a template
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = m.id;
                newRow.Cells[1].Value = m.joindate;
                newRow.Cells[2].Value = m.firstname;
                newRow.Cells[3].Value = m.lastname;
                newRow.Cells[4].Value = m.address;
                newRow.Cells[5].Value = m.city;
                newRow.Cells[6].Value = m.state;
                newRow.Cells[7].Value = m.zipcode;
                newRow.Cells[8].Value = m.phone;
                newRow.Cells[9].Value = m.member_status;
                newRow.Cells[10].Value = m.login_name;
                newRow.Cells[11].Value = m.password;
                newRow.Cells[12].Value = m.email;
                newRow.Cells[13].Value = m.subscription_id;
                newRow.Cells[14].Value = m.admin;

                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Member m = GetMemberObjFromUI();
                if (m != null)
                {
                    if (MemberDB.AddMember(GetMemberObjFromUI()))
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Member m = GetMemberObjFromUI();

                if (m != null)
                {
                    if (MemberDB.UpdateMember(GetMemberObjFromUI()))
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
                Member m = GetMemberObjFromUI();

                if (m != null)
                {
                    if (MemberDB.DeleteMember(GetMemberObjFromUI()))
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
            txt_Address.Clear();
            txt_City.Clear();
            txt_Email.Clear();
            txt_FirstName.Clear();
            msk_JoinDate.Clear();
            txt_LastName.Clear();
            txt_Login.Clear();
            txt_MemberNumber.Clear();
            txt_Password.Clear();
            msk_Phone.Clear();
            msk_State.Clear();
            msk_ZipCode.Clear();

            rad_Active.Checked = false;
            rad_Inactive.Checked = false;
            rad_Regular.Checked = false;
            rad_Premium.Checked = false;
            rad_Deluxe.Checked = false;

            txt_MemberNumber.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
