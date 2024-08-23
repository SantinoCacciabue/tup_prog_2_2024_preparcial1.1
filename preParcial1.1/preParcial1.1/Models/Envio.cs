using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preParcial1._1.Models
{
    internal class Envio
    {
        ArrayList costos = new ArrayList();
        public double ValorTotal
        {
            get
            {
                double acum = 0;
                foreach( Costo c  in costos)
                {
                    acum += c.ValorFinal;

                }
                return acum;
            }
        }
        public string VerDetalle()
        {
            string ret = null;
            foreach( Costo c in costos)
            {
                ret += c.VerDetalle();
            }
            return ret;
        }
        public void AgregarCosto(Costo c)
        {
            costos.Add(c);
        }

    }
}
