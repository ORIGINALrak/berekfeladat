
using _20241118;
using System.Text;

List<Dolgozok> dolgozok = new List<Dolgozok>();
using StreamReader sr = new("berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream) dolgozok.Add(new(sr.ReadLine()!));

var f3 = dolgozok.Count();
Console.WriteLine($"3. feladat: Ennyi dolgozó található: {f3}");

var f4 = dolgozok.Average(d => d.ber);
Console.WriteLine($"4. feladat: Az átlagbér 2020-ban: {Math.Round(f4/1000,1)} eHf");

Console.Write("5. feladat: Mondj egy részleget: ");
string f5 = Console.ReadLine()!;
var f6 = dolgozok.Where(d => d.reszleg == f5).MaxBy(d => d.ber);
if(f6 == null)
{
    Console.WriteLine($"6. feladat: Ilyen részleg nem létezik");
}
else
{
    Console.WriteLine($"6. feladat: {f6}");
}

var f7 = dolgozok.GroupBy(d => d.reszleg);
Console.WriteLine("7. feladat: Statisztika");
foreach(var d in f7)
{
    Console.WriteLine($"\t{d.Key}: {d.Count()} fő");
}