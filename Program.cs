using DesafioPOO.Models;

var Telefone1 = new Iphone("(31) 99985-2023", "Iphone X", "23004300EMS", 4096);
var Telefone2 = new Iphone("(31) 99985-2024", "Nokia V5", "23004300EMS", 4096*2);

Telefone1.ReceberLigacao();
Telefone1.Ligar();
Telefone1.InstalarAplicativo("YouTube");

Telefone2.ReceberLigacao();
Telefone2.Ligar();
Telefone2.InstalarAplicativo("YouTube");