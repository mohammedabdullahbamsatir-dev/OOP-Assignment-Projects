namespace UniversityMembers;

public class Person
{
    public string Name { get; }
    public string Email { get; }

    public Person(string name, string email)
    {
        Console.WriteLine("Person constructor");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Student : Person
{
    public string StudentId { get; }
    public double GPA { get; }

    public Student(string name, string email, string studentId, double gpa)
        : base(name, email)
    {
        Console.WriteLine("Student constructor");
        StudentId = studentId;
        GPA = gpa;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"GPA: {GPA:F2}");
    }
}

public class Employee : Person
{
    public string EmployeeId { get; }
    public decimal Salary { get; }

    public Employee(string name, string email, string employeeId, decimal salary)
        : base(name, email)
    {
        Console.WriteLine("Employee constructor");
        EmployeeId = employeeId;
        Salary = salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Salary: {Salary:N0}");
    }
}

public class Teacher : Employee
{
    public string CourseName { get; }

    public Teacher(string name, string email, string employeeId, decimal salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        Console.WriteLine("Teacher constructor");
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {CourseName}.");
    }
}

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Creating Student ===");
        var student = new Student("Sara Ahmed", "sara@university.edu", "S2026001", 3.85);

        Console.WriteLine("\n=== Creating Teacher ===");
        var teacher = new Teacher("Omar Khaled", "omar@university.edu", "E1042", 18000m, "Object-Oriented Programming");

        Console.WriteLine("\n=== Student details ===");
        student.DisplayBasicInfo();
        student.DisplayStudentInfo();

        Console.WriteLine("\n=== Teacher details ===");
        teacher.DisplayBasicInfo();
        teacher.DisplayEmployeeInfo();
        teacher.Teach();
    }
}
