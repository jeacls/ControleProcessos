using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WS_DicasRapidas.Models
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool Logar(Credential oLogin)
        {
            try
            {

                //Pessoa oPessoa;
                Credential oCredential;

                using (var ctx = new objDbContext())
                {
                    oCredential = ctx.Credentials.FirstOrDefault(p => p.DsLogin == oLogin.DsLogin && p.DsSenha == oLogin.DsSenha);

                    if (oCredential != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                        
                } 

                //if (oLogin.DsLogin.Equals("1") && oLogin.DsSenha.Equals("1"))
                //{
                //    //oPessoa = oCredential.Pessoa;
                //    //BucarPessoa
                //    //oPessoa.PessoaID = 1;
                //    //oPessoa.DsNome = "Tio Ze Teste";
                //    //oPessoa.oCredential = oLogin;
                //    return true;
                //}
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public bool LogarTeste() 
        {
            return true;
        }
    }
}
