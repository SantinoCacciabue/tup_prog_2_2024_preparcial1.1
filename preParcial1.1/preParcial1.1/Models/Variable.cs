using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preParcial1._1.Models
{
    internal class Variable : Costo
    {
        public double PrecioPorUnidad {  get; private set; }
        public int Unidades {  get; private set; }
        public override double ValorFinal
        {
            get
            {
                return PrecioPorUnidad * Unidades;
            }
        }
        public Variable(string concepto, double precioPorUnidad, int unidades): base(concepto)
        {
            PrecioPorUnidad = precioPorUnidad;
            Unidades = unidades;
        }
        public override string VerDetalle()
        {
            return $"{Concepto}({PrecioPorUnidad}x{Unidades}) {ValorFinal}";
        }
    }
}
