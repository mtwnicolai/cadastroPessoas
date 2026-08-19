using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Models
{
    public class Pessoa
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }


        public Endereco Endereco { get; set; }
    }
}
