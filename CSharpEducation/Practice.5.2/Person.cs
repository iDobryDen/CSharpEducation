namespace Practice._5._2;

public class Person
{
    public string Name;
    public int Age;

    public bool CheckIsAdult()
    {
        if (this.Age > 18)
        {
            return true;
        }
        return false;
    }
}
