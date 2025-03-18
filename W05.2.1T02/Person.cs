public class Person
{
    private string _firstName;
    private string _lastName;

    public Person(string firstname, string lastname)
    {
        _firstName = firstname;
        _lastName = lastname;
    }

    public string FullName => $"{_firstName} {_lastName}";

}