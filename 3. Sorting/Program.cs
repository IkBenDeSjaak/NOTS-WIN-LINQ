using ClassLibrary;

List<Student> studentList = new Students().studentList;

SortingExample(studentList);

static void SortingExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 orderby student.Age
                 select student;

    // Method based query syntax
    var query2 = studentList.OrderBy(student => student.Age);

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

// DescendingExample(studentList);

static void DescendingExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 orderby student.Age descending
                 select student;

    // Method based query syntax
    var query2 = studentList.OrderByDescending(student => student.Age);

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

//SecondarySort(studentList);

static void SecondarySort(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 orderby student.Age, student.Name
                 select student;

    // Method based query syntax
    var query2 = studentList.OrderBy(student => student.Age).ThenBy(student => student.Name);

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