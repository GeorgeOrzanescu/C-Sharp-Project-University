namespace StudentApp
{
    partial class UCStudyYearFormat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblStudyYear = new MaterialSkin.Controls.MaterialLabel();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblStudentsEnrolled = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.mtbCreditsYear = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbStudentsYear = new MaterialSkin.Controls.MaterialTextBox();
            this.richTextBoxCoursesYear = new System.Windows.Forms.RichTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.richTextBoxCoursesYear);
            this.materialCard1.Controls.Add(this.mtbStudentsYear);
            this.materialCard1.Controls.Add(this.lblStudyYear);
            this.materialCard1.Controls.Add(this.mtbCreditsYear);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.lbl1);
            this.materialCard1.Controls.Add(this.lblStudentsEnrolled);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(310, 619);
            this.materialCard1.TabIndex = 0;
            // 
            // lblStudyYear
            // 
            this.lblStudyYear.AutoSize = true;
            this.lblStudyYear.Depth = 0;
            this.lblStudyYear.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudyYear.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblStudyYear.Location = new System.Drawing.Point(74, 14);
            this.lblStudyYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudyYear.Name = "lblStudyYear";
            this.lblStudyYear.Size = new System.Drawing.Size(163, 41);
            this.lblStudyYear.TabIndex = 0;
            this.lblStudyYear.Text = "Study Year";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl1.Location = new System.Drawing.Point(27, 175);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(243, 19);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Number of Credit Points Available:";
            // 
            // lblStudentsEnrolled
            // 
            this.lblStudentsEnrolled.AutoSize = true;
            this.lblStudentsEnrolled.Depth = 0;
            this.lblStudentsEnrolled.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudentsEnrolled.Location = new System.Drawing.Point(30, 270);
            this.lblStudentsEnrolled.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudentsEnrolled.Name = "lblStudentsEnrolled";
            this.lblStudentsEnrolled.Size = new System.Drawing.Size(128, 19);
            this.lblStudentsEnrolled.TabIndex = 3;
            this.lblStudentsEnrolled.Text = "Students enrolled:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(30, 315);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(62, 19);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Courses:";
            // 
            // mtbCreditsYear
            // 
            this.mtbCreditsYear.AnimateReadOnly = false;
            this.mtbCreditsYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbCreditsYear.Depth = 0;
            this.mtbCreditsYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCreditsYear.LeadingIcon = null;
            this.mtbCreditsYear.Location = new System.Drawing.Point(30, 197);
            this.mtbCreditsYear.MaxLength = 50;
            this.mtbCreditsYear.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbCreditsYear.Multiline = false;
            this.mtbCreditsYear.Name = "mtbCreditsYear";
            this.mtbCreditsYear.ReadOnly = true;
            this.mtbCreditsYear.Size = new System.Drawing.Size(89, 50);
            this.mtbCreditsYear.TabIndex = 4;
            this.mtbCreditsYear.Text = "";
            this.mtbCreditsYear.TrailingIcon = null;
            // 
            // mtbStudentsYear
            // 
            this.mtbStudentsYear.AnimateReadOnly = false;
            this.mtbStudentsYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbStudentsYear.Depth = 0;
            this.mtbStudentsYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbStudentsYear.LeadingIcon = null;
            this.mtbStudentsYear.Location = new System.Drawing.Point(166, 254);
            this.mtbStudentsYear.MaxLength = 50;
            this.mtbStudentsYear.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbStudentsYear.Multiline = false;
            this.mtbStudentsYear.Name = "mtbStudentsYear";
            this.mtbStudentsYear.ReadOnly = true;
            this.mtbStudentsYear.Size = new System.Drawing.Size(89, 50);
            this.mtbStudentsYear.TabIndex = 4;
            this.mtbStudentsYear.Text = "";
            this.mtbStudentsYear.TrailingIcon = null;
            // 
            // richTextBoxCoursesYear
            // 
            this.richTextBoxCoursesYear.Location = new System.Drawing.Point(33, 351);
            this.richTextBoxCoursesYear.Name = "richTextBoxCoursesYear";
            this.richTextBoxCoursesYear.Size = new System.Drawing.Size(222, 203);
            this.richTextBoxCoursesYear.TabIndex = 1;
            this.richTextBoxCoursesYear.Text = "";
            // 
            // UCStudyYearFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "UCStudyYearFormat";
            this.Size = new System.Drawing.Size(310, 619);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblStudyYear;
        private System.Windows.Forms.RichTextBox richTextBoxCoursesYear;
        private MaterialSkin.Controls.MaterialTextBox mtbStudentsYear;
        private MaterialSkin.Controls.MaterialTextBox mtbCreditsYear;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialLabel lblStudentsEnrolled;
    }
}
