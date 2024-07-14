namespace FitnessTracker.views
{
    partial class MonitorProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorProgress));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.PictureBox();
            this.Track = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_day_msg = new System.Windows.Forms.Label();
            this.Lbl_total_calories = new System.Windows.Forms.Label();
            this.Lbl_burend = new System.Windows.Forms.Label();
            this.Btn_today = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_total_goals = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_to = new System.Windows.Forms.DateTimePicker();
            this.Btn_filter = new System.Windows.Forms.Button();
            this.Grid_activity_histories = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_burned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_activity_histories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Btn_back);
            this.panel1.Controls.Add(this.Track);
            this.panel1.Location = new System.Drawing.Point(-4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 71);
            this.panel1.TabIndex = 0;
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
            this.Track.Location = new System.Drawing.Point(380, 27);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(203, 24);
            this.Track.TabIndex = 0;
            this.Track.Text = "Track your progress";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Lbl_day_msg);
            this.panel2.Controls.Add(this.Lbl_total_calories);
            this.panel2.Controls.Add(this.Lbl_burend);
            this.panel2.Location = new System.Drawing.Point(38, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 117);
            this.panel2.TabIndex = 1;
            // 
            // Lbl_day_msg
            // 
            this.Lbl_day_msg.AutoSize = true;
            this.Lbl_day_msg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_day_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_day_msg.Location = new System.Drawing.Point(223, 17);
            this.Lbl_day_msg.Name = "Lbl_day_msg";
            this.Lbl_day_msg.Size = new System.Drawing.Size(56, 18);
            this.Lbl_day_msg.TabIndex = 12;
            this.Lbl_day_msg.Text = "(today)";
            // 
            // Lbl_total_calories
            // 
            this.Lbl_total_calories.AutoSize = true;
            this.Lbl_total_calories.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_total_calories.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total_calories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_total_calories.Location = new System.Drawing.Point(10, 48);
            this.Lbl_total_calories.Name = "Lbl_total_calories";
            this.Lbl_total_calories.Size = new System.Drawing.Size(144, 44);
            this.Lbl_total_calories.TabIndex = 11;
            this.Lbl_total_calories.Text = "70 kcal";
            // 
            // Lbl_burend
            // 
            this.Lbl_burend.AutoSize = true;
            this.Lbl_burend.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_burend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_burend.Location = new System.Drawing.Point(13, 12);
            this.Lbl_burend.Name = "Lbl_burend";
            this.Lbl_burend.Size = new System.Drawing.Size(252, 27);
            this.Lbl_burend.TabIndex = 2;
            this.Lbl_burend.Text = "Total Calories burned";
            // 
            // Btn_today
            // 
            this.Btn_today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_today.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_today.ForeColor = System.Drawing.Color.White;
            this.Btn_today.Location = new System.Drawing.Point(473, 102);
            this.Btn_today.Name = "Btn_today";
            this.Btn_today.Size = new System.Drawing.Size(57, 30);
            this.Btn_today.TabIndex = 2;
            this.Btn_today.Text = "Today";
            this.Btn_today.UseVisualStyleBackColor = false;
            this.Btn_today.Click += new System.EventHandler(this.Btn_today_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Lbl_total_goals);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(548, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 117);
            this.panel3.TabIndex = 12;
            // 
            // Lbl_total_goals
            // 
            this.Lbl_total_goals.AutoSize = true;
            this.Lbl_total_goals.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_total_goals.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total_goals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_total_goals.Location = new System.Drawing.Point(10, 48);
            this.Lbl_total_goals.Name = "Lbl_total_goals";
            this.Lbl_total_goals.Size = new System.Drawing.Size(61, 44);
            this.Lbl_total_goals.TabIndex = 11;
            this.Lbl_total_goals.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total goals Achievement";
            // 
            // Date_from
            // 
            this.Date_from.Location = new System.Drawing.Point(38, 105);
            this.Date_from.Name = "Date_from";
            this.Date_from.Size = new System.Drawing.Size(154, 22);
            this.Date_from.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "From: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "To: ";
            // 
            // Date_to
            // 
            this.Date_to.Location = new System.Drawing.Point(198, 105);
            this.Date_to.Name = "Date_to";
            this.Date_to.Size = new System.Drawing.Size(154, 22);
            this.Date_to.TabIndex = 15;
            // 
            // Btn_filter
            // 
            this.Btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_filter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_filter.ForeColor = System.Drawing.Color.White;
            this.Btn_filter.Location = new System.Drawing.Point(358, 101);
            this.Btn_filter.Name = "Btn_filter";
            this.Btn_filter.Size = new System.Drawing.Size(65, 30);
            this.Btn_filter.TabIndex = 12;
            this.Btn_filter.Text = "Filter";
            this.Btn_filter.UseVisualStyleBackColor = false;
            this.Btn_filter.Click += new System.EventHandler(this.Btn_filter_Click);
            // 
            // Grid_activity_histories
            // 
            this.Grid_activity_histories.BackgroundColor = System.Drawing.Color.White;
            this.Grid_activity_histories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_activity_histories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Date,
            this.Name,
            this.Total_burned});
            this.Grid_activity_histories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Grid_activity_histories.Location = new System.Drawing.Point(38, 304);
            this.Grid_activity_histories.Name = "Grid_activity_histories";
            this.Grid_activity_histories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_activity_histories.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_activity_histories.RowHeadersVisible = false;
            this.Grid_activity_histories.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Grid_activity_histories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_activity_histories.RowTemplate.Height = 24;
            this.Grid_activity_histories.Size = new System.Drawing.Size(820, 385);
            this.Grid_activity_histories.TabIndex = 17;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 62;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 235;
            // 
            // Name
            // 
            this.Name.HeaderText = "Activity Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 250;
            // 
            // Total_burned
            // 
            this.Total_burned.HeaderText = "Total Burned";
            this.Total_burned.MinimumWidth = 6;
            this.Total_burned.Name = "Total_burned";
            this.Total_burned.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(34, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Activity Histories";
            // 
            // MonitorProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(894, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid_activity_histories);
            this.Controls.Add(this.Btn_filter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date_to);
            this.Controls.Add(this.Btn_today);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_from);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonitorProgress";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_activity_histories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_today;
        private System.Windows.Forms.Label Lbl_burend;
        private System.Windows.Forms.Label Lbl_total_calories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_total_goals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date_to;
        private System.Windows.Forms.Button Btn_filter;
        private System.Windows.Forms.PictureBox Btn_back;
        private System.Windows.Forms.Label Lbl_day_msg;
        private System.Windows.Forms.DataGridView Grid_activity_histories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_burned;
    }
}