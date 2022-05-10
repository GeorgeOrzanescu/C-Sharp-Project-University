namespace StudentApp
{
    partial class WelcomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNume = new MaterialSkin.Controls.MaterialLabel();
            this.lblTema = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStartApp = new MaterialSkin.Controls.MaterialButton();
            this.toolStripDateTime = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelDate = new System.Windows.Forms.ToolStripLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabelHour = new System.Windows.Forms.ToolStripLabel();
            this.timerLoadingBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStripDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentApp.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(46, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Depth = 0;
            this.lblNume.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNume.Location = new System.Drawing.Point(104, 652);
            this.lblNume.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(193, 19);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Student: Orzanescu George";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Depth = 0;
            this.lblTema.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTema.Location = new System.Drawing.Point(104, 682);
            this.lblTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(138, 19);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema: 28 Facultate";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(104, 715);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(322, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Proiect: Sistem de management al studentilor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1480, 433);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnStartApp
            // 
            this.btnStartApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartApp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartApp.Depth = 0;
            this.btnStartApp.HighEmphasis = true;
            this.btnStartApp.Icon = null;
            this.btnStartApp.Location = new System.Drawing.Point(1062, 604);
            this.btnStartApp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartApp.Name = "btnStartApp";
            this.btnStartApp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartApp.Size = new System.Drawing.Size(173, 36);
            this.btnStartApp.TabIndex = 2;
            this.btnStartApp.Text = "&Start Application";
            this.btnStartApp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartApp.UseAccentColor = false;
            this.btnStartApp.UseVisualStyleBackColor = true;
            this.btnStartApp.Click += new System.EventHandler(this.btnStartApp_Click);
            // 
            // toolStripDateTime
            // 
            this.toolStripDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripDateTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelDate,
            this.ProgressBar,
            this.toolStripLabelHour});
            this.toolStripDateTime.Location = new System.Drawing.Point(3, 1013);
            this.toolStripDateTime.Name = "toolStripDateTime";
            this.toolStripDateTime.Size = new System.Drawing.Size(1472, 25);
            this.toolStripDateTime.TabIndex = 3;
            this.toolStripDateTime.Text = "toolStrip1";
            // 
            // toolStripLabelDate
            // 
            this.toolStripLabelDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelDate.Name = "toolStripLabelDate";
            this.toolStripLabelDate.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabelDate.Text = "Date:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1180, 22);
            // 
            // toolStripLabelHour
            // 
            this.toolStripLabelHour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelHour.Name = "toolStripLabelHour";
            this.toolStripLabelHour.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabelHour.Text = "Hour:";
            // 
            // timerLoadingBar
            // 
            this.timerLoadingBar.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1041);
            this.Controls.Add(this.toolStripDateTime);
            this.Controls.Add(this.btnStartApp);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeScreen";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student management application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStripDateTime.ResumeLayout(false);
            this.toolStripDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblNume;
        private MaterialSkin.Controls.MaterialLabel lblTema;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton btnStartApp;
        private System.Windows.Forms.ToolStrip toolStripDateTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabelHour;
        private System.Windows.Forms.Timer timerLoadingBar;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
    }
}

