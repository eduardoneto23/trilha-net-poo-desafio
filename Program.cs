using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", "32GB");
nokia.Ligar();

nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine();
Console.WriteLine("Teste concluído com sucesso!");      