using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+55 001 90000-0000", modelo: "G50", imei: "000000000000000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "+55 001 90000-0001", modelo: "13", imei: "000000000000001", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Deezer");