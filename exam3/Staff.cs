using System.Security.Cryptography.X509Certificates;

public class Staf : Person
{
    string School;
    double Pay;
    public Staf(){}
    public Staf(String name, string adress, string school,double pay) : base (name, adress)
    {
        School = school;
        Pay = pay;
    }
   public string GetSchool()
    {
        return School;
    }
    public void SetSchool(string scol)
    {
        var school = School;
        System.Console.WriteLine(school);
    }
   public double GetPay()
    {
        return Pay;
    }
   public void SetPay()
    {
        System.Console.WriteLine(Pay); 
    }
    public override string ToString()
    {
        return $"{base.ToString()} School:{School}, Pay: {Pay}";
    }
}