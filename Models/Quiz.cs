namespace GSLLS.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int LanguageId { get; set; }

        // Navigation property
        public Language Language { get; set; }
    }

}
