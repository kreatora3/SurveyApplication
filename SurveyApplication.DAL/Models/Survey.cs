

namespace SurveyApplication.DAL.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Properties Properties { get; set; }
    }

    public class Properties
    {
        public Firstname FirstName { get; set; }
        public Lastname LastName { get; set; }
        public Email Email { get; set; }
        public Age Age { get; set; }
    }

    public class Firstname
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
    }

    public class Lastname
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
    }

    public class Email
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
    }

    public class Age
    {
        public string Type { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }

}
