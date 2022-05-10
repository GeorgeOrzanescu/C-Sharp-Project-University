using System.Windows.Forms;

namespace StudentApp
{
    public partial class UCStudyYearFormat : UserControl
    {
        public string Title
        {
            get => lblStudyYear.Text;
            set => lblStudyYear.Text = value;
        }

        public string Credits
        {
            get => mtbCreditsYear.Text;
            set => mtbCreditsYear.Text = value;
        }

        public string StudentsEnrolled
        {
            get => mtbStudentsYear.Text;
            set => mtbStudentsYear.Text = value;
        }

        public string CoursesGrades
        {
            get => richTextBoxCoursesYear.Text;
            set => richTextBoxCoursesYear.Text = value;
        }

        public UCStudyYearFormat()
        {
            InitializeComponent();
        }


    }
}
