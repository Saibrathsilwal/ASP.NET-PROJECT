namespace GSLLS.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public string ProficiencyLevel { get; set; }

        // Navigation property
        public ICollection<Quiz> Quizzes { get; set; }
    }

}
