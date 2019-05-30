using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cookboard.Models
{
    public partial class Utilizador
    {
        public Utilizador()
        {
            EmentaSemanal = new HashSet<EmentaSemanal>();
            Receita = new HashSet<Receita>();
            UtilizadorReceita = new HashSet<UtilizadorReceita>();
        }

        public string Username { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<EmentaSemanal> EmentaSemanal { get; set; }
        public virtual ICollection<Receita> Receita { get; set; }
        public virtual ICollection<UtilizadorReceita> UtilizadorReceita { get; set; }
    }
}
