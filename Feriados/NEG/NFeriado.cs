using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Feriados.ENT;
using Feriados.DAL;
using Feriados.NEG;
using System.Data;

namespace Feriados.NEG
{
    class NFeriado
    {
        DFeriado nFer = new DFeriado();

        //Insertamos
        public int registrarFeriado(EFeriado eFer)
        {
            return nFer.registrarFeriado(eFer);
        }

        //Listar
        //public DataTable listarFeriado()
        //{

        //}
    }
}
