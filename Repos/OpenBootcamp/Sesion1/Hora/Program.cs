Console.WriteLine("Digite la hora");
int year = int.Parse(Console.ReadLine());
int month = int.Parse(Console.ReadLine());
int day = int.Parse(Console.ReadLine());
DateTime fecha = new DateTime(year, month, day);
Console.WriteLine("La fecha es: " + fecha);