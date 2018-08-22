using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WS_DicasRapidas.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaID { get; set; }
        public string DsNome { get; set; }
    }

    public class Credential
    {
        [Key]
        public int CredentialID { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaID { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}