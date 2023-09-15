using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "94984562415", modelo: "Modelo 01", imei: "547896421525", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");

Console.WriteLine("----------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "93984321665", modelo: "Modelo 07", imei: "514802103250", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp Business");