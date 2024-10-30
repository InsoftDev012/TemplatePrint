namespace TemplatePrint.Models
{
    public class SchoolReportModel
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string ESTD { get; set; }
        public string SchoolLogo { get; set; }
        public List<Student> Students { get; set; }
        public List<TestType> TestTypes { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<PersonnalDev> PersonnalDevs { get; set; }
        public string Remarks { get; set; }
    }

    public class Student
    {
        public string RegNo { get; set; }
        public string STDNAME { get; set; }
        public string Roll { get; set; }
        public string ClassName { get; set; }
        public string Semester { get; set; }
        public string Sec { get; set; }
    }

    public class TestType
    {
        public string Id { get; set; }
        public string Alias { get; set; }
    }

    public class Subject
    {
        public string SubCode { get; set; }
        public string SubjectName { get; set; }
    }

    public class PersonnalDev
    {
        public string UkId { get; set; }
        public string Gname { get; set; }
    }

    public partial class SchoolReportTemplate
    {
        private List<SchoolReportModel> _reports { get; set; }
        public SchoolReportTemplate(List<SchoolReportModel> reports)
        {
            _reports = reports;
        }
    }
}
