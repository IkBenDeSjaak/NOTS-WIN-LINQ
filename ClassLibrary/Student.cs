namespace ClassLibrary
{
    public class Student
    {
        public Student()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
        public string Nationality { get; set; }
    }
}