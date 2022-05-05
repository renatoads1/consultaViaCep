using consomeApiCep.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace consomeApiCep.Util
{
    internal class dbAutomation
    {
        public void GerarBancoDeDados()
        {

            //usado para criar o banco via EF
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
