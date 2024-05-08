    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendadaContatosArquivos
{
    internal class Address
    {
        string cep;
        string localidade;
        string uf;
        string logradouro;
        string tipoLogradouro;
        int numero;
        string complemento;

        public Address(string cep, string localidade, string uf, string logradouro, string tipoLogadouro, int numero, string complemento)
        {
            this.cep = cep;
            this.localidade = localidade;
            this.uf = uf;
            this.logradouro = logradouro;
            this.tipoLogradouro = tipoLogadouro;
            this.numero = numero;
            this.complemento = complemento;
        }

        public override string? ToString()
        {
            string valor;

            if (complemento == "")
            {
                valor =  cep + ";" + localidade +
                ";" + uf + ";"+ tipoLogradouro +";"+ logradouro +
                ";" + numero  ;
            }
            else
            {
                valor = cep + ";" + localidade +
                ";" + uf + ";" + tipoLogradouro + ";" + logradouro +
                ";" + numero + ";" + complemento;
            }

            return valor;
        }
    }
}
