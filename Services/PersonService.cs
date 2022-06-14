using Weather.Models;

namespace Weather.Services;
public static class PersonService
{
    public static List<Person> persons = new List<Person>{
        new Person("Adeleke") ,
        new Person("Ajiri")
    };

    public static List<Person> addPerson(string name)
    {
        var p = new Person(name);
        persons.Add(p);
        return persons;
    }

    public static List<Person> getPersons() => persons;

    public static Person? getPerson(int id) => persons.FirstOrDefault(p => p.id == id);
    public static void deletePerson(int id)
    {
        var person = getPerson(id);
        if (person != null)
        {
            persons.Remove(person);
            return;
        }
        return;
    }
    public static void updatePerson(int id, Person person)
    {
        var personIndex = persons.FindIndex(p => p.id == id);
        if (personIndex != -1)
        {
            persons[personIndex] = person;
        }
        return;
    }

}