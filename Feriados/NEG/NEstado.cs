using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Feriados.ENT;
using Feriados.DAL;

namespace Feriados.NEG
{
    public class NEstado
    {
        DEstado nEstado = new DEstado();

        //listar
        public DataTable listarEstado(int IdPais)
        {
            return nEstado.listarEstado(IdPais);
        }
    }
}
