
namespace Example;

public class Person:ICloneable
{
    public Person(string name, string surname, Department department, int salary, int premium)
    {
        Name = name;
        Surname = surname;
        Department = department;
        Salary = salary;
        Premium = premium;
        Console.WriteLine("Person nesnesi oluşturuldu.");
    }

    public string Name { get; set; }
    public string  Surname { get; set; }
    public Department Department { get; set; }
    public int Salary { get; set; }
    public int Premium { get; set; }
    
    public object Clone()
    {
        return MemberwiseClone();
    }
}