public class Cat : Animal
{
    public Cat(){}
    public Cat (string name) : base (name){}
    public override void Greets()
    {
         System.Console.WriteLine("Miiiyaav");
    }
}