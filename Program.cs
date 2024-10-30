using DesafioPOO.Models;

// teste nokia 
Console.WriteLine("Smartphone Nokia"); 
Smartphone nokia = new Nokia(numero:"12345",modelo:"Modelo 1",imei:"1223455",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp"); 


// teste Iphone 
Console.WriteLine("Smartphone Iphone"); 
Smartphone iphone = new Iphone(numero:"45466",modelo:"Modelo 2",imei:"222334",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Uber");

