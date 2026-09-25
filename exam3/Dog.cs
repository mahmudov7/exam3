public class Dog : Animal
{
    public Dog(){}
    public Dog(string name):base (name){}
    public override void Greets()
    {
        System.Console.WriteLine("woooof");
    }
    public virtual void greets()
    {
        System.Console.WriteLine("wooooooooof");
    }
}