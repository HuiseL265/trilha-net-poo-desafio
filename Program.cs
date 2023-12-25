using DesafioPOO.Models;

// OK: Realizar os testes com as classes Nokia e Iphone

// Tentativa de instanciar a classe abstrata Smartphone
//Smartphone s1 = new Smartphone();

// Instanciando Nokia
Nokia s2 = new Nokia("11923232323","Modelo1","AB9212321",8);
s2.Ligar();
s2.InstalarAplicativo("Whatsapp");
s2.ReceberLigacao();


// Instanciando Iphone
Iphone s3 = new Iphone("11924242424","Modelo7","PR12324169",16);
s3.Ligar();
s3.InstalarAplicativo("Whatsapp");
s3.ReceberLigacao();
