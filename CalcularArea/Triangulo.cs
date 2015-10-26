using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularArea
{
    public class Triangulo : FormasGeometricas
    {

        private double _lado;
        public double Lado
        {
            get
            { return _lado; }
            set
            { _lado = value; }
        }

        public override void CalcularArea()
        {
            this.Area = _lado * _lado/2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * _lado;
        }


    }
}