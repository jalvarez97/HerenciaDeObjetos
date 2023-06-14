
namespace HerenciaDeObjetos.Formas.Poligonos
{
    public class Triangulo : Poligono
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo(int nBase, int nAltura) : base(3)
        {
            Base = nBase;
            Altura = nAltura;
        }

        public override double Area()
        {
            return Base * Altura / 2;
        }
    }
}
