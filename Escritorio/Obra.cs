using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Microsoft.Identity.Client;

namespace Escritorio
{
    public class Obra
    {
        [Key]
        public int Id { get; set; }
        public string isbn { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public int Anno { get; set; }
        public int Npag { get; set; }
        public Obra(string Autor, string Titulo, string Editorial, int Anno, int Npag, string isbn)
        {
            this.isbn = isbn;
            this.Autor = Autor;
            this.Titulo = Titulo;
            this.Editorial = Editorial;
            this.Anno = Anno;
            this.Npag = Npag;
        }
    }
}
