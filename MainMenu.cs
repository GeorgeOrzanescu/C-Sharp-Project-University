
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using MaterialSkin;
using MaterialSkin.Controls;
using StudentApp.classes;
using StudentApp.ViewModel;

namespace StudentApp
{
    public partial class MainMenu : MaterialForm
    {
        #region CoursesYearly
        public static List<Course> courseListYearOne = new List<Course>{new Course("Algebra","John C.",4),new Course("Basic Statistics","Maria B.",5),new Course("Economy","George O.",4),
            new Course("Programming C#","Newman I.",6),new Course("English","Elaine C.",4),new Course("Operating Systems","Clio V.",6)};
        public static List<Course> courseListYearTwo = new List<Course>{new Course("Algorithms","Mack C.",5),new Course("Cybernetics","Rayven B.",5),new Course("Mathematics","Carol O.",4),
            new Course("Programming C","Valerie I.",6),new Course("Marketing","Vanis C.",4),new Course("Calculus","Richard V.",6)};
        public static List<Course> courseListYearThree = new List<Course>{new Course("Data Bases","Mike C.",5),new Course("Management","Morgan A.",6),new Course("Blockchain","Carol O.",5),
            new Course("Finance","Valerie I.",3),new Course("Ethics","Vanis C.",4),new Course("Probability","Hawking R.",6)};
        #endregion Coursesyearly
        private List<Student> students = new List<Student>();
        private List<StudyYear> studyYears = new List<StudyYear>();

        private readonly NoteFormViewModel noteViewModel;
        public MainMenu()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStripRefresh;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Blue900, Primary.LightBlue500, Accent.DeepOrange200, TextShade.WHITE);
            noteViewModel = new NoteFormViewModel();

