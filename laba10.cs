Student student1 = new Student("Гаврин В.Л", 2020, "Ул Бенина д5", 89592341269, 3, "Ботаника");
Student student2 = new Student("Дарин А.Д", 2021, "Ул Шинина д124", 89782349902, 2, "Агрономия");
Student student3 = new Student("Зенив Б.П", 2019, "Ул Норена д121", 89353456512, 4, "Системный администратор");
Student[] mass = new Student[] { student1, student2, student3 };
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"ФИО студентa: {mass[i].fio}");
}
Console.WriteLine("Введите факультет: Ботаника, Агрономия или Системный администратор");
string ? facul = Console.ReadLine();
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].faculty == facul)
    {
        Console.WriteLine($"Студент заданного факультета: {mass[i].fio}");
    }
}
Console.WriteLine("Введите год");
int date = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].data > date)
    {
        Console.WriteLine($"Студент, поступивший после заданного года:{mass[i].fio}");
    }
}
class Student
{
    private string FIO;
    private int Data;
    private string Address;
    private long PhoneNumber;
    private int Course;
    private string Faculty;
    public Student(string FIO, int Data, string Address, long PhoneNumber, int Course, string Faculty)
    {
        this.FIO = FIO;
        this.Data = Data;
        this.Address = Address;
        this.PhoneNumber = PhoneNumber;
        this.Course = Course;
        this.Faculty = Faculty;
    }
    public string fio
    {
        get { return FIO; }
        set { FIO = value; }
    }
    public int data
    {
        get { return Data; }
        set { Data = value; }
    }
    public string address
    {
        get { return Address; }
    }
    public long phonenumber
    {
        get { return PhoneNumber; }
        set { PhoneNumber = value; }
    }
    public int course
    {
        set { Course = value; }
    }
    public string faculty
    {
        get { return Faculty; }
    }
}
