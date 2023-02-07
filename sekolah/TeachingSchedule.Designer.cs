namespace sekolah
{
    partial class TeachingSchedule
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
            this.button2 = new System.Windows.Forms.Button();
            this.tblSchedule = new System.Windows.Forms.DataGridView();
            this.tblStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Subject";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tblSchedule
            // 
            this.tblSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSchedule.Location = new System.Drawing.Point(12, 12);
            this.tblSchedule.Name = "tblSchedule";
            this.tblSchedule.Size = new System.Drawing.Size(560, 150);
            this.tblSchedule.TabIndex = 2;
            this.tblSchedule.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblSchedule_RowHeaderMouseClick);
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStudent.Location = new System.Drawing.Point(12, 170);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.Size = new System.Drawing.Size(560, 150);
            this.tblStudent.TabIndex = 3;
            // 
            // TeachingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tblStudent);
            this.Controls.Add(this.tblSchedule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TeachingSchedule";
            this.Text = "Teaching Schedule";
            this.Load += new System.EventHandler(this.TeachingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tblSchedule;
        private System.Windows.Forms.DataGridView tblStudent;
    }
}