using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste do Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "96245-6727", modelo: "Nokia C12", imei: "111111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

Console.WriteLine(Environment.NewLine);

Console.WriteLine("Teste do Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "96245-6727", modelo: "Iphone 15 Pro Max", imei:"222222222222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();