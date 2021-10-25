using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teste.Models
{
    public class Veiculo
    {
        [Key]
        public int codigo { get; set; } 
        public string placa { get; set; }
        public string renavan { get; set; }
        public string NomeDoProprietario { get; set; }
        public string cpf { get; set; }
    }
}