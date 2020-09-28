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
    public class NTipo
    {
        DTipo nTipo = new DTipo();

        //listar
        public DataTable listarTipo()
        {
            return nTipo.listarTipo();
        }
    }
}
