namespace MeramecNetFlixProject.UI
{
    partial class MainMenuForm
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
            this.btn_GenreUI = new System.Windows.Forms.Button();
            this.btn_MemberUI = new System.Windows.Forms.Button();
            this.btn_MovieUI = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActiveMemberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_editData = new System.Windows.Forms.GroupBox();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Movies = new System.Windows.Forms.Button();
            this.btn_ShowRentals = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grp_editData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenreUI
            // 
            this.btn_GenreUI.Location = new System.Drawing.Point(19, 61);
            this.btn_GenreUI.Name = "btn_GenreUI";
            this.btn_GenreUI.Size = new System.Drawing.Size(93, 23);
            this.btn_GenreUI.TabIndex = 0;
            this.btn_GenreUI.Text = "GenreData";
            this.btn_GenreUI.UseVisualStyleBackColor = true;
            this.btn_GenreUI.Click += new System.EventHandler(this.btn_GenreUI_Click);
            // 
            // btn_MemberUI
            // 
            this.btn_MemberUI.Location = new System.Drawing.Point(19, 32);
            this.btn_MemberUI.Name = "btn_MemberUI";
            this.btn_MemberUI.Size = new System.Drawing.Size(93, 23);
            this.btn_MemberUI.TabIndex = 0;
            this.btn_MemberUI.Text = "MemberData";
            this.btn_MemberUI.UseVisualStyleBackColor = true;
            this.btn_MemberUI.Click += new System.EventHandler(this.btn_MemberUI_Click);
            // 
            // btn_MovieUI
            // 
            this.btn_MovieUI.Location = new System.Drawing.Point(19, 90);
            this.btn_MovieUI.Name = "btn_MovieUI";
            this.btn_MovieUI.Size = new System.Drawing.Size(93, 23);
            this.btn_MovieUI.TabIndex = 0;
            this.btn_MovieUI.Text = "MovieData";
            this.btn_MovieUI.UseVisualStyleBackColor = true;
            this.btn_MovieUI.Click += new System.EventHandler(this.btn_MovieUI_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 236);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 37);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Switch Accounts";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ActiveMemberLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(289, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Logged in as:";
            // 
            // ActiveMemberLabel
            // 
            this.ActiveMemberLabel.Name = "ActiveMemberLabel";
            this.ActiveMemberLabel.Size = new System.Drawing.Size(43, 17);
            this.ActiveMemberLabel.Text = "ERROR";
            // 
            // grp_editData
            // 
            this.grp_editData.Controls.Add(this.btn_MemberUI);
            this.grp_editData.Controls.Add(this.btn_GenreUI);
            this.grp_editData.Controls.Add(this.btn_MovieUI);
            this.grp_editData.Location = new System.Drawing.Point(79, 81);
            this.grp_editData.Name = "grp_editData";
            this.grp_editData.Size = new System.Drawing.Size(132, 129);
            this.grp_editData.TabIndex = 2;
            this.grp_editData.TabStop = false;
            this.grp_editData.Text = "Add/Remove Data";
            this.grp_editData.Visible = false;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(177, 237);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(100, 37);
            this.btn_Quit.TabIndex = 0;
            this.btn_Quit.Text = "Logout and Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_Movies
            // 
            this.btn_Movies.Location = new System.Drawing.Point(177, 12);
            this.btn_Movies.Name = "btn_Movies";
            this.btn_Movies.Size = new System.Drawing.Size(100, 37);
            this.btn_Movies.TabIndex = 0;
            this.btn_Movies.Text = "Browse Movies";
            this.btn_Movies.UseVisualStyleBackColor = true;
            this.btn_Movies.Click += new System.EventHandler(this.btn_Movies_Click);
            // 
            // btn_ShowRentals
            // 
            this.btn_ShowRentals.Location = new System.Drawing.Point(12, 12);
            this.btn_ShowRentals.Name = "btn_ShowRentals";
            this.btn_ShowRentals.Size = new System.Drawing.Size(100, 37);
            this.btn_ShowRentals.TabIndex = 3;
            this.btn_ShowRentals.Text = "View Your Rentals";
            this.btn_ShowRentals.UseVisualStyleBackColor = true;
            this.btn_ShowRentals.Click += new System.EventHandler(this.btn_ShowRentals_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 308);
            this.Controls.Add(this.btn_ShowRentals);
            this.Controls.Add(this.grp_editData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Movies);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Login);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_editData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GenreUI;
        private System.Windows.Forms.Button btn_MemberUI;
        private System.Windows.Forms.Button btn_MovieUI;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ActiveMemberLabel;
        private System.Windows.Forms.GroupBox grp_editData;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Movies;
        private System.Windows.Forms.Button btn_ShowRentals;
    }
}