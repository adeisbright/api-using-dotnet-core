namespace Weather.Models;

public class Person
{
    public string name { get; }

    public int id { get; }
    private static int num = 0;

    public Person(string userName)
    {
        name = userName;
        id = num;
        num++;
    }
}