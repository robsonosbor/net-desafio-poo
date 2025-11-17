﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "12121212", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iPhone = new Iphone("987654321", "Modelo iPhone", "45454545", 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("ChatGPT");