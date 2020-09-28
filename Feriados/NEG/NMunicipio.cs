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
    public class NMunicipio
    {
        DMunicipio nMunicipio = new DMunicipio();

        //listar
        public DataTable listarMunicipio(int IdEstado)
        {
            return nMunicipio.listarMunicipio(IdEstado);
        }
    }
}
