using ClassLibrary;

List<Student> studentList = new Students().studentList;
List<Class> classes = new Classes().classList;

OtherOperationExamples(studentList);

static void OtherOperationExamples(List<Student> studentList)
{
    int numberOfStudents = studentList.Count();
    int highestAge = studentList.Max(student => student.Age);
    int sumOfAges = studentList.Sum(student => student.Age);
    int skippedSumOfAges = studentList.Skip(1).Sum(student => student.Age);
    int firstThreeSumOfAges = studentList.Take(3).Sum(student => student.Age);
    var averagePerStudent = studentList.Select((student) => new { student.Name, Average = student.Grades.Average((grade) => grade) });

    Console.WriteLine($"Number of students: {numberOfStudents} \n");
    Console.WriteLine($"Highest age: {highestAge} \n");
    Console.WriteLine($"Sum of all ages: {sumOfAges} \n");
    Console.WriteLine($"Sum of all ages (skipped): {skippedSumOfAges} \n");
    Console.WriteLine($"Sum of all ages (first 3): {firstThreeSumOfAges} \n");

    foreach (var student in averagePerStudent)
    {
        Console.WriteLine($"{student.Name} - {student.Average}");
    }
}

//FirstExample(studentList);

static void FirstExample(List<Student> studentList)
{
    List<Student> emptyStudentList = new();

    var student1 = studentList.First();
    var student2 = emptyStudentList.FirstOrDefault();

    Console.WriteLine(student1.Name);
    Console.WriteLine(student2?.Name);

    //var student3 = emptyStudentList.First();
}

//DeferredExecutionExample(studentList);

static void DeferredExecutionExample(List<Student> studentList)
{
    // Method based query syntax
    var query = studentList.Where(student => student.Age > 21);

    foreach (Student student in query) // Query executed here
    {
        Console.WriteLine($"{student.Name}: {student.Age}");
    }

    studentList.Add(new Student() { Id = 6, Name = "Bram", Age = 24, Grades = new List<int> { 3, 6, 10 }, Nationality = "The Netherlands", ClassId = 1 });

    Console.WriteLine("-------------------------");
    foreach (Student student in query) // Query executed here
    {
        Console.WriteLine($"{student.Name}: {student.Age}");
    }
}

//CustomWhereMethodExample(studentList);

static void CustomWhereMethodExample(List<Student> studentList)
{
    var query = studentList.WhereAbove21();

    foreach (Student student in query)
    {
        Console.WriteLine($"{student.Name}: {student.Age}");
    }
}

//CustomCountMethodExample(studentList);

static void CustomCountMethodExample(List<Student> studentList)
{
    int amountOfStudents = studentList.CustomCountItems();

    Console.WriteLine($"Amount of students: {amountOfStudents}");

}

//CustomMethodReturnsSequenceExample();

static void CustomMethodReturnsSequenceExample()
{
    List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    var query1 = numbers.RemoveFirstThree();

    foreach (int number in query1)
    {
        Console.WriteLine(number);
    }
}