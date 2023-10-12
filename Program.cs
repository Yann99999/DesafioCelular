using DesafioCelular.Models;

Nokia nokia = new(numero: "1199999999", modelo: "Nokia Tijolão", imei: "1330932883", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarApp("Facebook");

Iphone iphone = new(numero: "1199999999", modelo: "Iphone 15", imei: "1330932883", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarApp("Facebook");