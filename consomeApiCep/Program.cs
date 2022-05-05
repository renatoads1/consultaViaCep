using consomeApiCep.Services;
using consomeApiCep.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace consomeApiCep
{
    public class Program
    {
        static void Main(string[] args)
        {
            //gera banco
            //dbAutomation db = new dbAutomation();
            //db.GerarBancoDeDados();
            
            Console.WriteLine("Digite Um cep ou x para sair");
            string cep = "";
            while (cep != "x") {
                cep = Console.ReadLine();
                ServiceCep cepcons = new ServiceCep();
                cepcons.buscaCep(cep);
            }
            
        }
    }
}
