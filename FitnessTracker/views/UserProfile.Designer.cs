namespace FitnessTracker.views
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.PictureBox();
            this.Track = new System.Windows.Forms.Label();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Lbl_error_height = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_height = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_error_weight = new System.Windows.Forms.Label();
            this.Txt_weight = new System.Windows.Forms.TextBox();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_current_height = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_current_weight = new System.Windows.Forms.Label();
            this.Lbl_total_calories_burned = new System.Windows.Forms.Label();
            this.Lbl_greet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Btn_back);
            this.panel1.Controls.Add(this.Track);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 71);
            this.panel1.TabIndex = 2;
            // 
            // Btn_back
            // 
            this.Btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_back.Image")));
            this.Btn_back.Location = new System.Drawing.Point(35, 24);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(17, 19);
            this.Btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_back.TabIndex = 11;
            this.Btn_back.TabStop = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.Color.White;
            this.Track.Location = new System.Drawing.Point(269, 24);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(71, 24);
            this.Track.TabIndex = 0;
            this.Track.Text = "Profile";
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update.ForeColor = System.Drawing.Color.White;
            this.Btn_update.Location = new System.Drawing.Point(326, 380);
            this.Btn_update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(241, 39);
            this.Btn_update.TabIndex = 95;
            this.Btn_update.Text = "Update";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Lbl_error_height
            // 
            this.Lbl_error_height.AutoSize = true;
            this.Lbl_error_height.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_height.Location = new System.Drawing.Point(329, 338);
            this.Lbl_error_height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_height.Name = "Lbl_error_height";
            this.Lbl_error_height.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_height.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(326, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 93;
            this.label11.Text = "Height (cm): ";
            // 
            // Txt_height
            // 
            this.Txt_height.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_height.Location = new System.Drawing.Point(326, 307);
            this.Txt_height.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_height.Name = "Txt_height";
            this.Txt_height.Size = new System.Drawing.Size(243, 28);
            this.Txt_height.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(326, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Weight (kg):";
            // 
            // Lbl_error_weight
            // 
            this.Lbl_error_weight.AutoSize = true;
            this.Lbl_error_weight.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_weight.Location = new System.Drawing.Point(326, 248);
            this.Lbl_error_weight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_weight.Name = "Lbl_error_weight";
            this.Lbl_error_weight.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_weight.TabIndex = 90;
            // 
            // Txt_weight
            // 
            this.Txt_weight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_weight.Location = new System.Drawing.Point(326, 219);
            this.Txt_weight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_weight.Name = "Txt_weight";
            this.Txt_weight.Size = new System.Drawing.Size(243, 28);
            this.Txt_weight.TabIndex = 89;
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_logout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_logout.ForeColor = System.Drawing.Color.White;
            this.Btn_logout.Location = new System.Drawing.Point(44, 489);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(143, 39);
            this.Btn_logout.TabIndex = 88;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(355, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 87;
            this.label5.Text = "Update Profile";
            // 
            // Lbl_current_height
            // 
            this.Lbl_current_height.AutoSize = true;
            this.Lbl_current_height.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_current_height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_current_height.Location = new System.Drawing.Point(37, 305);
            this.Lbl_current_height.Name = "Lbl_current_height";
            this.Lbl_current_height.Size = new System.Drawing.Size(89, 27);
            this.Lbl_current_height.TabIndex = 83;
            this.Lbl_current_height.Text = "189 cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(39, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 86;
            this.label3.Text = "Total burned calories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(33, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Weight";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(35, 107);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 45);
            this.panel7.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(39, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Height";
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_username.Location = new System.Drawing.Point(47, 125);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(124, 27);
            this.Lbl_username.TabIndex = 79;
            this.Lbl_username.Text = "Username";
            // 
            // Lbl_current_weight
            // 
            this.Lbl_current_weight.AutoSize = true;
            this.Lbl_current_weight.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_current_weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_current_weight.Location = new System.Drawing.Point(34, 220);
            this.Lbl_current_weight.Name = "Lbl_current_weight";
            this.Lbl_current_weight.Size = new System.Drawing.Size(71, 27);
            this.Lbl_current_weight.TabIndex = 82;
            this.Lbl_current_weight.Text = "80 kg";
            // 
            // Lbl_total_calories_burned
            // 
            this.Lbl_total_calories_burned.AutoSize = true;
            this.Lbl_total_calories_burned.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total_calories_burned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_total_calories_burned.Location = new System.Drawing.Point(39, 395);
            this.Lbl_total_calories_burned.Name = "Lbl_total_calories_burned";
            this.Lbl_total_calories_burned.Size = new System.Drawing.Size(103, 27);
            this.Lbl_total_calories_burned.TabIndex = 84;
            this.Lbl_total_calories_burned.Text = "8000 cal";
            // 
            // Lbl_greet
            // 
            this.Lbl_greet.AutoSize = true;
            this.Lbl_greet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_greet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_greet.Location = new System.Drawing.Point(47, 105);
            this.Lbl_greet.Name = "Lbl_greet";
            this.Lbl_greet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_greet.Size = new System.Drawing.Size(71, 19);
            this.Lbl_greet.TabIndex = 78;
            this.Lbl_greet.Text = "Greeting";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 573);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Lbl_error_height);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_height);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_error_weight);
            this.Controls.Add(this.Txt_weight);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_current_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.Lbl_current_weight);
            this.Controls.Add(this.Lbl_total_calories_burned);
            this.Controls.Add(this.Lbl_greet);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Btn_back;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.Label Lbl_error_height;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_height;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_error_weight;
        private System.Windows.Forms.TextBox Txt_weight;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_current_height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_current_weight;
        private System.Windows.Forms.Label Lbl_total_calories_burned;
        private System.Windows.Forms.Label Lbl_greet;
    }
}