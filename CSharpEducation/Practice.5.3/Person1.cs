namespace Practice._5._3;

public class Person
{
    public string Firstname;
    public string Lastname;
    public int Age;
    public string Company;

    //public Person()
    //{
        //this.Firstname = "Denis";
        //this.Lastname = "Pere";
        //this.Age = 10;
        //this.Company = "UDGU";
    //}
    public Person(string Firstname, string Lastname, int Age, string Company)
    {
        this.Firstname = Firstname;
        this.Lastname = Firstname;
        this.Age = Age;
        this.Company = Firstname;
    }
}