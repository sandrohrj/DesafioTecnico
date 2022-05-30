using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Sandro_Henrique.Models
{
    public class FornecedoresModel
    {
        public int id { get; set; }
        public char TipoDePessoa { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string DataDeNascimento { get; set; }
        public string Telefone { get; set; }


    }
}