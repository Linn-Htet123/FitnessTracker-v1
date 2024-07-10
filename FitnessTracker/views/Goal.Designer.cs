namespace FitnessTracker.views
{
    partial class Goal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_error_goal = new System.Windows.Forms.Label();
            this.Btn_goal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_goal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Lbl_error_goal);
            this.panel1.Controls.Add(this.Btn_goal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_goal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 220);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_error_goal
            // 
            this.Lbl_error_goal.AutoSize = true;
            this.Lbl_error_goal.ForeColor = System.Drawing.Color.Red;
            this.Lbl_error_goal.Location = new System.Drawing.Point(22, 141);
            this.Lbl_error_goal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_error_goal.Name = "Lbl_error_goal";
            this.Lbl_error_goal.Size = new System.Drawing.Size(0, 16);
            this.Lbl_error_goal.TabIndex = 8;
            // 
            // Btn_goal
            // 
            this.Btn_goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_goal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_goal.ForeColor = System.Drawing.Color.White;
            this.Btn_goal.Location = new System.Drawing.Point(20, 163);
            this.Btn_goal.Name = "Btn_goal";
            this.Btn_goal.Size = new System.Drawing.Size(345, 44);
            this.Btn_goal.TabIndex = 4;
            this.Btn_goal.Text = "Submit";
            this.Btn_goal.UseVisualStyleBackColor = false;
            this.Btn_goal.Click += new System.EventHandler(this.Btn_goal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calorie Burn Goal";
            // 
            // Txt_goal
            // 
            this.Txt_goal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_goal.Location = new System.Drawing.Point(20, 111);
            this.Txt_goal.Name = "Txt_goal";
            this.Txt_goal.Size = new System.Drawing.Size(345, 27);
            this.Txt_goal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the number of calories you want to burn each day.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Calorie Burn Goal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Btn_back);
            this.panel2.Location = new System.Drawing.Point(-3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 126);
            this.panel2.TabIndex = 1;
            // 
            // Btn_back
            // 
            this.Btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_back.Image = ((System.Drawing.Image)(resources.GetObject("Btn_back.Image")));
            this.Btn_back.Location = new System.Drawing.Point(35, 19);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(17, 19);
            this.Btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_back.TabIndex = 10;
            this.Btn_back.TabStop = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(436, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Goal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_goal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_goal;
        private System.Windows.Forms.Label Lbl_error_goal;
        private System.Windows.Forms.PictureBox Btn_back;
    }
}