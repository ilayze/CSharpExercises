namespace ex2LecturersStaff
{
    partial class Schedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DG = new System.Windows.Forms.DataGridView();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednsday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Location = new System.Drawing.Point(157, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(492, 22);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(365, 25);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(276, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(161, 28);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFirstName.Location = new System.Drawing.Point(80, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DG);
            this.panel2.Location = new System.Drawing.Point(5, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 331);
            this.panel2.TabIndex = 1;
            // 
            // DG
            // 
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hours,
            this.sunday,
            this.monday,
            this.tuesday,
            this.wednsday,
            this.thursday});
            this.DG.Location = new System.Drawing.Point(3, 3);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(743, 312);
            this.DG.TabIndex = 0;
            this.DG.Visible = false;
            // 
            // hours
            // 
            this.hours.HeaderText = "";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            // 
            // sunday
            // 
            this.sunday.HeaderText = "Sunday";
            this.sunday.Name = "sunday";
            this.sunday.ReadOnly = true;
            this.sunday.Width = 120;
            // 
            // monday
            // 
            this.monday.HeaderText = "Monday";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.Width = 120;
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Tuesday";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.Width = 120;
            // 
            // wednsday
            // 
            this.wednsday.HeaderText = "Wednsday";
            this.wednsday.Name = "wednsday";
            this.wednsday.ReadOnly = true;
            this.wednsday.Width = 120;
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Thursday";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            this.thursday.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblHeader);
            this.panel3.Location = new System.Drawing.Point(157, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 78);
            this.panel3.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Miriam", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Location = new System.Drawing.Point(128, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Location = new System.Drawing.Point(5, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 62);
            this.panel4.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 16);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Schedule";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ex2LecturersStaff.Properties.Resources.schedule1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(790, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Schedule_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}