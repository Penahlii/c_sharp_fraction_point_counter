
using Class__Library;

Console.WriteLine("----------------------------Fraction----------------------------");
Fraction fraction_1 = new(2, 12);
Fraction fraction_2 = new(3, 25);
Console.WriteLine($"Fraction Multiply: {fraction_1.Multiply(ref fraction_2)}");
Console.WriteLine($"Fraction Add: {fraction_1.Add(ref fraction_2)}");
Console.WriteLine($"Fraction Minus: {fraction_1.Minus(ref fraction_2)}");
Console.WriteLine($"Fraction Divide: {fraction_1.Divide(ref fraction_2)}");
Console.WriteLine("----------------------------Counter----------------------------");
Counter a = new(0, 100);
a.incriment();
a.incriment();
a.incriment();
a.incriment();
a.decriment();
a.decriment();
a.decriment();
a.decriment();
a.incriment();
a.incriment();
Console.WriteLine(a);
Console.WriteLine("----------------------------Point----------------------------");
Point point = new(20, 12);
Console.WriteLine(point);