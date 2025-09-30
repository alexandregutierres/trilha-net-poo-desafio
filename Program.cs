using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "Symbian OS", 512);       
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");   

Console.WriteLine("\n-----------------------\n");

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone("987654321", "iPhone 13", "iOS", 4096);    
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
