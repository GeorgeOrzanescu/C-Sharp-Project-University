using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class UpdateStudent : MaterialForm
    {
        private long idStudent;
        public UpdateStudent(DataGridViewRow studentInfo)
        {
            InitializeComponent();
            populateStudentData(studentInfo);     
        }
        private void populateStudentData(DataGridViewRow data)
        {
            idStudent = (long)data.Cells["Id"].Value;
            long year = (long)data.Cells["studyYear"].Value;
            txtFirstName.Text = (string)data.Cells["firstName"].Value;
            txtLastName.Text = (string)data.Cells["lastName"].Value;
            txtEmail.Text = (string)data.Cells["email"].Value;
            txtTelephone.Text = (string)data.Cells["telephone"].Value;
            lblYear.Text += year.ToString();
            switch (year)
            {
                case 1:
                    lblCourse1.Text = MainMenu.courseListYearOne[0].Name;
                    lblCourse2.Text = MainMenu.courseListYearOne[1].Name;
                    lblCourse3.Text = MainMenu.courseListYearOne[2].Name;
                    lblCourse4.Text = MainMenu.courseListYearOne[3].Name;
                    lblCourse5.Text = MainMenu.courseListYearOne[4].Name;
                    lblCourse6.Text = MainMenu.courseListYearOne[5].Name;
                    comboBoxGrade1.SelectedIndex = (int)(long)data.Cells[6].Value;
                    comboBoxGrade2.SelectedIndex = (int)(long)data.Cells[7].Value;
                    comboBoxGrade3.SelectedIndex = (int)(long)data.Cells[8].Value;
                    comboBoxGrade4.SelectedIndex = (int)(long)data.Cells[9].Value;
                    comboBoxGrade5.SelectedIndex = (int)(long)data.Cells[10].Value;
                    comboBoxGrade6.SelectedIndex = (int)(long)data.Cells[11].Value;
                    break;
                case 2:
                    lblCourse1.Text = MainMenu.courseListYearTwo[0].Name;
                    lblCourse2.Text = MainMenu.courseListYearTwo[1].Name;
                    lblCourse3.Text = MainMenu.courseListYearTwo[2].Name;
                    lblCourse4.Text = MainMenu.courseListYearTwo[3].Name;
                    lblCourse5.Text = MainMenu.courseListYearTwo[4].Name;
                    lblCourse6.Text = MainMenu.courseListYearTwo[5].Name;
                    comboBoxGrade1.SelectedIndex = (int)(long)data.Cells[6].Value;
                    comboBoxGrade2.SelectedIndex = (int)(long)data.Cells[7].Value;
                    comboBoxGrade3.SelectedIndex = (int)(long)data.Cells[8].Value;
                    comboBoxGrade4.SelectedIndex = (int)(long)data.Cells[9].Value;
                    comboBoxGrade5.SelectedIndex = (int)(long)data.Cells[10].Value;
                    comboBoxGrade6.SelectedIndex = (int)(long)data.Cells[11].Value;
                    break;
                case 3:
                    lblCourse1.Text = MainMenu.courseListYearThree[0].Name;
                    lblCourse2.Text = MainMenu.courseListYearThree[1].Name;
                    lblCourse3.Text = MainMenu.courseListYearThree[2].Name;
                    lblCourse4.Text = MainMenu.courseListYearThree[3].Name;
                    lblCourse5.Text = MainMenu.courseListYearThree[4].Name;
                    lblCourse6.Text = MainMenu.courseListYearThree[5].Name;
                    comboBoxGrade1.SelectedIndex = (int)(long)data.Cells[6].Value;
                    comboBoxGrade2.SelectedIndex = (int)(long)data.Cells[7].Value;
                    comboBoxGrade3.SelectedIndex = (int)(long)data.Cells[8].Value;
                    comboBoxGrade4.SelectedIndex = (int)(long)data.Cells[9].Value;
                    comboBoxGrade5.SelectedIndex = (int)(long)data.Cells[10].Value;
                    comboBoxGrade6.SelectedIndex = (int)(long)data.Cells[11].Value;
                    break;
            }
        }
        #region Validation
        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtFirstName.Text.Length < 3 || txtFirstName.Text.Trim().Length == 0)
            {
                errorProviderUpdate.SetError(txtFirstName, "Name is too short or left empty!");
                e.Cancel = true;
            }
        }
        private void txtFirstName_Validated(object sender, System.EventArgs e)
        {
            errorProviderUpdate.SetError(txtFirstName, null);
        }
        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtLastName.Text.Length < 3 || txtLastName.Text.Trim().Length == 0)
            {
                errorProviderUpdate.SetError(txtLastName, "Name is too short or left empty!");
                e.Cancel = true;
            }
        }
        private void txtLastName_Validated(object sender, System.EventArgs e)
        {
            errorProviderUpdate.SetError(txtLastName, null);
        }
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Length < 5 || string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProviderUpdate.SetError(txtEmail, "Name must have atleast 5 characthers and not be empty!");
            }
            else if (!txtEmail.Text.Trim().Contains("@"))
            {
                e.Cancel = true;
                errorProviderUpdate.SetError(txtEmail, "Not a valid email adress");
            }
            else
            {
                e.Cancel = false;
                errorProviderUpdate.SetError(txtEmail, null);

            }
        }


        #endregion Validation

        #region UpdateDeleteStudent
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The data you entered contains errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateStudentData();

            }
        }
        private void UpdateStudentData()
        {
            const string query = "UPDATE Student SET firstName = @firstName, lastName = @lastName,email = @email,telephone = @telephone," +
                "course1 = @course1,course2 = @course2,course3 = @course3,course4 = @course4,course5 = @course5,course6 = @course6 WHERE Id = @Id;";
            using (SQLiteConnection connection = new SQLiteConnection(MainMenu.connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("Id",idStudent);
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                command.Parameters.AddWithValue("@course1", long.Parse(comboBoxGrade1.Text));
                command.Parameters.AddWithValue("@course2", long.Parse(comboBoxGrade2.Text)); 
                command.Parameters.AddWithValue("@course3", long.Parse(comboBoxGrade3.Text));
                command.Parameters.AddWithValue("@course4", long.Parse(comboBoxGrade4.Text));
                command.Parameters.AddWithValue("@course5", long.Parse(comboBoxGrade5.Text));
                command.Parameters.AddWithValue("@course6", long.Parse(comboBoxGrade6.Text)); 

                connection.Open();
                // ExecuteNonQuery for query which does not return data  // ExecuteReader use it when it returns multiple values  // ExecuteScalar when one value is returned
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    lblUpdateMessage.Text = "Update Succesfull!";
                    lblMessage.Text = "You can close this window and refresh the student's page!";
                    clearFields();
                }
                else
                {
                    lblUpdateMessage.Text = "Update student fail!";
                    
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are sure you want to delete this Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                const string query = "DELETE FROM Student WHERE Id = @Id;";
                using (SQLiteConnection connection = new SQLiteConnection(MainMenu.connectionString))
                {

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("Id", idStudent);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        lblUpdateMessage.Text = "Delete Succesfull!";
                        lblMessage.Text = "You can close this window and refresh the student's page!";
                        clearFields();
                        MainMenu.updateMinusRegisteredStudents(idStudent);
                    }
                    else
                    {
                        lblUpdateMessage.Text = "Delete student fail!";
                        
                    }

                }
                
            }
        }

        #endregion UpdateDeleteStudent
        public void clearFields()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtEmail.Text = null;
            txtTelephone.Text = null;
            comboBoxGrade1.Text = 0.ToString();
            comboBoxGrade2.Text = 0.ToString();
            comboBoxGrade3.Text = 0.ToString();
            comboBoxGrade4.Text = 0.ToString();
            comboBoxGrade5.Text = 0.ToString();
            comboBoxGrade6.Text = 0.ToString();
        }
    }
}
