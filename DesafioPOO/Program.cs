using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("ML01", "1234567", 64);
nokia.Numero = "11 91234-5678";
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("Iphone 12", "1234568", 120, "11 94321-8765");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


System.Console.WriteLine();
