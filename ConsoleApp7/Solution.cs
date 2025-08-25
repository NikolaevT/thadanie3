namespace ConsoleApp3;

public class Solution
{
    public void GetData<T>(T value)
    {
        string result = value?.ToString() ?? "null";
        Console.WriteLine(result);
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
}