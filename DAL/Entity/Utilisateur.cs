using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Utilisateur
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        
    }
}
