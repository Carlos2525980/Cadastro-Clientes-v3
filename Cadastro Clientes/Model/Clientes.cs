using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Clientes.Model
{
    public class Clientes
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
