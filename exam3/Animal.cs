public abstract class Animal
{
    string Name;
    public Animal(){}
    public Animal(string name)
    {
        Name = name;
    }
    public abstract void Greets();
}