
namespace hometask9.models;

public class Student
{
    public    int Id { get; set; }
    public static int Count { get; set; }

    public Student()
    {
        Count++;
        Id = Count;
    }
}
