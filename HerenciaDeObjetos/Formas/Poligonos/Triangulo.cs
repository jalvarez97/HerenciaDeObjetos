
namespace HerenciaDeObjetos.Formas.Poligonos
{
    public class Triangulo : Poligono
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public Triangulo(int nBase, int nAltura, int lado1, int lado2) : base(3, "Triangulo")
        {
            Base = nBase;
            Altura = nAltura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double Area()
        {
            return Base * Altura / 2;
        }

        public override double Perimetro()
        {
            return Lado1 + Lado2 + Base;
        }
    }
}
