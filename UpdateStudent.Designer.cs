namespace StudentApp
{
    partial class UpdateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudent));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblStudentFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lblYear = new MaterialSkin.Controls.MaterialLabel();
            this.lblStudentTelephone = new MaterialSkin.Controls.MaterialLabel();
            this.lblStudentEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastName = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelephone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCardGrades = new MaterialSkin.Controls.MaterialCard();
            this.lblCourse6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCourse5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCourse4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCourse3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxGrade6 = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxGrade5 = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxGrade4 = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxGrade3 = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxGrade2 = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxGrade1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblCourse2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblGradesTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblCourse1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdateStudent = new MaterialSkin.Controls.MaterialButton();
            this.errorProviderUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUpdateMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeleteStudent = new MaterialSkin.Controls.MaterialButton();
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.materialCardGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblStudentFirstName);
            this.materialCard1.Controls.Add(this.lblYear);
            this.materialCard1.Controls.Add(this.lblStudentTelephone);
            this.materialCard1.Controls.Add(this.lblStudentEmail);
            this.materialCard1.Controls.Add(this.lblLastName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(154, 167);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(161, 289);
            this.materialCard1.TabIndex = 7;
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Depth = 0;
            this.lblStudentFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudentFirstName.Location = new System.Drawing.Point(39, 22);
            this.lblStudentFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(78, 19);
            this.lblStudentFirstName.TabIndex = 0;
            this.lblStudentFirstName.Text = "FirstName:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Depth = 0;
            this.lblYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblYear.Location = new System.Drawing.Point(39, 246);
            this.lblYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(82, 19);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Study Year:";
            // 
            // lblStudentTelephone
            // 
            this.lblStudentTelephone.AutoSize = true;
            this.lblStudentTelephone.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentTelephone.Depth = 0;
            this.lblStudentTelephone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudentTelephone.Location = new System.Drawing.Point(39, 190);
            this.lblStudentTelephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudentTelephone.Name = "lblStudentTelephone";
            this.lblStudentTelephone.Size = new System.Drawing.Size(79, 19);
            this.lblStudentTelephone.TabIndex = 0;
            this.lblStudentTelephone.Text = "Telephone:";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Depth = 0;
            this.lblStudentEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStudentEmail.Location = new System.Drawing.Point(39, 134);
            this.lblStudentEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(45, 19);
            this.lblStudentEmail.TabIndex = 0;
            this.lblStudentEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Depth = 0;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastName.Location = new System.Drawing.Point(39, 78);
            this.lblLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 19);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "LastName:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.AnimateReadOnly = false;
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Depth = 0;
            this.txtTelephone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelephone.LeadingIcon = null;
            this.txtTelephone.Location = new System.Drawing.Point(332, 347);
            this.txtTelephone.MaxLength = 50;
            this.txtTelephone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelephone.Multiline = false;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(210, 50);
            this.txtTelephone.TabIndex = 3;
            this.txtTelephone.Text = "";
            this.txtTelephone.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(332, 287);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 50);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.AnimateReadOnly = false;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.LeadingIcon = null;
            this.txtLastName.Location = new System.Drawing.Point(332, 227);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 50);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Text = "";
            this.txtLastName.TrailingIcon = null;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // txtFirstName
            // 
            this.txtFirstName.AnimateReadOnly = false;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.LeadingIcon = null;
            this.txtFirstName.Location = new System.Drawing.Point(332, 167);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 50);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "";
            this.txtFirstName.TrailingIcon = null;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // materialCardGrades
            // 
            this.materialCardGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardGrades.Controls.Add(this.lblCourse6);
            this.materialCardGrades.Controls.Add(this.lblCourse5);
            this.materialCardGrades.Controls.Add(this.lblCourse4);
            this.materialCardGrades.Controls.Add(this.lblCourse3);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade6);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade5);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade4);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade3);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade2);
            this.materialCardGrades.Controls.Add(this.comboBoxGrade1);
            this.materialCardGrades.Controls.Add(this.lblCourse2);
            this.materialCardGrades.Controls.Add(this.lblGradesTitle);
            this.materialCardGrades.Controls.Add(this.lblCourse1);
            this.materialCardGrades.Depth = 0;
            this.materialCardGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardGrades.Location = new System.Drawing.Point(617, 167);
            this.materialCardGrades.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardGrades.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardGrades.Name = "materialCardGrades";
            this.materialCardGrades.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardGrades.Size = new System.Drawing.Size(664, 314);
            this.materialCardGrades.TabIndex = 8;
            // 
            // lblCourse6
            // 
            this.lblCourse6.AutoSize = true;
            this.lblCourse6.Depth = 0;
            this.lblCourse6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse6.Location = new System.Drawing.Point(383, 216);
            this.lblCourse6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse6.Name = "lblCourse6";
            this.lblCourse6.Size = new System.Drawing.Size(67, 19);
            this.lblCourse6.TabIndex = 0;
            this.lblCourse6.Text = "Course 6:";
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Depth = 0;
            this.lblCourse5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse5.Location = new System.Drawing.Point(383, 144);
            this.lblCourse5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(67, 19);
            this.lblCourse5.TabIndex = 0;
            this.lblCourse5.Text = "Course 5:";
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Depth = 0;
            this.lblCourse4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse4.Location = new System.Drawing.Point(36, 144);
            this.lblCourse4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(67, 19);
            this.lblCourse4.TabIndex = 0;
            this.lblCourse4.Text = "Course 4:";
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Depth = 0;
            this.lblCourse3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse3.Location = new System.Drawing.Point(36, 216);
            this.lblCourse3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(67, 19);
            this.lblCourse3.TabIndex = 0;
            this.lblCourse3.Text = "Course 3:";
            // 
            // comboBoxGrade6
            // 
            this.comboBoxGrade6.AutoResize = false;
            this.comboBoxGrade6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade6.Depth = 0;
            this.comboBoxGrade6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade6.DropDownHeight = 174;
            this.comboBoxGrade6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade6.DropDownWidth = 121;
            this.comboBoxGrade6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade6.FormattingEnabled = true;
            this.comboBoxGrade6.IntegralHeight = false;
            this.comboBoxGrade6.ItemHeight = 43;
            this.comboBoxGrade6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade6.Location = new System.Drawing.Point(528, 201);
            this.comboBoxGrade6.MaxDropDownItems = 4;
            this.comboBoxGrade6.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade6.Name = "comboBoxGrade6";
            this.comboBoxGrade6.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade6.StartIndex = 0;
            this.comboBoxGrade6.TabIndex = 6;
            // 
            // comboBoxGrade5
            // 
            this.comboBoxGrade5.AutoResize = false;
            this.comboBoxGrade5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade5.Depth = 0;
            this.comboBoxGrade5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade5.DropDownHeight = 174;
            this.comboBoxGrade5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade5.DropDownWidth = 121;
            this.comboBoxGrade5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade5.FormattingEnabled = true;
            this.comboBoxGrade5.IntegralHeight = false;
            this.comboBoxGrade5.ItemHeight = 43;
            this.comboBoxGrade5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade5.Location = new System.Drawing.Point(528, 129);
            this.comboBoxGrade5.MaxDropDownItems = 4;
            this.comboBoxGrade5.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade5.Name = "comboBoxGrade5";
            this.comboBoxGrade5.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade5.StartIndex = 0;
            this.comboBoxGrade5.TabIndex = 6;
            // 
            // comboBoxGrade4
            // 
            this.comboBoxGrade4.AutoResize = false;
            this.comboBoxGrade4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade4.Depth = 0;
            this.comboBoxGrade4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade4.DropDownHeight = 174;
            this.comboBoxGrade4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade4.DropDownWidth = 121;
            this.comboBoxGrade4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade4.FormattingEnabled = true;
            this.comboBoxGrade4.IntegralHeight = false;
            this.comboBoxGrade4.ItemHeight = 43;
            this.comboBoxGrade4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade4.Location = new System.Drawing.Point(181, 129);
            this.comboBoxGrade4.MaxDropDownItems = 4;
            this.comboBoxGrade4.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade4.Name = "comboBoxGrade4";
            this.comboBoxGrade4.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade4.StartIndex = 0;
            this.comboBoxGrade4.TabIndex = 6;
            // 
            // comboBoxGrade3
            // 
            this.comboBoxGrade3.AutoResize = false;
            this.comboBoxGrade3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade3.Depth = 0;
            this.comboBoxGrade3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade3.DropDownHeight = 174;
            this.comboBoxGrade3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade3.DropDownWidth = 121;
            this.comboBoxGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade3.FormattingEnabled = true;
            this.comboBoxGrade3.IntegralHeight = false;
            this.comboBoxGrade3.ItemHeight = 43;
            this.comboBoxGrade3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade3.Location = new System.Drawing.Point(181, 201);
            this.comboBoxGrade3.MaxDropDownItems = 4;
            this.comboBoxGrade3.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade3.Name = "comboBoxGrade3";
            this.comboBoxGrade3.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade3.StartIndex = 0;
            this.comboBoxGrade3.TabIndex = 6;
            // 
            // comboBoxGrade2
            // 
            this.comboBoxGrade2.AutoResize = false;
            this.comboBoxGrade2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade2.Depth = 0;
            this.comboBoxGrade2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade2.DropDownHeight = 174;
            this.comboBoxGrade2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade2.DropDownWidth = 121;
            this.comboBoxGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade2.FormattingEnabled = true;
            this.comboBoxGrade2.IntegralHeight = false;
            this.comboBoxGrade2.ItemHeight = 43;
            this.comboBoxGrade2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade2.Location = new System.Drawing.Point(528, 63);
            this.comboBoxGrade2.MaxDropDownItems = 4;
            this.comboBoxGrade2.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade2.Name = "comboBoxGrade2";
            this.comboBoxGrade2.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade2.StartIndex = 0;
            this.comboBoxGrade2.TabIndex = 6;
            // 
            // comboBoxGrade1
            // 
            this.comboBoxGrade1.AutoResize = false;
            this.comboBoxGrade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxGrade1.Depth = 0;
            this.comboBoxGrade1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxGrade1.DropDownHeight = 174;
            this.comboBoxGrade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade1.DropDownWidth = 121;
            this.comboBoxGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxGrade1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxGrade1.FormattingEnabled = true;
            this.comboBoxGrade1.IntegralHeight = false;
            this.comboBoxGrade1.ItemHeight = 43;
            this.comboBoxGrade1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxGrade1.Location = new System.Drawing.Point(181, 63);
            this.comboBoxGrade1.MaxDropDownItems = 4;
            this.comboBoxGrade1.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxGrade1.Name = "comboBoxGrade1";
            this.comboBoxGrade1.Size = new System.Drawing.Size(77, 49);
            this.comboBoxGrade1.StartIndex = 0;
            this.comboBoxGrade1.TabIndex = 6;
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Depth = 0;
            this.lblCourse2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse2.Location = new System.Drawing.Point(383, 78);
            this.lblCourse2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(67, 19);
            this.lblCourse2.TabIndex = 0;
            this.lblCourse2.Text = "Course 2:";
            // 
            // lblGradesTitle
            // 
            this.lblGradesTitle.AutoSize = true;
            this.lblGradesTitle.Depth = 0;
            this.lblGradesTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblGradesTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblGradesTitle.Location = new System.Drawing.Point(253, 0);
            this.lblGradesTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGradesTitle.Name = "lblGradesTitle";
            this.lblGradesTitle.Size = new System.Drawing.Size(219, 24);
            this.lblGradesTitle.TabIndex = 0;
            this.lblGradesTitle.Text = "Update Students Grades";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Depth = 0;
            this.lblCourse1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCourse1.Location = new System.Drawing.Point(36, 78);
            this.lblCourse1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(67, 19);
            this.lblCourse1.TabIndex = 0;
            this.lblCourse1.Text = "Course 1:";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnUpdateStudent.Depth = 0;
            this.btnUpdateStudent.HighEmphasis = true;
            this.btnUpdateStudent.Icon = null;
            this.btnUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateStudent.Location = new System.Drawing.Point(595, 552);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdateStudent.Padding = new System.Windows.Forms.Padding(10);
            this.btnUpdateStudent.Size = new System.Drawing.Size(146, 36);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "UPDATE STUDENT";
            this.btnUpdateStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdateStudent.UseAccentColor = false;
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // errorProviderUpdate
            // 
            this.errorProviderUpdate.ContainerControl = this;
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoSize = true;
            this.lblUpdateMessage.Depth = 0;
            this.lblUpdateMessage.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpdateMessage.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblUpdateMessage.Location = new System.Drawing.Point(580, 616);
            this.lblUpdateMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Size = new System.Drawing.Size(1, 0);
            this.lblUpdateMessage.TabIndex = 10;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteStudent.Depth = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStudent.HighEmphasis = true;
            this.btnDeleteStudent.Icon = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.Icon")));
            this.btnDeleteStudent.Location = new System.Drawing.Point(1111, 111);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteStudent.Size = new System.Drawing.Size(170, 36);
            this.btnDeleteStudent.TabIndex = 11;
            this.btnDeleteStudent.Text = "DELETE STUDENT";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteStudent.UseAccentColor = true;
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblMessage.Location = new System.Drawing.Point(580, 647);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1, 0);
            this.lblMessage.TabIndex = 10;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 846);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.materialCardGrades);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "UpdateStudent";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateStudent";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCardGrades.ResumeLayout(false);
            this.materialCardGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblStudentFirstName;
        private MaterialSkin.Controls.MaterialLabel lblYear;
        private MaterialSkin.Controls.MaterialLabel lblStudentTelephone;
        private MaterialSkin.Controls.MaterialLabel lblStudentEmail;
        private MaterialSkin.Controls.MaterialLabel lblLastName;
        private MaterialSkin.Controls.MaterialTextBox txtTelephone;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtLastName;
        private MaterialSkin.Controls.MaterialTextBox txtFirstName;
        private MaterialSkin.Controls.MaterialCard materialCardGrades;
        private MaterialSkin.Controls.MaterialLabel lblCourse6;
        private MaterialSkin.Controls.MaterialLabel lblCourse5;
        private MaterialSkin.Controls.MaterialLabel lblCourse4;
        private MaterialSkin.Controls.MaterialLabel lblCourse3;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade6;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade5;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade4;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade3;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade2;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGrade1;
        private MaterialSkin.Controls.MaterialLabel lblCourse2;
        private MaterialSkin.Controls.MaterialLabel lblGradesTitle;
        private MaterialSkin.Controls.MaterialLabel lblCourse1;
        private MaterialSkin.Controls.MaterialButton btnUpdateStudent;
        private System.Windows.Forms.ErrorProvider errorProviderUpdate;
        private MaterialSkin.Controls.MaterialLabel lblUpdateMessage;
        private MaterialSkin.Controls.MaterialButton btnDeleteStudent;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
    }
}