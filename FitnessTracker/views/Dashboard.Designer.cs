namespace FitnessTracker.views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lbl_burn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_height = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_weight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_profile = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_logout = new System.Windows.Forms.Button();
            this.Lbl_greet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_percent = new System.Windows.Forms.Label();
            this.Lbl_message = new System.Windows.Forms.Label();
            this.Lbl_percentage = new System.Windows.Forms.Label();
            this.Lbl_calories_rate = new System.Windows.Forms.Label();
            this.Prog_goal = new System.Windows.Forms.ProgressBar();
            this.Lbl_set_calories = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_link_setGoal = new System.Windows.Forms.Button();
            this.Btn_link_activities = new System.Windows.Forms.Button();
            this.Btn_progress_monitoring = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel_recent = new System.Windows.Forms.Panel();
            this.Lbl_no_recent = new System.Windows.Forms.Label();
            this.Lbl_calories_burned_3 = new System.Windows.Forms.Label();
            this.Lbl_activity_name_3 = new System.Windows.Forms.Label();
            this.Lbl_calories_burned_2 = new System.Windows.Forms.Label();
            this.Lbl_activity_name_2 = new System.Windows.Forms.Label();
            this.Lbl_calories_burned_1 = new System.Windows.Forms.Label();
            this.Lbl_activity_name_1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ActivityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lbl_no_activities = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_recent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.Lbl_burn);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(602, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 75);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(185, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Lbl_burn
            // 
            this.Lbl_burn.AutoSize = true;
            this.Lbl_burn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_burn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_burn.Location = new System.Drawing.Point(14, 33);
            this.Lbl_burn.Name = "Lbl_burn";
            this.Lbl_burn.Size = new System.Drawing.Size(96, 33);
            this.Lbl_burn.TabIndex = 3;
            this.Lbl_burn.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Burned";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.Lbl_height);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(309, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 75);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_height
            // 
            this.Lbl_height.AutoSize = true;
            this.Lbl_height.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_height.Location = new System.Drawing.Point(16, 33);
            this.Lbl_height.Name = "Lbl_height";
            this.Lbl_height.Size = new System.Drawing.Size(96, 33);
            this.Lbl_height.TabIndex = 2;
            this.Lbl_height.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.Lbl_weight);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(25, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 75);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_weight
            // 
            this.Lbl_weight.AutoSize = true;
            this.Lbl_weight.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_weight.Location = new System.Drawing.Point(10, 33);
            this.Lbl_weight.Name = "Lbl_weight";
            this.Lbl_weight.Size = new System.Drawing.Size(96, 33);
            this.Lbl_weight.TabIndex = 1;
            this.Lbl_weight.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Btn_profile);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.Lbl_username);
            this.panel1.Controls.Add(this.Lbl_logout);
            this.panel1.Controls.Add(this.Lbl_greet);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 128);
            this.panel1.TabIndex = 3;
            // 
            // Btn_profile
            // 
            this.Btn_profile.BackColor = System.Drawing.Color.White;
            this.Btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_profile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_profile.ForeColor = System.Drawing.Color.Black;
            this.Btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("Btn_profile.Image")));
            this.Btn_profile.Location = new System.Drawing.Point(674, 21);
            this.Btn_profile.Name = "Btn_profile";
            this.Btn_profile.Size = new System.Drawing.Size(37, 39);
            this.Btn_profile.TabIndex = 56;
            this.Btn_profile.UseVisualStyleBackColor = false;
            this.Btn_profile.Click += new System.EventHandler(this.Btn_profile_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(25, 18);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 45);
            this.panel7.TabIndex = 55;
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.ForeColor = System.Drawing.Color.White;
            this.Lbl_username.Location = new System.Drawing.Point(37, 36);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(124, 27);
            this.Lbl_username.TabIndex = 4;
            this.Lbl_username.Text = "Username";
            // 
            // Lbl_logout
            // 
            this.Lbl_logout.BackColor = System.Drawing.Color.White;
            this.Lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_logout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_logout.ForeColor = System.Drawing.Color.Black;
            this.Lbl_logout.Location = new System.Drawing.Point(721, 21);
            this.Lbl_logout.Name = "Lbl_logout";
            this.Lbl_logout.Size = new System.Drawing.Size(143, 39);
            this.Lbl_logout.TabIndex = 8;
            this.Lbl_logout.Text = "Logout";
            this.Lbl_logout.UseVisualStyleBackColor = false;
            this.Lbl_logout.Click += new System.EventHandler(this.Lbl_logout_Click);
            // 
            // Lbl_greet
            // 
            this.Lbl_greet.AutoSize = true;
            this.Lbl_greet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_greet.ForeColor = System.Drawing.Color.White;
            this.Lbl_greet.Location = new System.Drawing.Point(37, 16);
            this.Lbl_greet.Name = "Lbl_greet";
            this.Lbl_greet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_greet.Size = new System.Drawing.Size(71, 19);
            this.Lbl_greet.TabIndex = 3;
            this.Lbl_greet.Text = "Greeting";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Lbl_percent);
            this.panel2.Controls.Add(this.Lbl_message);
            this.panel2.Controls.Add(this.Lbl_percentage);
            this.panel2.Controls.Add(this.Lbl_calories_rate);
            this.panel2.Controls.Add(this.Prog_goal);
            this.panel2.Controls.Add(this.Lbl_set_calories);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(602, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 246);
            this.panel2.TabIndex = 4;
            // 
            // Lbl_percent
            // 
            this.Lbl_percent.AutoSize = true;
            this.Lbl_percent.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_percent.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_percent.Location = new System.Drawing.Point(10, 123);
            this.Lbl_percent.Name = "Lbl_percent";
            this.Lbl_percent.Size = new System.Drawing.Size(147, 70);
            this.Lbl_percent.TabIndex = 10;
            this.Lbl_percent.Text = "70%";
            // 
            // Lbl_message
            // 
            this.Lbl_message.AutoSize = true;
            this.Lbl_message.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_message.Location = new System.Drawing.Point(401, 17);
            this.Lbl_message.Name = "Lbl_message";
            this.Lbl_message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_message.Size = new System.Drawing.Size(0, 19);
            this.Lbl_message.TabIndex = 9;
            // 
            // Lbl_percentage
            // 
            this.Lbl_percentage.AutoSize = true;
            this.Lbl_percentage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_percentage.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_percentage.Location = new System.Drawing.Point(750, 92);
            this.Lbl_percentage.Name = "Lbl_percentage";
            this.Lbl_percentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_percentage.Size = new System.Drawing.Size(42, 19);
            this.Lbl_percentage.TabIndex = 8;
            this.Lbl_percentage.Text = "70%";
            // 
            // Lbl_calories_rate
            // 
            this.Lbl_calories_rate.AutoSize = true;
            this.Lbl_calories_rate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calories_rate.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_calories_rate.Location = new System.Drawing.Point(16, 211);
            this.Lbl_calories_rate.Name = "Lbl_calories_rate";
            this.Lbl_calories_rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_calories_rate.Size = new System.Drawing.Size(130, 19);
            this.Lbl_calories_rate.TabIndex = 7;
            this.Lbl_calories_rate.Text = "1500 / 2000 kcal";
            // 
            // Prog_goal
            // 
            this.Prog_goal.BackColor = System.Drawing.Color.DimGray;
            this.Prog_goal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Prog_goal.Location = new System.Drawing.Point(22, 196);
            this.Prog_goal.Name = "Prog_goal";
            this.Prog_goal.Size = new System.Drawing.Size(225, 10);
            this.Prog_goal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Prog_goal.TabIndex = 6;
            // 
            // Lbl_set_calories
            // 
            this.Lbl_set_calories.AutoSize = true;
            this.Lbl_set_calories.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_set_calories.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_set_calories.Location = new System.Drawing.Point(16, 45);
            this.Lbl_set_calories.Name = "Lbl_set_calories";
            this.Lbl_set_calories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_set_calories.Size = new System.Drawing.Size(175, 19);
            this.Lbl_set_calories.TabIndex = 5;
            this.Lbl_set_calories.Text = "Set a daily calorie goal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Progress Report";
            // 
            // Btn_link_setGoal
            // 
            this.Btn_link_setGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_link_setGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_link_setGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_link_setGoal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_link_setGoal.ForeColor = System.Drawing.Color.White;
            this.Btn_link_setGoal.Location = new System.Drawing.Point(25, 657);
            this.Btn_link_setGoal.Name = "Btn_link_setGoal";
            this.Btn_link_setGoal.Size = new System.Drawing.Size(264, 74);
            this.Btn_link_setGoal.TabIndex = 5;
            this.Btn_link_setGoal.Text = "Set Goals";
            this.Btn_link_setGoal.UseVisualStyleBackColor = false;
            this.Btn_link_setGoal.Click += new System.EventHandler(this.Btn_link_setGoal_Click);
            // 
            // Btn_link_activities
            // 
            this.Btn_link_activities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_link_activities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_link_activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_link_activities.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_link_activities.ForeColor = System.Drawing.Color.White;
            this.Btn_link_activities.Location = new System.Drawing.Point(309, 657);
            this.Btn_link_activities.Name = "Btn_link_activities";
            this.Btn_link_activities.Size = new System.Drawing.Size(270, 74);
            this.Btn_link_activities.TabIndex = 6;
            this.Btn_link_activities.Text = "Record activities";
            this.Btn_link_activities.UseVisualStyleBackColor = false;
            this.Btn_link_activities.Click += new System.EventHandler(this.Btn_link_activities_Click);
            // 
            // Btn_progress_monitoring
            // 
            this.Btn_progress_monitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_progress_monitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_progress_monitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_progress_monitoring.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_progress_monitoring.ForeColor = System.Drawing.Color.White;
            this.Btn_progress_monitoring.Location = new System.Drawing.Point(601, 657);
            this.Btn_progress_monitoring.Name = "Btn_progress_monitoring";
            this.Btn_progress_monitoring.Size = new System.Drawing.Size(264, 74);
            this.Btn_progress_monitoring.TabIndex = 7;
            this.Btn_progress_monitoring.Text = "Progress monitoring";
            this.Btn_progress_monitoring.UseVisualStyleBackColor = false;
            this.Btn_progress_monitoring.Click += new System.EventHandler(this.Btn_progress_monitoring_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel_recent
            // 
            this.panel_recent.BackColor = System.Drawing.Color.White;
            this.panel_recent.Controls.Add(this.Lbl_no_recent);
            this.panel_recent.Controls.Add(this.Lbl_calories_burned_3);
            this.panel_recent.Controls.Add(this.Lbl_activity_name_3);
            this.panel_recent.Controls.Add(this.Lbl_calories_burned_2);
            this.panel_recent.Controls.Add(this.Lbl_activity_name_2);
            this.panel_recent.Controls.Add(this.Lbl_calories_burned_1);
            this.panel_recent.Controls.Add(this.Lbl_activity_name_1);
            this.panel_recent.Controls.Add(this.label9);
            this.panel_recent.Controls.Add(this.label10);
            this.panel_recent.Location = new System.Drawing.Point(25, 391);
            this.panel_recent.Name = "panel_recent";
            this.panel_recent.Size = new System.Drawing.Size(554, 246);
            this.panel_recent.TabIndex = 11;
            // 
            // Lbl_no_recent
            // 
            this.Lbl_no_recent.AutoSize = true;
            this.Lbl_no_recent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_no_recent.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_no_recent.Location = new System.Drawing.Point(193, 138);
            this.Lbl_no_recent.Name = "Lbl_no_recent";
            this.Lbl_no_recent.Size = new System.Drawing.Size(241, 24);
            this.Lbl_no_recent.TabIndex = 12;
            this.Lbl_no_recent.Text = "No Recent Activities Yet.";
            // 
            // Lbl_calories_burned_3
            // 
            this.Lbl_calories_burned_3.AutoSize = true;
            this.Lbl_calories_burned_3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calories_burned_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_calories_burned_3.Location = new System.Drawing.Point(436, 196);
            this.Lbl_calories_burned_3.Name = "Lbl_calories_burned_3";
            this.Lbl_calories_burned_3.Size = new System.Drawing.Size(70, 19);
            this.Lbl_calories_burned_3.TabIndex = 11;
            this.Lbl_calories_burned_3.Text = "400 kcal";
            // 
            // Lbl_activity_name_3
            // 
            this.Lbl_activity_name_3.AutoSize = true;
            this.Lbl_activity_name_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_activity_name_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_activity_name_3.Location = new System.Drawing.Point(20, 197);
            this.Lbl_activity_name_3.Name = "Lbl_activity_name_3";
            this.Lbl_activity_name_3.Size = new System.Drawing.Size(167, 24);
            this.Lbl_activity_name_3.TabIndex = 10;
            this.Lbl_activity_name_3.Text = "Recent Activities";
            // 
            // Lbl_calories_burned_2
            // 
            this.Lbl_calories_burned_2.AutoSize = true;
            this.Lbl_calories_burned_2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calories_burned_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_calories_burned_2.Location = new System.Drawing.Point(436, 152);
            this.Lbl_calories_burned_2.Name = "Lbl_calories_burned_2";
            this.Lbl_calories_burned_2.Size = new System.Drawing.Size(45, 19);
            this.Lbl_calories_burned_2.TabIndex = 9;
            this.Lbl_calories_burned_2.Text = "3000";
            // 
            // Lbl_activity_name_2
            // 
            this.Lbl_activity_name_2.AutoSize = true;
            this.Lbl_activity_name_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_activity_name_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_activity_name_2.Location = new System.Drawing.Point(20, 149);
            this.Lbl_activity_name_2.Name = "Lbl_activity_name_2";
            this.Lbl_activity_name_2.Size = new System.Drawing.Size(167, 24);
            this.Lbl_activity_name_2.TabIndex = 8;
            this.Lbl_activity_name_2.Text = "Recent Activities";
            // 
            // Lbl_calories_burned_1
            // 
            this.Lbl_calories_burned_1.AutoSize = true;
            this.Lbl_calories_burned_1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calories_burned_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_calories_burned_1.Location = new System.Drawing.Point(436, 106);
            this.Lbl_calories_burned_1.Name = "Lbl_calories_burned_1";
            this.Lbl_calories_burned_1.Size = new System.Drawing.Size(70, 19);
            this.Lbl_calories_burned_1.TabIndex = 7;
            this.Lbl_calories_burned_1.Text = "200 kcal";
            // 
            // Lbl_activity_name_1
            // 
            this.Lbl_activity_name_1.AutoSize = true;
            this.Lbl_activity_name_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_activity_name_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_activity_name_1.Location = new System.Drawing.Point(20, 101);
            this.Lbl_activity_name_1.Name = "Lbl_activity_name_1";
            this.Lbl_activity_name_1.Size = new System.Drawing.Size(167, 24);
            this.Lbl_activity_name_1.TabIndex = 6;
            this.Lbl_activity_name_1.Text = "Recent Activities";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(16, 45);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(252, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Your latest workouts and activities";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 33);
            this.label10.TabIndex = 5;
            this.label10.Text = "Recent Activities";
            // 
            // ActivityChart
            // 
            this.ActivityChart.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.ActivityChart.ChartAreas.Add(chartArea2);
            legend2.CustomItems.Add(legendItem2);
            legend2.Name = "Legend1";
            this.ActivityChart.Legends.Add(legend2);
            this.ActivityChart.Location = new System.Drawing.Point(26, 179);
            this.ActivityChart.Name = "ActivityChart";
            this.ActivityChart.Padding = new System.Windows.Forms.Padding(10);
            this.ActivityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ActivityChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Navy};
            this.ActivityChart.Size = new System.Drawing.Size(839, 194);
            this.ActivityChart.TabIndex = 30;
            this.ActivityChart.Text = "Activity chart";
            // 
            // Lbl_no_activities
            // 
            this.Lbl_no_activities.AutoSize = true;
            this.Lbl_no_activities.BackColor = System.Drawing.Color.White;
            this.Lbl_no_activities.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_no_activities.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_no_activities.Location = new System.Drawing.Point(352, 262);
            this.Lbl_no_activities.Name = "Lbl_no_activities";
            this.Lbl_no_activities.Size = new System.Drawing.Size(255, 24);
            this.Lbl_no_activities.TabIndex = 13;
            this.Lbl_no_activities.Text = "There is not activities yet.";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(894, 753);
            this.Controls.Add(this.Lbl_no_activities);
            this.Controls.Add(this.panel_recent);
            this.Controls.Add(this.ActivityChart);
            this.Controls.Add(this.Btn_progress_monitoring);
            this.Controls.Add(this.Btn_link_activities);
            this.Controls.Add(this.Btn_link_setGoal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_recent.ResumeLayout(false);
            this.panel_recent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_weight;
        private System.Windows.Forms.Label Lbl_burn;
        private System.Windows.Forms.Label Lbl_height;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_greet;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar Prog_goal;
        private System.Windows.Forms.Label Lbl_set_calories;
        private System.Windows.Forms.Label Lbl_calories_rate;
        private System.Windows.Forms.Label Lbl_percentage;
        private System.Windows.Forms.Button Btn_link_setGoal;
        private System.Windows.Forms.Button Btn_link_activities;
        private System.Windows.Forms.Button Btn_progress_monitoring;
        private System.Windows.Forms.Button Lbl_logout;
        private System.Windows.Forms.Label Lbl_message;
        private System.Windows.Forms.Label Lbl_percent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel_recent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Lbl_activity_name_1;
        private System.Windows.Forms.Label Lbl_calories_burned_3;
        private System.Windows.Forms.Label Lbl_activity_name_3;
        private System.Windows.Forms.Label Lbl_calories_burned_2;
        private System.Windows.Forms.Label Lbl_activity_name_2;
        private System.Windows.Forms.Label Lbl_calories_burned_1;
        private System.Windows.Forms.Label Lbl_no_recent;
        private System.Windows.Forms.DataVisualization.Charting.Chart ActivityChart;
        private System.Windows.Forms.Button Btn_profile;
        private System.Windows.Forms.Label Lbl_no_activities;
    }
}