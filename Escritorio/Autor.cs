using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio
{
    public class Autor
    {
        [Key] public int Id { get; set; }
        public string issn { get; set; }
        public string nombre { get; set; }
        public int? annus_natio { get; set; }
        public int? annus_defunctio { get; set; }

        public Autor(string issn, string nombre, int? annus_natio, int? annus_defunctio)
        {
            this.issn = issn;
            this.nombre = nombre;
            this.annus_natio = annus_natio;
            this.annus_defunctio = annus_defunctio;
        }
    }
}