            loadViewModel();
        }
        #region DataBinding_ViewModel

        private void loadViewModel()
        {
            dvgDbNotes.DataSource = loadNotes();
            dvgDbNotes.Columns[0].HeaderText = nameof(NoteFormViewModel.Noter);
            dvgDbNotes.Columns[1].HeaderText = nameof(NoteFormViewModel.NoteEntry);
            dvgDbNotes.Columns[2].HeaderText = nameof(NoteFormViewModel.NoteDate);
            dgvNotes.DataSource = noteViewModel.Notes;
            textBoxNoter.DataBindings.Add("Text", noteViewModel, nameof(NoteFormViewModel.Noter));
            textBoxNote.DataBindings.Add("Text", noteViewModel, nameof(NoteFormViewModel.NoteEntry));
            dateTimeNote.DataBindings.Add("Value", noteViewModel, nameof(NoteFormViewModel.NoteDate));
        }

        private void btnSubmitNote_Click(object sender, EventArgs e)
        {
            string noter = textBoxNoter.Text;
            string noteEntry = textBoxNote.Text;
            DateTime noteDate = dateTimeNote.Value;
            noteViewModel.AddNote();

            Note note = new Note(noter, noteEntry, noteDate);

            AddNote(note);
        }

        private void AddNote(Note note)
        {
            const string query = "INSERT INTO Note(noter,note,date) VALUES (@noter,@note,@date);";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@noter", note.Noter);
                command.Parameters.AddWithValue("@note", note.NoteEntry);
                command.Parameters.AddWithValue("@date", note.NoteDate);

                connection.Open();
                command.ExecuteNonQuery();
                dvgDbNotes.DataSource = loadNotes();
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are sure you want to delete this Note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                const string query = "DELETE FROM Note WHERE note = @note;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@note", noteSelected);
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            dvgDbNotes.DataSource = loadNotes();
        }
        private string noteSelected;
         private void dvgDbNotes_CellContentClick(object sender, DataGridViewCellEventArgs e) { 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgDbNotes.Rows[e.RowIndex];
                DialogResult res = MessageBox.Show("Do you wish to select this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    noteSelected = (string)row.Cells[1].Value;
                }
            }
        }
        private void btnRemoveNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a note please!");
                return;
            }
            if (MessageBox.Show("You are removing a note?", "Remove note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Note noteSelected = (Note)dgvNotes.SelectedRows[0].DataBoundItem;
                noteViewModel.RemoveNote(noteSelected);
            }
        }

        private DataTable loadNotes(){
            DataTable dbNotes = new DataTable();
            const string query = "SELECT * FROM Note;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                dbNotes.Load(reader);
            }
            return dbNotes;
        }

        #endregion DataBinding_ViewModel

        #region DatabaseConnection
        public const string connectionString = "Data Source=db.db";

        #endregion DatabaseConnection

        #region AddStudentTab

        #region Validation
        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtFirstName.Text.Length < 3 || txtFirstName.Text.Trim().Length == 0)
            {
                errorProvider.SetError(txtFirstName, "Name is too short or left empty!");
                e.Cancel = true;
            }
        }
        private void txtFirstName_Validated(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtFirstName, null);
        }
        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtLastName.Text.Length < 3 || txtLastName.Text.Trim().Length == 0)
            {
                errorProvider.SetError(txtLastName, "Name is too short or left empty!");
                e.Cancel = true;
            }
        }
        private void txtLastName_Validated(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtLastName, null);
        }
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmail.Text.Length < 5 || string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email must have atleast 5 characthers and be valid!");
            }
            else if (!txtEmail.Text.Trim().Contains("@"))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Not a valid email adress");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, null);

            }
        }

        private void textBoxNoter_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxNoter.Text.Length < 4 || textBoxNoter.Text.Trim().Length == 0)
            {
                errorProvider.SetError(textBoxNoter, "Name is too short or left empty!");
                e.Cancel = true;
            }
        }

        #endregion Validation

        #region HandleInput
        private void btnPreviewStudent_Click(object sender, EventArgs e)
        {
            bool addPreview = true;
            if (!ValidateChildren())
            {
                MessageBox.Show("The data you entered contains errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addPreview = false;
            }


            if (richTextBoxPreview.Text == "" && addPreview == true)
            {
                richTextBoxPreview.AppendText(lblLastName.Text.ToString() + " " + txtLastName.Text + "\n");
                richTextBoxPreview.AppendText(lblStudentFirstName.Text.ToString() + " " + txtFirstName.Text + "\n");
                richTextBoxPreview.AppendText(lblStudentEmail.Text.ToString() + " " + txtEmail.Text + "\n");
                richTextBoxPreview.AppendText(lblStudentTelephone.Text.ToString() + " " + txtTelephone.Text + "\n");
                richTextBoxPreview.AppendText(lblYear.Text.ToString() + " " + comboBoxYear.Text.ToString() + "\n");

                richTextBoxPreview.AppendText("Grades:\n");
                richTextBoxPreview.AppendText(lblCourse1.Text.ToString() + " " + comboBoxGrade1.Text + "\n");
                richTextBoxPreview.AppendText(lblCourse2.Text.ToString() + " " + comboBoxGrade2.Text + "\n");
                richTextBoxPreview.AppendText(lblCourse3.Text.ToString() + " " + comboBoxGrade3.Text + "\n");
                richTextBoxPreview.AppendText(lblCourse4.Text.ToString() + " " + comboBoxGrade4.Text + "\n");
                richTextBoxPreview.AppendText(lblCourse5.Text.ToString() + " " + comboBoxGrade5.Text + "\n");
                richTextBoxPreview.AppendText(lblCourse6.Text.ToString() + " " + comboBoxGrade6.Text + "\n");
            }
        }
        private void AddStudent(Student student)
        {
            const string query = "INSERT INTO Student(firstName,lastName,email,telephone,studyYear,course1,course2,course3,course4,course5,course6) " +
                "VALUES (@firstName,@lastName,@email,@telephone,@studyYear,@course1,@course2,@course3,@course4,@course5,@course6); SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", student.FirstName);
                command.Parameters.AddWithValue("@lastName", student.LastName);
                command.Parameters.AddWithValue("@email", student.Email);
                command.Parameters.AddWithValue("@telephone", student.Telephone);
                command.Parameters.AddWithValue("@studyYear", student.Year);
                command.Parameters.AddWithValue("@course1", student.grades[0]);
                command.Parameters.AddWithValue("@course2", student.grades[1]);
                command.Parameters.AddWithValue("@course3", student.grades[2]);
                command.Parameters.AddWithValue("@course4", student.grades[3]);
                command.Parameters.AddWithValue("@course5", student.grades[4]);
                command.Parameters.AddWithValue("@course6", student.grades[5]);

                connection.Open();
                // ExecuteNonQuery for query which does not return data  // ExecuteReader use it when it returns multiple values  // ExecuteScalar when one value is returned
                long id = (long)command.ExecuteScalar();
                student.Id = id;
                // We added him locally
                students.Add(student);
            }
        }
        private DataTable LoadStudents(int year)
        {
            DataTable students = new DataTable();
            const string query = "SELECT * FROM Student WHERE studyYear=@year";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@year", year.ToString());
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                students.Load(reader);
            }
            return students;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The data you entered contains errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string telephone = txtTelephone.Text;
                int studyYear = int.Parse(comboBoxYear.Text);

                var student = new Student(firstName, lastName, email, telephone, studyYear);
                student.modifyGrade(0, int.Parse(comboBoxGrade1.Text));
                student.modifyGrade(1, int.Parse(comboBoxGrade2.Text));
                student.modifyGrade(2, int.Parse(comboBoxGrade3.Text));
                student.modifyGrade(3, int.Parse(comboBoxGrade4.Text));
                student.modifyGrade(4, int.Parse(comboBoxGrade5.Text));
                student.modifyGrade(5, int.Parse(comboBoxGrade6.Text));
                AddStudent(student);
                updateAddRegisteredStudents(student); // update the number of students
            }
            clearFields();
        }

        #endregion HandleInput

        #endregion AddStudentTab

        #region StudyYearTab
        private void LoadStudyYears()
        {
            studyYears.Clear();
            const string query = "SELECT * FROM studyYear";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader[0];
                        long numberCredits = (long)reader[1];
                        long registeredStudents = (long)reader[2];

                        StudyYear year = new StudyYear(id, numberCredits, registeredStudents);
                        studyYears.Add(year);
                    }
                }
            }
        }
        private void setStudyYearData()
        {
            foreach (StudyYear year in studyYears)
            {
                switch (year.Year)
                {
                    case 1:
                        mtbCreditsYear1.Text = year.numberCredits.ToString();
                        mtbStudentsYear1.Text = year.registeredStudents.ToString();
                        if (richTextBoxCoursesYear1.Text == "")
                        {
                            foreach (Course course in courseListYearOne)
                            {
                                richTextBoxCoursesYear1.AppendText(course.Name + " - " + course.Teacher + "\n\n");
                            }
                        }
                        break;
                    case 2:
                        mtbCreditsYear2.Text = year.numberCredits.ToString();
                        mtbStudentsYear2.Text = year.registeredStudents.ToString();

                        if (richTextBoxCoursesYear2.Text == "")
                        {
                            foreach (Course course in courseListYearTwo)
                            {
                                richTextBoxCoursesYear2.AppendText(course.Name + " - " + course.Teacher + "\n\n");
                            }
                        }
                        break;
                    case 3:
                        mtbCreditsYear3.Text = year.numberCredits.ToString();
                        mtbStudentsYear3.Text = year.registeredStudents.ToString();

                        if (richTextBoxCoursesYear3.Text == "")
                        {
                            foreach (Course course in courseListYearThree)
                            {
                                richTextBoxCoursesYear3.AppendText(course.Name + " - " + course.Teacher + "\n\n");
                            }
                        }
                        break;
                }
            }
        }

        private void updateAddRegisteredStudents(Student student)
        {
            const string query = "UPDATE studyYear SET registeredStudents = registeredStudents + 1 WHERE Id = @Id;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("Id", student.Year);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void updateMinusRegisteredStudents(long idStudent)
        {
            const string query = "UPDATE studyYear SET registeredStudents = registeredStudents - 1 WHERE Id = @Id;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("Id", idStudent);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnUpdateStudyYearData_Click(object sender, EventArgs e)
        {
            LoadStudyYears();
            setStudyYearData();
        }
        #endregion StudyYearTab

        #region Serialization/Deserialization
        private void btnSerializationCourses_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Course>));
            try
            {
                using (FileStream stream = File.Create("coursesYear1.xml"))
                {
                    serializer.Serialize(stream, courseListYearOne);
                }
                using (FileStream stream = File.Create("coursesYear2.xml"))
                {
                    serializer.Serialize(stream, courseListYearTwo);
                }
                using (FileStream stream = File.Create("coursesYear3.xml"))
                {
                    serializer.Serialize(stream, courseListYearThree);
                }

                richTextBoxSerialization.AppendText("Serialization succesfull !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Serialization failed!", ex.Message);
            }
        }
        private void btnDeserializationCourses_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Course>));
            try
            {
                using (FileStream stream = File.OpenRead("coursesYear1.xml"))
                {
                    List<Course> courses1 = new List<Course>();
                    courses1 = (List<Course>)serializer.Deserialize(stream);
                    richTextBoxDeserialization.AppendText("Courses for Year 1:\n");
                    for (int i = 0; i < 6; i++)
                    {
                        richTextBoxDeserialization.AppendText(courses1[i].Name + " " + courses1[i].Teacher + " " + courses1[i].numCredits + "\n");
                    }
                }
                using (FileStream stream = File.OpenRead("coursesYear2.xml"))
                {
                    List<Course> courses2 = new List<Course>();
                    courses2 = (List<Course>)serializer.Deserialize(stream);
                    richTextBoxDeserialization.AppendText("Courses for Year 2:\n");

                    for (int i = 0; i < 6; i++)
                    {
                        richTextBoxDeserialization.AppendText(courses2[i].Name + " " + courses2[i].Teacher + " " + courses2[i].numCredits + "\n");
                    }
                }
                using (FileStream stream = File.OpenRead("coursesYear3.xml"))
                {
                    List<Course> courses3 = new List<Course>();
                    courses3 = (List<Course>)serializer.Deserialize(stream);
                    richTextBoxDeserialization.AppendText("Courses for Year 3:\n");

                    for (int i = 0; i < 6; i++)
                    {
                        richTextBoxDeserialization.AppendText(courses3[i].Name + " " + courses3[i].Teacher + " " + courses3[i].numCredits + "\n");
                    }
                }

                richTextBoxDeserialization.AppendText("\t\t\t\tDeserialization succesfull !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization failed!", ex.Message);
            }

        }
        #endregion Serialization/Deserialization

        #region PrintToTxt
        private void btnPrintTextInfo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text File | *.txt";
            dlg.Title = "Save as text file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(dlg.FileName))
                {
                    studentsToTxt(1, streamWriter);
                    studentsToTxt(2, streamWriter);
                    studentsToTxt(3, streamWriter);
                }
            }
        }
        private void btnPrintCoursesInfo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text File | *.txt";
            dlg.Title = "Save as text file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(dlg.FileName))
                {
                    coursesToTxt(streamWriter, 1);
                    coursesToTxt(streamWriter, 2);
                    coursesToTxt(streamWriter, 3);
                }
            }

        }
        #endregion PrintToTxt

        #region EditStudent
        private void dataGridViewYear1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewYear1.Rows[e.RowIndex];
                DialogResult res = MessageBox.Show("Do you wish to update this Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    UpdateStudent updateStudent = new UpdateStudent(row);
                    updateStudent.ShowDialog();
                }
            }
        }

        private void dataGridViewYear2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewYear2.Rows[e.RowIndex];
                DialogResult res = MessageBox.Show("Update or delete Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    UpdateStudent updateStudent = new UpdateStudent(row);
                    updateStudent.ShowDialog();
                }
            }

        }

        private void dataGridViewYear3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewYear3.Rows[e.RowIndex];
                DialogResult res = MessageBox.Show("Update or delete Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    UpdateStudent updateStudent = new UpdateStudent(row);
                    updateStudent.ShowDialog();
                }
            }
        }
        #endregion EditStudent
        private void MainMenu_Load(object sender, EventArgs e)
        {
            setDataGridViewAll();
            LoadStudyYears();
            setStudyYearData();
        }

        private void ToolStripRefreshButton_Click(object sender, EventArgs e)
        {
            setDataGridViewAll();
        }

        #region HelperFunctions
        private void setDataGridViewAll()
        {
            dataGridViewYear1.DataSource = LoadStudents(1);
            for (int i = 0; i < courseListYearOne.Count; i++)
            {
                dataGridViewYear1.Columns[i + 6].HeaderText = courseListYearOne[i].Name;
            }

            dataGridViewYear2.DataSource = LoadStudents(2);
            for (int i = 0; i < courseListYearTwo.Count; i++)
            {
                dataGridViewYear2.Columns[i + 6].HeaderText = courseListYearTwo[i].Name;
            }

            dataGridViewYear3.DataSource = LoadStudents(3);
            for (int i = 0; i < courseListYearThree.Count; i++)
            {
                dataGridViewYear3.Columns[i + 6].HeaderText = courseListYearThree[i].Name;
            }
        }
        private void txtYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "1")
            {
                lblCourse1.Text = courseListYearOne[0].Name;
                lblCourse2.Text = courseListYearOne[1].Name;
                lblCourse3.Text = courseListYearOne[2].Name;
                lblCourse4.Text = courseListYearOne[3].Name;
                lblCourse5.Text = courseListYearOne[4].Name;
                lblCourse6.Text = courseListYearOne[5].Name;
            }

            else if (comboBoxYear.Text == "2")
            {
                lblCourse1.Text = courseListYearTwo[0].Name;
                lblCourse2.Text = courseListYearTwo[1].Name;
                lblCourse3.Text = courseListYearTwo[2].Name;
                lblCourse4.Text = courseListYearTwo[3].Name;
                lblCourse5.Text = courseListYearTwo[4].Name;
                lblCourse6.Text = courseListYearTwo[5].Name;
            }
            else
            {
                lblCourse1.Text = courseListYearThree[0].Name;
                lblCourse2.Text = courseListYearThree[1].Name;
                lblCourse3.Text = courseListYearThree[2].Name;
                lblCourse4.Text = courseListYearThree[3].Name;
                lblCourse5.Text = courseListYearThree[4].Name;
                lblCourse6.Text = courseListYearThree[5].Name;

            }
        }

        private void studentsToTxt(int year, StreamWriter streamWriter)
        {
            List<DataGridView> dataGridViews = new List<DataGridView>() { dataGridViewYear1, dataGridViewYear2, dataGridViewYear3 };
            switch (year)
            {
                case 1:
                    streamWriter.WriteLine("Students in year 1\n");
                    break;
                case 2:
                    streamWriter.WriteLine("Students in year 2\n");
                    break;
                case 3:
                    streamWriter.WriteLine("Students in year 3\n");
                    break;
            }

            for (int i = 0; i < dataGridViewYear2.Columns.Count; i++)
            {
                streamWriter.Write(dataGridViews[year - 1].Columns[i].HeaderText + "\t");
            }
            streamWriter.WriteLine("\n");
            foreach (DataGridViewRow row in dataGridViews[year - 1].Rows)
            {
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    streamWriter.Write(row.Cells[j].Value + "\t");
                }
                streamWriter.WriteLine("\n");
            }

        }

        private void coursesToTxt(StreamWriter streamWriter, int year)
        {
            switch (year)
            {
                case 1:
                    streamWriter.WriteLine("Courses in year 1\n");
                    for (int i = 0; i < courseListYearOne.Count; i++)
                    {
                        streamWriter.Write(courseListYearOne[i].ToString() + "\n");
                    }
                    streamWriter.WriteLine("\n\n");

                    break;
                case 2:
                    streamWriter.WriteLine("Courses in year 2\n");
                    for (int i = 0; i < courseListYearTwo.Count; i++)
                    {
                        streamWriter.Write(courseListYearTwo[i].ToString() + "\n");
                    }
                    streamWriter.WriteLine("\n\n");

                    break;
                case 3:
                    streamWriter.WriteLine("Courses in year 3\n");
                    for (int i = 0; i < courseListYearThree.Count; i++)
                    {
                        streamWriter.Write(courseListYearThree[i].ToString() + "\n");
                    }
                    streamWriter.WriteLine("\n\n");

                    break;
            }

        }

        public void clearFields()
        {
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtEmail.Text = null;
            txtTelephone.Text = null;
            comboBoxYear.Text = 1.ToString();
            comboBoxGrade1.Text = 0.ToString();
            comboBoxGrade2.Text = 0.ToString();
            comboBoxGrade3.Text = 0.ToString();
            comboBoxGrade4.Text = 0.ToString();
            comboBoxGrade5.Text = 0.ToString();
            comboBoxGrade6.Text = 0.ToString();
            richTextBoxPreview.Text = null;
        }
        #endregion HelperFunctions

        #region DrawingCharts
        private void getStudentsbyYear(int year)
        {
            students.Clear(); // clear the list before calling this method
            const string query = "SELECT * FROM Student WHERE studyYear=@year";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@year", year.ToString());
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string firstName = (string)reader["firstName"];
                        string lastName = (string)reader["lastName"];
                        string email = (string)reader["email"];
                        string telephone = (string)reader["telephone"];
                        long studyYear = (long)reader["studyYear"];

                        Student student = new Student(id, firstName, lastName, email, telephone, studyYear);
                        long course1 = (long)reader["course1"];
                        long course2 = (long)reader["course2"];
                        long course3 = (long)reader["course3"];
                        long course4 = (long)reader["course4"];
                        long course5 = (long)reader["course5"];
                        long course6 = (long)reader["course6"];

                        student.modifyGrade(0, (int)course1);
                        student.modifyGrade(1, (int)course2);
                        student.modifyGrade(2, (int)course3);
                        student.modifyGrade(3, (int)course4);
                        student.modifyGrade(4, (int)course5);
                        student.modifyGrade(5, (int)course6);

                        students.Add(student);
                    }
                }
            }
        }

        private int[] calculatePassedFailed(int year)
        {
            getStudentsbyYear(year);
            int passed = 0;
            int failed = 0;
            foreach (Student student in students)
            {
                foreach (int grade in student.grades)
                {
                    if (grade >= 5)
                    {
                        passed++;
                    }
                    else if (grade == 0) // no grade given yet 
                    {
                        continue;
                    }
                    else
                    {
                        failed++;
                    }
                }
            }
            int[] promAndFail = new int[] { passed, failed };
            return promAndFail;
        }

        private void btnStudDistribution_Click(object sender, EventArgs e)
        {
            studyYears.Clear();
            LoadStudyYears();
            float[] registedStud = new float[studyYears.Count];
            for (int year = 0; year < studyYears.Count; year++)
            {
                registedStud[year] = studyYears[year].registeredStudents;
            }

            barChart1.registerStud = registedStud;
            barChart1.Refresh();
        }
        private List<int[]> data = new List<int[]>();
        private void btnStudPercentage_Click(object sender, EventArgs e)
        {
            data.Clear();

            for (int year = 0; year < 3; year++)
            {
                data.Add(calculatePassedFailed(year + 1));
            }

            stackedChart1.Data = data;
            stackedChart1.Refresh();

        }

        #endregion DrawingCharts

        #region Print
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxPreview.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(130, 130));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        #endregion Print

        #region UserControl
        private void materialTabControl1_Enter(object sender, EventArgs e)
        {
            setStudyYearData2();
        }
        private void setStudyYearData2()
        {
            foreach (StudyYear year in studyYears)
            {
                switch (year.Year)
                {
                    case 1:
                        UCStudyYearFormat uCStudyYearFormat1 = new UCStudyYearFormat()
                        {
                            Title = "Study Year 1",
                            Credits = year.numberCredits.ToString(),
                            StudentsEnrolled = year.registeredStudents.ToString()
                        };
                        if (uCStudyYearFormat1.CoursesGrades == "")
                        {
                            var courses = "";
                            foreach (Course course in courseListYearOne)
                            {
                                courses += (course.Name + " - " + course.Teacher + "\n\n");
                            }
                            uCStudyYearFormat1.CoursesGrades = courses;
                        }
                        matCardTest.Controls.Add(uCStudyYearFormat1);
                        break;
                    case 2:
                        UCStudyYearFormat uCStudyYearFormat2 = new UCStudyYearFormat()
                        {
                            Title = "Study Year 2",
                            Credits = year.numberCredits.ToString(),
                            StudentsEnrolled = year.registeredStudents.ToString()
                        };
                        if (uCStudyYearFormat2.CoursesGrades == "")
                        {
                            var courses = "";
                            foreach (Course course in courseListYearTwo)
                            {
                                courses += (course.Name + " - " + course.Teacher + "\n\n");
                            }
                            uCStudyYearFormat2.CoursesGrades = courses;
                        }
                        matCardTest1.Controls.Add(uCStudyYearFormat2);

                        break;
                    case 3:
                        UCStudyYearFormat uCStudyYearFormat3 = new UCStudyYearFormat()
                        {
                            Title = "Study Year 3",
                            Credits = year.numberCredits.ToString(),
                            StudentsEnrolled = year.registeredStudents.ToString()
                        };
                        if (uCStudyYearFormat3.CoursesGrades == "")
                        {
                            var courses = "";
                            foreach (Course course in courseListYearThree)
                            {
                                courses += (course.Name + " - " + course.Teacher + "\n\n");
                            }
                            uCStudyYearFormat3.CoursesGrades = courses;
                        }
                        matCardTest2.Controls.Add(uCStudyYearFormat3);

                        break;
                }
            }
        }

        private void btnUpdateStudyYearData_Click2(object sender, EventArgs e)
        {
            matCardTest.Controls.Clear();
            matCardTest1.Controls.Clear();
            matCardTest2.Controls.Clear();
            LoadStudyYears();
            setStudyYearData2();
        }


        #endregion UserControl
      
    }  
}