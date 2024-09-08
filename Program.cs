using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia("1", "Modelo1", "NK1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("-----------------");

Console.WriteLine("IPHONE");
Smartphone iphone= new Iphone("22", "11", "432444", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Maça");





