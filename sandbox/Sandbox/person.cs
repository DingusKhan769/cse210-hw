public class Person
{
    private string _name;
    private int _age;

    public void Display()
    {
        Console.WriteLine($"{_name} - {_age}");
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public int GetAge()
    {
        return _age;
    }
    public void SetAge(int age)
    {
        if (age >= 0)
        {
           _age = age;
        }
        else
        {
            throw new Exception("Age cannot be negative");
        }
    }
}