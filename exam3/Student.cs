public class Student : Person
{
    string Program;
    int Year;
    double Fee;
    public Student (){}
    public Student(string name, string adress , string program, int year,double fee) : base(name, adress)
    {
        Program = program;
        Year = year;
        Fee = fee;
    }
   public string GetProgram()
    {
        return Program;
    }
   public void SetProgram(string program)
    {
        var programm = Program;
        System.Console.WriteLine(programm);
    }
    
    public int GetYear()
    {
        return Year;
    }
    public void SetYear(int year)
    {
        var yer=Year;
        System.Console.WriteLine(yer);
    }
    public double GetFee()
    {
        return Fee;
    }
    public void SetFee(double feee)
    {
        var fee= Fee;
        System.Console.WriteLine(fee);
    }
    public override string ToString()
    {
        return $"{base.ToString()} ,Program:{Program} , Year:{Year}, Fee:{Fee}";
    }
}