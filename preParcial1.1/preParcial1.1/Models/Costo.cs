using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preParcial1._1.Models
{
    abstract class Costo
    {
        public string Concepto { get; private set; }
        public virtual double ValorFinal {  get;set; }
        public Costo(string concepto)
        {
            Concepto = concepto;
        }
        public abstract string VerDetalle();
    }
}
