namespace sekolah
{
    partial class FormClass
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
            this.cbSchedule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblStudent = new System.Windows.Forms.DataGridView();
            this.tblSchedule = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSchedule
            // 
            this.cbSchedule.FormattingEnabled = true;
            this.cbSchedule.Location = new System.Drawing.Point(15, 42);
            this.cbSchedule.Name = "cbSchedule";
            this.cbSchedule.Size = new System.Drawing.Size(121, 21);
            this.cbSchedule.TabIndex = 1;
            this.cbSchedule.SelectedIndexChanged += new System.EventHandler(this.cbSchedule_SelectedIndexChanged);
            this.cbSchedule.SelectionChangeCommitted += new System.EventHandler(this.cbSchedule_SelectionChangeCommitted);
            this.cbSchedule.MouseCaptureChanged += new System.EventHandler(this.cbSchedule_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Shedule";
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStudent.Location = new System.Drawing.Point(15, 102);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.Size = new System.Drawing.Size(224, 202);
            this.tblStudent.TabIndex = 3;
            this.tblStudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblStudent_RowHeaderMouseClick);
            // 
            // tblSchedule
            // 
            this.tblSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSchedule.Location = new System.Drawing.Point(326, 102);
            this.tblSchedule.Name = "tblSchedule";
            this.tblSchedule.Size = new System.Drawing.Size(220, 202);
            this.tblSchedule.TabIndex = 4;
            this.tblSchedule.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblSchedule_RowHeaderMouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ">>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "<<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tblSchedule);
            this.Controls.Add(this.tblStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSchedule);
            this.Controls.Add(this.button1);
            this.Name = "FormClass";
            this.Text = "Form Class";
            this.Load += new System.EventHandler(this.FormClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblStudent;
        private System.Windows.Forms.DataGridView tblSchedule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}