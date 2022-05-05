using consomeApiCep.Data;
using consomeApiCep.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViaCep;

namespace consomeApiCep.Services
{
    public class ServiceCep
    {
        

        public async Task<string> buscaCep(string cep) {

        var context = new ApplicationDbContext();

            try
            {
                var result = new ViaCepClient().Search(cep); //searches for the postal code 01001-000
                var cidade = result.City; //Praça da Sé
                var rua = result.Street.ToString();
                var complemento = result.Complement.ToString();
                var bairro = result.Neighborhood.ToString();
                var uf = result.StateInitials.ToString();

                Enderecos end = new Enderecos();
                end.logradouro = rua;
                end.complemento = complemento;
                end.bairro = bairro;
                end.localidade = cidade;
                end.uf = uf;
                context.Add(end);
                context.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Erro "+err.Message);
            }

            return "";
            
        }

    }
}
