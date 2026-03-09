using System;

public class Person
{
    public string _givenName = "";
    public string _familyName = "";
    public Person() { }
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Person person1 = new Person();
        Person person2 = new Person();
        person1._givenName = "Emma";
        person2._givenName = "Joseph";
        person1._familyName = "Smith";
        person2._familyName = "Smith";
        person1.ShowWesternName();
        person2.ShowWesternName();

    }
}