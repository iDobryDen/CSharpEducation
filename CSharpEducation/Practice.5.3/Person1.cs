namespace Practice._5._3;

public class Person
{
    public string Firstname;
    public string Lastname = "Pere";
    public int Age;
    public string Company = "UdGU";

    //public Person()
    //{
    //    this.Lastname = "Pere";
    //    this.Company = "UDGU";
    //}
    //public Person(string Firstname, string Lastname, int Age, string Company)
    //{
    //    this.Firstname = Firstname;
    //    this.Lastname = Firstname;
    //    this.Age = Age;
    //    this.Company = Firstname;
    //}
    public Person(string Firstname, int Age)
    {
        this.Firstname = Firstname;
        this.Age = Age;
    }
}