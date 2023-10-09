using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// TESTADO.

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "A36", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654123", modelo: "15", imei: "2222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");
