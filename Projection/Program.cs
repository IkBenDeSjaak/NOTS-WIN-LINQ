List<Student> studentList = new() {
    new Student() { Id = 1, Name = "Sjaak", Age = 22, Grades = new List<int> { 10, 10, 10 } },
    new Student() { Id = 2, Name = "Bob",  Age = 21, Grades = new List<int> { 6, 5, 4 } },
    new Student() { Id = 3, Name = "Jan",  Age = 18, Grades = new List<int> { 4, 2, 4 } },
    new Student() { Id = 4, Name = "Piet" , Age = 25, Grades = new List<int> { 5, 3, 2 } },
    new Student() { Id = 5, Name = "Klaas" , Age = 22, Grades = new List<int> { 4, 3, 3 } }
};

// Query expression syntax
var query = from student in studentList
             select student.Name;

// Method based query syntax
var query2 = studentList.Select(student => student.Name);

Console.WriteLine("-------------------------");

foreach (string s in query)
{
    Console.WriteLine(s);
}

Console.WriteLine("-------------------------");

foreach (string s in query2)
{
    Console.WriteLine(s);
}

Console.WriteLine("-------------------------");

var query3 = studentList.SelectMany(student => student.Grades);

foreach (int s in query3)
{
    Console.WriteLine(s);
}