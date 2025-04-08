namespace Session6
{
    partial class frmScore
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnShowScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Score";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(137, 43);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(220, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(49, 99);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create File";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Value";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.Location = new System.Drawing.Point(49, 149);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(183, 173);
            this.lstScore.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average Of Score";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(268, 289);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(89, 33);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowScore
            // 
            this.btnShowScore.Location = new System.Drawing.Point(268, 173);
            this.btnShowScore.Name = "btnShowScore";
            this.btnShowScore.Size = new System.Drawing.Size(89, 23);
            this.btnShowScore.TabIndex = 8;
            this.btnShowScore.Text = "Show Score";
            this.btnShowScore.UseVisualStyleBackColor = true;
            this.btnShowScore.Click += new System.EventHandler(this.btnShowScore_Click);
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.btnShowScore);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label1);
            this.Name = "frmScore";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.frmScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnShowScore;
    }
}