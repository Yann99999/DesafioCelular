using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular.Models
{
    public abstract class Smartphone
    {

        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarApp(string app);
    }
}