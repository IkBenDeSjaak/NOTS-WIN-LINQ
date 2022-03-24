using ClassLibrary;

List<Student> studentList = new Students().studentList;
List<Class> classes = new Classes().classList;

JoinExample(studentList, classes);

static void JoinExample(List<Student> studentList, List<Class> classList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 join @class in classList on student.ClassId equals @class.Id
                 select new { student.Name, @class.ClassName };

    // Method based query syntax
    var query2 = studentList.Join(classList,
        student => student.ClassId,
        @class => @class.Id,
        (student, @class) => new { student.Name, @class.ClassName });

    foreach (var student in query1)
    {
        Console.WriteLine($"{student.Name} - {student.ClassName}");
    }

    Console.WriteLine("-------------------------");

    foreach (var student in query2)
    {
        Console.WriteLine($"{student.Name} - {student.ClassName}");
    }
}

//GroupJoinExample(studentList, classes);

static void GroupJoinExample(List<Student> studentList, List<Class> classList)
{
    // Query expression syntax
    var query1 = from @class in classList
                 join student in studentList on @class.Id equals student.ClassId into studentsInClass
                 select new { Students = studentsInClass, Class = @class.ClassName };

    // Method based query syntax
    var query2 = classList.GroupJoin(studentList,
        @class => @class.Id,
        student => student.ClassId,
        (@class, students) => new { Class = @class.ClassName, Students = students });

    foreach (var group in query1)
    {
        Console.WriteLine(group.Class);
        foreach (var student in group.Students)
        {
            Console.WriteLine($"---{student.Name}");
        }
    }

    Console.WriteLine("-------------------------");

    foreach (var group in query2)
    {
        Console.WriteLine(group.Class);
        foreach (var student in group.Students)
        {
            Console.WriteLine($"---{student.Name}");
        }
    }
}

// LeftOuterJoinExample(studentList, classes);

static void LeftOuterJoinExample(List<Student> studentList, List<Class> classList)
{
    // Query expression syntax
    var query1 = from student in studentList
                 join @class in classList on student.ClassId equals @class.Id into classGroups
                 from @class in classGroups.DefaultIfEmpty()
                 select new { student.Name, ClassName = @class?.ClassName ?? string.Empty };

    var query2 = studentList.GroupJoin(classList,
        student => student.ClassId,
        @class => @class.Id,
        (student, @classes) => new { Student = student, Classes = @classes })
        .SelectMany(x => x.Classes.DefaultIfEmpty(),
        (student, @class) => new { student.Student.Name, ClassName = @class?.ClassName });

    foreach (var student in query1)
    {
        Console.WriteLine($"{student.Name} - {student.ClassName}");
    }

    Console.WriteLine("-------------------------");

    foreach (var student in query2)
    {
        Console.WriteLine($"{student.Name} - {student.ClassName}");
    }
}