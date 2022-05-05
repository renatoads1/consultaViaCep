using Microsoft.EntityFrameworkCore;

namespace consomeApiCep.Models
{
    public class Enderecos
    {
        public int Id { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public Enderecos()
        {
        }

        public Enderecos(string cep, string logradouro, string complemento, string bairro, string localidade, string uf, string ibge, string gia, string ddd, string siafi)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.complemento = complemento;
            this.bairro = bairro;
            this.localidade = localidade;
            this.uf = uf;
            this.ibge = ibge;
            this.gia = gia;
            this.ddd = ddd;
            this.siafi = siafi;
        }
    }
}
