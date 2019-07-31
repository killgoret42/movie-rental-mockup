namespace MeramecNetFlixProject.UI
{
    partial class BrowseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.btn_ScrollLeft = new System.Windows.Forms.Button();
            this.btn_ScrollRight = new System.Windows.Forms.Button();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.lbl_Rating1 = new System.Windows.Forms.Label();
            this.grp_Movie1 = new System.Windows.Forms.GroupBox();
            this.lbl_Genre1 = new System.Windows.Forms.Label();
            this.txt_Desc1 = new System.Windows.Forms.TextBox();
            this.btn_Rent1 = new System.Windows.Forms.Button();
            this.grp_Movie2 = new System.Windows.Forms.GroupBox();
            this.lbl_Genre2 = new System.Windows.Forms.Label();
            this.txt_Desc2 = new System.Windows.Forms.TextBox();
            this.btn_Rent2 = new System.Windows.Forms.Button();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Rating2 = new System.Windows.Forms.Label();
            this.grp_Movie3 = new System.Windows.Forms.GroupBox();
            this.lbl_Genre3 = new System.Windows.Forms.Label();
            this.txt_Desc3 = new System.Windows.Forms.TextBox();
            this.btn_Rent3 = new System.Windows.Forms.Button();
            this.lbl_Title3 = new System.Windows.Forms.Label();
            this.lbl_Rating3 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_ShowRentals = new System.Windows.Forms.Button();
            this.grp_Movie1.SuspendLayout();
            this.grp_Movie2.SuspendLayout();
            this.grp_Movie3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ScrollLeft
            // 
            this.btn_ScrollLeft.Location = new System.Drawing.Point(6, 22);
            this.btn_ScrollLeft.Name = "btn_ScrollLeft";
            this.btn_ScrollLeft.Size = new System.Drawing.Size(26, 172);
            this.btn_ScrollLeft.TabIndex = 0;
            this.btn_ScrollLeft.Text = "<-";
            this.btn_ScrollLeft.UseVisualStyleBackColor = true;
            this.btn_ScrollLeft.Click += new System.EventHandler(this.btn_ScrollLeft_Click);
            // 
            // btn_ScrollRight
            // 
            this.btn_ScrollRight.Location = new System.Drawing.Point(776, 22);
            this.btn_ScrollRight.Name = "btn_ScrollRight";
            this.btn_ScrollRight.Size = new System.Drawing.Size(26, 172);
            this.btn_ScrollRight.TabIndex = 0;
            this.btn_ScrollRight.Text = "->";
            this.btn_ScrollRight.UseVisualStyleBackColor = true;
            this.btn_ScrollRight.Click += new System.EventHandler(this.btn_ScrollRight_Click);
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.Location = new System.Drawing.Point(50, 16);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(128, 42);
            this.lbl_Title1.TabIndex = 1;
            this.lbl_Title1.Text = "Title 1";
            this.lbl_Title1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Rating1
            // 
            this.lbl_Rating1.AutoSize = true;
            this.lbl_Rating1.Location = new System.Drawing.Point(62, 63);
            this.lbl_Rating1.Name = "lbl_Rating1";
            this.lbl_Rating1.Size = new System.Drawing.Size(104, 13);
            this.lbl_Rating1.TabIndex = 1;
            this.lbl_Rating1.Text = "Rating: ★★★★★";
            // 
            // grp_Movie1
            // 
            this.grp_Movie1.Controls.Add(this.lbl_Genre1);
            this.grp_Movie1.Controls.Add(this.txt_Desc1);
            this.grp_Movie1.Controls.Add(this.btn_Rent1);
            this.grp_Movie1.Controls.Add(this.lbl_Title1);
            this.grp_Movie1.Controls.Add(this.lbl_Rating1);
            this.grp_Movie1.Location = new System.Drawing.Point(38, 6);
            this.grp_Movie1.Name = "grp_Movie1";
            this.grp_Movie1.Size = new System.Drawing.Size(240, 204);
            this.grp_Movie1.TabIndex = 2;
            this.grp_Movie1.TabStop = false;
            // 
            // lbl_Genre1
            // 
            this.lbl_Genre1.AutoSize = true;
            this.lbl_Genre1.Location = new System.Drawing.Point(96, 45);
            this.lbl_Genre1.Name = "lbl_Genre1";
            this.lbl_Genre1.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre1.TabIndex = 6;
            this.lbl_Genre1.Text = "Genre";
            // 
            // txt_Desc1
            // 
            this.txt_Desc1.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Desc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Desc1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Desc1.Location = new System.Drawing.Point(6, 82);
            this.txt_Desc1.Multiline = true;
            this.txt_Desc1.Name = "txt_Desc1";
            this.txt_Desc1.ReadOnly = true;
            this.txt_Desc1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Desc1.Size = new System.Drawing.Size(228, 80);
            this.txt_Desc1.TabIndex = 5;
            this.txt_Desc1.Text = resources.GetString("txt_Desc1.Text");
            this.txt_Desc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Rent1
            // 
            this.btn_Rent1.Location = new System.Drawing.Point(78, 165);
            this.btn_Rent1.Name = "btn_Rent1";
            this.btn_Rent1.Size = new System.Drawing.Size(75, 23);
            this.btn_Rent1.TabIndex = 3;
            this.btn_Rent1.Text = "Rent";
            this.btn_Rent1.UseVisualStyleBackColor = true;
            this.btn_Rent1.Click += new System.EventHandler(this.btn_Rent1_Click);
            // 
            // grp_Movie2
            // 
            this.grp_Movie2.Controls.Add(this.lbl_Genre2);
            this.grp_Movie2.Controls.Add(this.txt_Desc2);
            this.grp_Movie2.Controls.Add(this.btn_Rent2);
            this.grp_Movie2.Controls.Add(this.lbl_Title2);
            this.grp_Movie2.Controls.Add(this.lbl_Rating2);
            this.grp_Movie2.Location = new System.Drawing.Point(284, 6);
            this.grp_Movie2.Name = "grp_Movie2";
            this.grp_Movie2.Size = new System.Drawing.Size(240, 204);
            this.grp_Movie2.TabIndex = 2;
            this.grp_Movie2.TabStop = false;
            // 
            // lbl_Genre2
            // 
            this.lbl_Genre2.AutoSize = true;
            this.lbl_Genre2.Location = new System.Drawing.Point(96, 45);
            this.lbl_Genre2.Name = "lbl_Genre2";
            this.lbl_Genre2.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre2.TabIndex = 6;
            this.lbl_Genre2.Text = "Genre";
            // 
            // txt_Desc2
            // 
            this.txt_Desc2.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Desc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Desc2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Desc2.Location = new System.Drawing.Point(6, 82);
            this.txt_Desc2.Multiline = true;
            this.txt_Desc2.Name = "txt_Desc2";
            this.txt_Desc2.ReadOnly = true;
            this.txt_Desc2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Desc2.Size = new System.Drawing.Size(228, 80);
            this.txt_Desc2.TabIndex = 5;
            this.txt_Desc2.Text = resources.GetString("txt_Desc2.Text");
            this.txt_Desc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Rent2
            // 
            this.btn_Rent2.Location = new System.Drawing.Point(81, 165);
            this.btn_Rent2.Name = "btn_Rent2";
            this.btn_Rent2.Size = new System.Drawing.Size(75, 23);
            this.btn_Rent2.TabIndex = 3;
            this.btn_Rent2.Text = "Rent";
            this.btn_Rent2.UseVisualStyleBackColor = true;
            this.btn_Rent2.Click += new System.EventHandler(this.btn_Rent2_Click);
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.Location = new System.Drawing.Point(50, 16);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(128, 42);
            this.lbl_Title2.TabIndex = 1;
            this.lbl_Title2.Text = "Title 2";
            this.lbl_Title2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Rating2
            // 
            this.lbl_Rating2.AutoSize = true;
            this.lbl_Rating2.Location = new System.Drawing.Point(61, 63);
            this.lbl_Rating2.Name = "lbl_Rating2";
            this.lbl_Rating2.Size = new System.Drawing.Size(104, 13);
            this.lbl_Rating2.TabIndex = 1;
            this.lbl_Rating2.Text = "Rating: ★★★★★";
            // 
            // grp_Movie3
            // 
            this.grp_Movie3.Controls.Add(this.lbl_Genre3);
            this.grp_Movie3.Controls.Add(this.txt_Desc3);
            this.grp_Movie3.Controls.Add(this.btn_Rent3);
            this.grp_Movie3.Controls.Add(this.lbl_Title3);
            this.grp_Movie3.Controls.Add(this.lbl_Rating3);
            this.grp_Movie3.Location = new System.Drawing.Point(530, 6);
            this.grp_Movie3.Name = "grp_Movie3";
            this.grp_Movie3.Size = new System.Drawing.Size(240, 204);
            this.grp_Movie3.TabIndex = 2;
            this.grp_Movie3.TabStop = false;
            // 
            // lbl_Genre3
            // 
            this.lbl_Genre3.AutoSize = true;
            this.lbl_Genre3.Location = new System.Drawing.Point(100, 45);
            this.lbl_Genre3.Name = "lbl_Genre3";
            this.lbl_Genre3.Size = new System.Drawing.Size(36, 13);
            this.lbl_Genre3.TabIndex = 6;
            this.lbl_Genre3.Text = "Genre";
            // 
            // txt_Desc3
            // 
            this.txt_Desc3.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Desc3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Desc3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Desc3.Location = new System.Drawing.Point(6, 82);
            this.txt_Desc3.Multiline = true;
            this.txt_Desc3.Name = "txt_Desc3";
            this.txt_Desc3.ReadOnly = true;
            this.txt_Desc3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Desc3.Size = new System.Drawing.Size(228, 80);
            this.txt_Desc3.TabIndex = 5;
            this.txt_Desc3.Text = resources.GetString("txt_Desc3.Text");
            this.txt_Desc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Rent3
            // 
            this.btn_Rent3.Location = new System.Drawing.Point(81, 165);
            this.btn_Rent3.Name = "btn_Rent3";
            this.btn_Rent3.Size = new System.Drawing.Size(75, 23);
            this.btn_Rent3.TabIndex = 3;
            this.btn_Rent3.Text = "Rent";
            this.btn_Rent3.UseVisualStyleBackColor = true;
            this.btn_Rent3.Click += new System.EventHandler(this.btn_Rent3_Click);
            // 
            // lbl_Title3
            // 
            this.lbl_Title3.Location = new System.Drawing.Point(53, 16);
            this.lbl_Title3.Name = "lbl_Title3";
            this.lbl_Title3.Size = new System.Drawing.Size(128, 42);
            this.lbl_Title3.TabIndex = 1;
            this.lbl_Title3.Text = "Title 3";
            this.lbl_Title3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Rating3
            // 
            this.lbl_Rating3.AutoSize = true;
            this.lbl_Rating3.Location = new System.Drawing.Point(66, 63);
            this.lbl_Rating3.Name = "lbl_Rating3";
            this.lbl_Rating3.Size = new System.Drawing.Size(104, 13);
            this.lbl_Rating3.TabIndex = 1;
            this.lbl_Rating3.Text = "Rating: ★★★★★";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(489, 225);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 52);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_ShowRentals
            // 
            this.btn_ShowRentals.Location = new System.Drawing.Point(242, 225);
            this.btn_ShowRentals.Name = "btn_ShowRentals";
            this.btn_ShowRentals.Size = new System.Drawing.Size(75, 52);
            this.btn_ShowRentals.TabIndex = 4;
            this.btn_ShowRentals.Text = "View your rentals";
            this.btn_ShowRentals.UseVisualStyleBackColor = true;
            this.btn_ShowRentals.Click += new System.EventHandler(this.btn_ShowRentals_Click);
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 291);
            this.Controls.Add(this.btn_ShowRentals);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.grp_Movie3);
            this.Controls.Add(this.grp_Movie2);
            this.Controls.Add(this.grp_Movie1);
            this.Controls.Add(this.btn_ScrollRight);
            this.Controls.Add(this.btn_ScrollLeft);
            this.Name = "BrowseForm";
            this.Text = "Browse Movies";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            this.grp_Movie1.ResumeLayout(false);
            this.grp_Movie1.PerformLayout();
            this.grp_Movie2.ResumeLayout(false);
            this.grp_Movie2.PerformLayout();
            this.grp_Movie3.ResumeLayout(false);
            this.grp_Movie3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ScrollLeft;
        private System.Windows.Forms.Button btn_ScrollRight;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.Label lbl_Rating1;
        private System.Windows.Forms.GroupBox grp_Movie1;
        private System.Windows.Forms.GroupBox grp_Movie2;
        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Label lbl_Rating2;
        private System.Windows.Forms.GroupBox grp_Movie3;
        private System.Windows.Forms.Label lbl_Title3;
        private System.Windows.Forms.Label lbl_Rating3;
        private System.Windows.Forms.Button btn_Rent1;
        private System.Windows.Forms.Button btn_Rent2;
        private System.Windows.Forms.Button btn_Rent3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_ShowRentals;
        private System.Windows.Forms.TextBox txt_Desc1;
        private System.Windows.Forms.TextBox txt_Desc2;
        private System.Windows.Forms.TextBox txt_Desc3;
        private System.Windows.Forms.Label lbl_Genre1;
        private System.Windows.Forms.Label lbl_Genre2;
        private System.Windows.Forms.Label lbl_Genre3;
    }
}