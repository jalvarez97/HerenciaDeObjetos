
using System;

namespace HerenciaDeObjetos.Formas.Circulo
{
    internal class Circulo : Forma
    {
        int Radio { get; set; }

        public Circulo(int nRadio) : base ("Circulo")
        {
            Radio = nRadio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Perimetro()
        {
            return Math.PI * (Radio * 2);
        }

    }
}
