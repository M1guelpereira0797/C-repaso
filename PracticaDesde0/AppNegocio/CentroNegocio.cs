using System;
using System.Collections.Generic;
using System.Text;
using AppDataBase;
using AppEntidades;

namespace AppNegocio
{
    public class CentroNegocio
    {
        public static  List<CENTRO_LOGISTICO> CargarCentros()
        {
            return new AppDataBase.CentrosData().GetCentros();
        }
    }
}
