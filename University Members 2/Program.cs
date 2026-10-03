namespace UniversityMembersPolymorphism;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public string StudentId { get; set; }

    public Student(string name, string studentId) : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Student name: " + Name + ", Student ID: " + StudentId);
    }
}

class Employee : Person
{
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary) : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee name: " + Name + ", Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName { get; set; }

    public Teacher(string name, string courseName) : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher name: " + Name + ", Course: " + CourseName);
    }
}

class Program
{
    static void ShowPersonInfo(Person person)
    {
        Console.WriteLine("Information from a method that accepts Person:");
        person.DisplayInfo();
    }

    static void Main(string[] args)
    {
        List<Person> universityMembers = new List<Person>();

        universityMembers.Add(new Person("Noura Salem"));
        universityMembers.Add(new Student("Fahad Ali", "ST-3021"));
        universityMembers.Add(new Employee("Mona Khalid", 9500m));
        universityMembers.Add(new Teacher("Saad Omar", "Computer Science"));

        foreach (Person member in universityMembers)
        {
            Console.WriteLine("Runtime type: " + member.GetType());
            member.DisplayInfo();
            Console.WriteLine();
        }

        ShowPersonInfo(universityMembers[3]);
    }
}
