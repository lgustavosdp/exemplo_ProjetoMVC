using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//teste
namespace PROJETOMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        //public int Id { get; protected set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo  { get; set; } 
    }
}