
namespace StudentApp.classes
{
    public class StudyYear
    {
        public long Year {  get; }
        public long numberCredits { get; }
        public long registeredStudents { get; set; }


        public StudyYear(long year, long numberCredits, long registeredStudents)
        {
            Year = year;
            this.numberCredits = numberCredits;
            this.registeredStudents = registeredStudents;

        }
    }
}
