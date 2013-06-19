namespace XML
{
    partial class Form1
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdLoadString = new System.Windows.Forms.Button();
            this.cmdCountries = new System.Windows.Forms.Button();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdXSL = new System.Windows.Forms.Button();
            this.cmdSerialize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtOutput.Location = new System.Drawing.Point(6, 258);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(353, 151);
            this.txtOutput.TabIndex = 0;
            // 
            // cmdLoadFile
            // 
            this.cmdLoadFile.Location = new System.Drawing.Point(12, 12);
            this.cmdLoadFile.Name = "cmdLoadFile";
            this.cmdLoadFile.Size = new System.Drawing.Size(90, 24);
            this.cmdLoadFile.TabIndex = 1;
            this.cmdLoadFile.Text = "Load XML File";
            this.cmdLoadFile.UseVisualStyleBackColor = true;
            this.cmdLoadFile.Click += new System.EventHandler(this.cmdLoadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdLoadString
            // 
            this.cmdLoadString.Location = new System.Drawing.Point(146, 11);
            this.cmdLoadString.Name = "cmdLoadString";
            this.cmdLoadString.Size = new System.Drawing.Size(90, 24);
            this.cmdLoadString.TabIndex = 2;
            this.cmdLoadString.Text = "Load XML String";
            this.cmdLoadString.UseVisualStyleBackColor = true;
            this.cmdLoadString.Click += new System.EventHandler(this.cmdLoadString_Click);
            // 
            // cmdCountries
            // 
            this.cmdCountries.Location = new System.Drawing.Point(263, 11);
            this.cmdCountries.Name = "cmdCountries";
            this.cmdCountries.Size = new System.Drawing.Size(81, 25);
            this.cmdCountries.TabIndex = 3;
            this.cmdCountries.Text = "Countries";
            this.cmdCountries.UseVisualStyleBackColor = true;
            this.cmdCountries.Click += new System.EventHandler(this.cmdCountries_Click);
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(45, 35);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(111, 21);
            this.cboFrom.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdConvert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFrom);
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(231, 38);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(77, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(45, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(77, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total:";
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(212, 81);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(96, 34);
            this.cmdConvert.TabIndex = 6;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // cmdXSL
            // 
            this.cmdXSL.Location = new System.Drawing.Point(12, 42);
            this.cmdXSL.Name = "cmdXSL";
            this.cmdXSL.Size = new System.Drawing.Size(90, 27);
            this.cmdXSL.TabIndex = 6;
            this.cmdXSL.Text = "XSL";
            this.cmdXSL.UseVisualStyleBackColor = true;
            this.cmdXSL.Click += new System.EventHandler(this.cmdXSL_Click);
            // 
            // cmdSerialize
            // 
            this.cmdSerialize.Location = new System.Drawing.Point(146, 42);
            this.cmdSerialize.Name = "cmdSerialize";
            this.cmdSerialize.Size = new System.Drawing.Size(90, 27);
            this.cmdSerialize.TabIndex = 7;
            this.cmdSerialize.Text = "Serialize";
            this.cmdSerialize.UseVisualStyleBackColor = true;
            this.cmdSerialize.Click += new System.EventHandler(this.cmdSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 421);
            this.Controls.Add(this.cmdSerialize);
            this.Controls.Add(this.cmdXSL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCountries);
            this.Controls.Add(this.cmdLoadString);
            this.Controls.Add(this.cmdLoadFile);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdLoadString;
        private System.Windows.Forms.Button cmdCountries;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdXSL;
        private System.Windows.Forms.Button cmdSerialize;
    }
}

