using ClassLibrary;

List<Student> studentList = new Students().studentList;

FilterExample(studentList);

static void FilterExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 where student.Age > 21
                 select student;

    // Method based query syntax
    var query2 = studentList.Where(student => student.Age > 21);

    foreach (Student student in query1)
    {
        Console.WriteLine($"{student.Name}: {student.Age}");
    }

    Console.WriteLine("-------------------------");

    foreach (Student student in query2)
    {
        Console.WriteLine($"{student.Name}: {student.Age}");
    }
}