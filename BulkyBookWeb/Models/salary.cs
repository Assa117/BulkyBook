namespace BulkyBookWeb.Models
{
    public class   salary
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateOnly Birth { get; set; }

        public int Children { get; set; }

        public string EducationLvl { get; set; }

        public DateOnly Hire { get; set; }

        public float Salary { get; set; }
    }
}
