using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preParcial1._1.Models
{
    internal class Fijo : Costo
    {
        
        public Fijo(string concepto, double valorFinal) : base(concepto)
        {
            ValorFinal = valorFinal;
        }
        public override string VerDetalle()
        {
            return $"{Concepto} {ValorFinal}";
        }
    }
}
