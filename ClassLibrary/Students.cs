namespace ClassLibrary
{
    public class Students
    {
        public List<Student> studentList = new()
        {
            new Student() { Id = 1, Name = "Sjaak", Age = 22, Grades = new List<int> { 10, 10, 10 }, Nationality = "The Netherlands" },
            new Student() { Id = 2, Name = "Bob", Age = 21, Grades = new List<int> { 6, 5, 4 }, Nationality = "Belgium" },
            new Student() { Id = 3, Name = "Jan", Age = 18, Grades = new List<int> { 4, 2, 4 }, Nationality = "Belgium" },
            new Student() { Id = 4, Name = "Piet", Age = 25, Grades = new List<int> { 5, 3, 2 }, Nationality = "The Netherlands" },
            new Student() { Id = 5, Name = "Klaas", Age = 22, Grades = new List<int> { 4, 3, 3 }, Nationality = "The Netherlands" }
        };
    }
}
