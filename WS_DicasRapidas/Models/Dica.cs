using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WS_DicasRapidas.Models
{
    public class Dica
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DicaID { get; set; }

        [ForeignKey("Pessoa")]
        public int PessoaID { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("TipoDica")]
        public int TipoID{ get; set; }
        public virtual TipoDica TipoDica { get; set; }
        public string DsTitulo { get; set; }
        public string DsDescricao { get; set; }
        public DateTime DtDataInclusao { get; set; }
    }

    public class TipoDica 
    {
        [Key]
        public int TipoID { get; set; }
        public string DsTipo { get; set; }
    }
}