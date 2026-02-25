
double x1, y1, x2, y2, d;

Console.WriteLine("digite o valor de x1");
x1 = Convert.ToDouble((Console.ReadLine));
Console.WriteLine("digite o valor de x2");
x2 = Convert.ToDouble((Console.ReadLine));
Console.WriteLine("digite o valor de y1");
y1 = Convert.ToDouble((Console.ReadLine));
Console.WriteLine("digite o valor de y2");
y2 = Convert.ToDouble((Console.ReadLine));
d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("o valor dos ponos e" + d);
Console.ReadKey();