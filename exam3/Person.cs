public class Person
{
    string Name;
    string Adress;
    public Person(){}
    public Person(string name, string adress)
    {
        Name = name;
        Adress = adress;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetAdress()
    {
        return Adress;
    }
    void SetAdress(string adress)
    {
        var Adress=adress;
    }
   public virtual string ToString()
    {
        return $"Name:{Name},Adress{Adress} ";
    }
}