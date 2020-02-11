using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetDubuisGelin.Models.UtilisateurViewModel
{
    public class UtilisateurRegistrationViewModel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        public string MotdePasse { get; set; }
    }
}
