using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularArea
{
    public class Circulo : FormasGeometricas
    {

        private double _raio;
        public double Raio
        {
            get
            { return _raio; }
            set
            { _raio = value; }
        }

        public override void CalcularArea()
        {
            this.Area = 3.14f * 2 * _raio;
        }

        public override void CalcularPerimetro() 
        {
            this.Perimetro = _raio * _raio * 3.14f;
        }

    }
}