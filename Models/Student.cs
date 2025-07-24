using System;

namespace Tester.Models
{
    public class Student
    {
        // Private fields for encapsulation
        private string _firstName;
        private string _lastName;
        private Gender _gender = Gender.Unknown;

        // Default constructor
        public Student()
        {
            _firstName = "Default";
            _lastName = "Student";
            Title = "";
            Course = "";
            Section = "";
            Birthday = DateTime.Today;
        }

        // Constructor with first and last name
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Read-only properties with custom setters
        public string FirstName => _firstName;
        public string LastName => _lastName;

        public void SetFirstName(string firstName) => _firstName = firstName;
        public void SetLastName(string lastName) => _lastName = lastName;

        // Public properties
        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }

        // Gender
        public void SetGender(Gender gender) => _gender = gender;
        public Gender Gender => _gender;

        // Derived properties
        public string FullName => $"{Title} {FirstName} {LastName}".Trim();

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
