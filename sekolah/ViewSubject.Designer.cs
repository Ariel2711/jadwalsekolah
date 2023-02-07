namespace sekolah
{
    partial class ViewSubject
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelassign = new System.Windows.Forms.Label();
            this.labelmid = new System.Windows.Forms.Label();
            this.labelfinal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(233, 31);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(121, 20);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Subject Name";
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Location = new System.Drawing.Point(234, 83);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(67, 13);
            this.labeldesc.TabIndex = 2;
            this.labeldesc.Text = "subject desc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignement :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mid Exam :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Final Exam :";
            // 
            // labelassign
            // 
            this.labelassign.AutoSize = true;
            this.labelassign.Location = new System.Drawing.Point(180, 154);
            this.labelassign.Name = "labelassign";
            this.labelassign.Size = new System.Drawing.Size(37, 13);
            this.labelassign.TabIndex = 6;
            this.labelassign.Text = "assign";
            // 
            // labelmid
            // 
            this.labelmid.AutoSize = true;
            this.labelmid.Location = new System.Drawing.Point(180, 199);
            this.labelmid.Name = "labelmid";
            this.labelmid.Size = new System.Drawing.Size(23, 13);
            this.labelmid.TabIndex = 7;
            this.labelmid.Text = "mid";
            // 
            // labelfinal
            // 
            this.labelfinal.AutoSize = true;
            this.labelfinal.Location = new System.Drawing.Point(180, 246);
            this.labelfinal.Name = "labelfinal";
            this.labelfinal.Size = new System.Drawing.Size(26, 13);
            this.labelfinal.TabIndex = 8;
            this.labelfinal.Text = "final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Composition Assesment";
            // 
            // ViewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelfinal);
            this.Controls.Add(this.labelmid);
            this.Controls.Add(this.labelassign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeldesc);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.button1);
            this.Name = "ViewSubject";
            this.Text = " View Subject";
            this.Load += new System.EventHandler(this.ViewSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelassign;
        private System.Windows.Forms.Label labelmid;
        private System.Windows.Forms.Label labelfinal;
        private System.Windows.Forms.Label label9;
    }
}