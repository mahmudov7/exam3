//task 1
//dar masiv mo razmer medihem az razmeramon bisyortar element qabul namekunad ,, list bowad chi qadare ki mo element ilova mekunem hamon qadar ast.
//task 2
//meros classi ochagi mebowad ki classhoi bachagi az u meros megirand, mo baroi on istofoda mebarem ki programma tez kor kunad va pamyatro bisyor nagirad,;
//task 3

//task 4
//vaqte mo clasro abstrakt nakunem boyad mo yagon return dowte bowem, agar abstarkt bowad metodi mo yagon return namegirad va xato namewavad;


//task5
// Student student1 = new Student("Alijon","Aliwer navoi", "IT", 2021,32222);
// Console.WriteLine(student1.ToString());
//task 6
// Dog dog1 = new Dog("bars"){};
// dog1.Greets();
// Cat cat1 = new Cat("piwak"){};
// cat1.Greets();
// BIgDog bIgDog1 = new BIgDog("kaloom"){};
// bIgDog1.grets();
// bIgDog1.Greets();
// bIgDog1.greets();
//task 7
List <int> ins = new List<int>{-11,-22,5,3,5,8};
var a =ins.Distinct().ToList();
foreach (var item in a)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
ins.Sort();
foreach (var item in ins)
{
    System.Console.Write(item+" ");
}
