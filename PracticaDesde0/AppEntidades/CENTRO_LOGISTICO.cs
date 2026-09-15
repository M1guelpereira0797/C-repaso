using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppEntidades
{
    public class CENTRO_LOGISTICO
    {
        public int CENTRO_LOGISTO_ID { get; set; }
        public string NOMBRE_CENTRO { get; set; }   
   
    

    public CENTRO_LOGISTICO(int centroLogistico, string nombreCentro)
    {
       CENTRO_LOGISTO_ID = centroLogistico;
       NOMBRE_CENTRO = nombreCentro;
    }

     public  CENTRO_LOGISTICO() { }
    }
}
