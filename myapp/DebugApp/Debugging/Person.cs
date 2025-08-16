namespace HR;

public class Person
{
    public String Name { get; set; }
    public int Id { get; set; }
    public DateTime Birthdate { get; set; }

    public override string ToString()
    {
        return Id+" "+ Name+""+Birthdate.ToString();
    }

}