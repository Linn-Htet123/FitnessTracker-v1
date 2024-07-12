﻿namespace FitnessTracker.views
{
    partial class WalkingActivity
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
            this.Lbl_error_distance = new System.Windows.Forms.Label();
            this.Lbl_error_time = new System.Windows.Forms.Label();
            this.Lbl_error_steps = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_distance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_time_taken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_steps = new System.Windows.Forms.TextBox();
            this.Btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_error_distance
            // 
            this.Lbl_error_distance.AutoSize = true;
            this.Lbl_error_distance.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_distance.Location = new System.Drawing.Point(25, 312);
            this.Lbl_error_distance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_distance.Name = "Lbl_error_distance";
            this.Lbl_error_distance.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_distance.TabIndex = 69;
            // 
            // Lbl_error_time
            // 
            this.Lbl_error_time.AutoSize = true;
            this.Lbl_error_time.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_time.Location = new System.Drawing.Point(22, 229);
            this.Lbl_error_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_time.Name = "Lbl_error_time";
            this.Lbl_error_time.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_time.TabIndex = 68;
            // 
            // Lbl_error_steps
            // 
            this.Lbl_error_steps.AutoSize = true;
            this.Lbl_error_steps.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_steps.Location = new System.Drawing.Point(21, 147);
            this.Lbl_error_steps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_steps.Name = "Lbl_error_steps";
            this.Lbl_error_steps.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_steps.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(24, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 40);
            this.panel2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 65;
            this.label1.Text = "Walking";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(28, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "distance (km):";
            // 
            // Txt_distance
            // 
            this.Txt_distance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_distance.Location = new System.Drawing.Point(28, 281);
            this.Txt_distance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_distance.Name = "Txt_distance";
            this.Txt_distance.Size = new System.Drawing.Size(213, 28);
            this.Txt_distance.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(25, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Time taken (min):";
            // 
            // Txt_time_taken
            // 
            this.Txt_time_taken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_time_taken.Location = new System.Drawing.Point(24, 198);
            this.Txt_time_taken.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_time_taken.Name = "Txt_time_taken";
            this.Txt_time_taken.Size = new System.Drawing.Size(217, 28);
            this.Txt_time_taken.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Steps: ";
            // 
            // Txt_steps
            // 
            this.Txt_steps.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_steps.Location = new System.Drawing.Point(24, 117);
            this.Txt_steps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Txt_steps.Name = "Txt_steps";
            this.Txt_steps.Size = new System.Drawing.Size(217, 28);
            this.Txt_steps.TabIndex = 59;
            // 
            // Btn_submit
            // 
            this.Btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_submit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_submit.ForeColor = System.Drawing.Color.White;
            this.Btn_submit.Location = new System.Drawing.Point(28, 340);
            this.Btn_submit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Size = new System.Drawing.Size(211, 42);
            this.Btn_submit.TabIndex = 58;
            this.Btn_submit.Text = "Submit";
            this.Btn_submit.UseVisualStyleBackColor = false;
            this.Btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // WalkingActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 426);
            this.Controls.Add(this.Lbl_error_distance);
            this.Controls.Add(this.Lbl_error_time);
            this.Controls.Add(this.Lbl_error_steps);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_distance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_time_taken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_steps);
            this.Controls.Add(this.Btn_submit);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WalkingActivity";
            this.Text = "WalkingActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_error_distance;
        private System.Windows.Forms.Label Lbl_error_time;
        private System.Windows.Forms.Label Lbl_error_steps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_time_taken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_steps;
        private System.Windows.Forms.Button Btn_submit;
    }
}