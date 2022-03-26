using ClassLibrary;

List<Student> studentList = new Students().studentList;

SelectExample(studentList);

static void SelectExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 select student.Name;

    // Method based query syntax
    var query2 = studentList.Select(student => student.Name);

    foreach (string name in query1)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine("-------------------------");

    foreach (string name in query2)
    {
        Console.WriteLine(name);
    }
}

//SelectManyExample(studentList);

static void SelectManyExample(List<Student> studentList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 from grades in student.Grades
                 select grades;

    // Method based query syntax
    var query2 = studentList.SelectMany(student => student.Grades);

    foreach (int grade in query1)
    {
        Console.WriteLine(grade);
    }

    Console.WriteLine("-------------------------");

    foreach (int grade in query2)
    {
        Console.WriteLine(grade);
    }
}

// SelectVsSelectMany(studentList);

static void SelectVsSelectMany(List<Student> studentList)
{
    var query1 = studentList.Select((student) => student.Grades);
    var query2 = studentList.SelectMany((student) => student.Grades);

    // query1: List of lists with grades
    // query2: List of grades
}