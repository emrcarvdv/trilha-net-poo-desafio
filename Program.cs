using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Smartphone iphone = new Iphone("987654321", "Iphone 11", "987654321", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");