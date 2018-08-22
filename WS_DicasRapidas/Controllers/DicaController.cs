using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WS_DicasRapidas.Models;

namespace WS_DicasRapidas.Controllers
{
    public class DicaController : ApiController
    {
        [HttpGet]
        public List<Dica> ListarDicas()
        {
            List<Dica> olstDica = new List<Dica>();

            Dica oDica = new Dica();
            var ctx = new objDbContext();

            return ctx.Dicas.ToList();

        }

        [HttpPost]
        public Dica Incluir(Dica oDicaIncluir)
        {
            var ctx = new objDbContext();
            try
            {
                //Dica oDicaIncluir = new Dica();
                Pessoa oPessoa = new Pessoa();
                oPessoa = ctx.Pessoas.First(p => p.PessoaID == 1);
                if (oDicaIncluir != null)
                {
                    
                    //           using (var ctx = new objDbContext())
                    //            {
                    
                    oDicaIncluir.DicaID = 40;
                    oDicaIncluir.DtDataInclusao = DateTime.Today;
                    oDicaIncluir.PessoaID = 1;
                    //oDicaIncluir.Pessoa = oPessoa;
                    //oDicaIncluir.TipoID = 1;
                    //oDicaIncluir.TipoDica = null;
                    ctx.Dicas.Add(oDicaIncluir);                    
                    //ctx.Database.ExecuteSqlCommand("insert into Dica values(1,1,'teste', 'teste', '2018-06-25')");
                    ctx.SaveChanges();

                    oDicaIncluir = ctx.Dicas.OrderByDescending(p => p.DicaID).First();
                    return oDicaIncluir;
                    //}
                }

                return new Dica { DicaID = 0 };

            }
            catch (Exception e)
            {

                throw;
            }
        }

        //[HttpPost]
        //public bool Alterar(Dica oDicaAlterar)
        //{
        //    try
        //    {
        //        if (oDicaAlterar != null)
        //        {
        //            using (var ctx = new objDbContext())
        //            {
        //                oDicaAlterar = ctx.Dicas.FirstOrDefault(p => p.DicaID == oDicaAlterar.DicaID);
        //            }
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        [HttpPost]
        public List<Dica> Excluir(long lDicaID)
        {
            try
            {
                if (lDicaID > 0)
                {
                    var ctx = new objDbContext();
                    //using (var ctx = new objDbContext())
                    //{
                    Dica oDica;
                    oDica = ctx.Dicas.FirstOrDefault(p => p.DicaID == lDicaID);

                    if (oDica != null)
                    {
                        ctx.Dicas.Remove(oDica);
                        ctx.SaveChanges();
                        return ctx.Dicas.ToList();
                    }
                    //}
                }

                return new List<Dica>();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
