namespace Session6
{
    partial class frmWriteToFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(56, 98);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(95, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(170, 98);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(102, 23);
            this.btnAppend.TabIndex = 4;
            this.btnAppend.Text = "Append File";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(56, 156);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(346, 160);
            this.lstName.TabIndex = 5;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(170, 340);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(102, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmWriteToFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmWriteToFile";
            this.Text = "Write To File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btnRead;
    }
}

