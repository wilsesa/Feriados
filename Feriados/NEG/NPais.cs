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
    public class NPais
    {
        DPais nPais = new DPais();

        //listar
        public DataTable listarPais(int IdTipo)
        {
            return nPais.listarPais(IdTipo);
        }
    }
}
