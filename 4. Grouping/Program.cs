using ClassLibrary;

List<Student> studentList = new Students().studentList;

GroupingExample(studentList);

static void GroupingExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 group student by student.Nationality;

    // Method based query syntax
    var query2 = studentList.GroupBy(student => student.Nationality);

    foreach (var group in query1)
    {
        Console.WriteLine();
        Console.WriteLine($"Students from {group.Key}: \n");

        foreach (Student student in group)
        {
            Console.WriteLine($"{student.Name}: {student.Nationality}");
        }
    }

    Console.WriteLine("-------------------------");

    foreach (var group in query2)
    {
        Console.WriteLine();
        Console.WriteLine($"Students from {group.Key}: \n");

        foreach (Student student in group)
        {
            Console.WriteLine($"{student.Name}: {student.Nationality}");
        }
    }
}