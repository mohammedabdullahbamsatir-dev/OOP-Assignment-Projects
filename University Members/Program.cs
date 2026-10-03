namespace UniversityMembersMyVersion;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Console.WriteLine("Person constructor is running");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
    }
}

class Student : Person
{
    public string StudentId;
    public double GPA;

    public Student(string name, string email, string studentId, double gpa)
        : base(name, email)
    {
        Console.WriteLine("Student constructor is running");
        StudentId = studentId;
        GPA = gpa;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("GPA: " + GPA);
    }
}

class Employee : Person
{
    public string EmployeeId;
    public decimal Salary;

    public Employee(string name, string email, string employeeId, decimal salary)
        : base(name, email)
    {
        Console.WriteLine("Employee constructor is running");
        EmployeeId = employeeId;
        Salary = salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, string employeeId, decimal salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        Console.WriteLine("Teacher constructor is running");
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " teaches " + CourseName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating a student:");
        Student student = new Student("Maha Ali", "maha@university.edu", "S1005", 3.7);

        Console.WriteLine();
        Console.WriteLine("Creating a teacher:");
        Teacher teacher = new Teacher("Yousef Sami", "yousef@university.edu", "T204", 12000m, "Programming");

        Console.WriteLine();
        Console.WriteLine("Student information:");
        student.DisplayBasicInfo();
        student.DisplayStudentInfo();

        Console.WriteLine();
        Console.WriteLine("Teacher information:");
        teacher.DisplayBasicInfo();
        teacher.DisplayEmployeeInfo();
        teacher.Teach();
    }
}
