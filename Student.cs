public class Student
{
    public int id;
    public string name;
    public int age;
    public float note;

    public Student(int id, string name, int age, float note )
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.note = note;
    }
    
    public void Info()
    {
        Console.WriteLine(" Id: " + id);
        Console.WriteLine(" Name: " + name);
        Console.WriteLine(" Age: " + age);
        Console.WriteLine(" Note: " + note);
        Console.WriteLine();
    }

}