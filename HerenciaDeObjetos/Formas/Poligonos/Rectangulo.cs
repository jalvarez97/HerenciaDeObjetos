
namespace HerenciaDeObjetos.Formas.Poligonos
{
    public class Rectangulo : Poligono
    {
        public int Base { get; set; }
        public int Altura { get; set; } 

        public Rectangulo(int nBase, int nAltura) : base(4,"Rectangulo")
        { 
            Base = nBase;
            Altura = nAltura;  
        }

        public Rectangulo(int nBase) : base(4, "Cuadrado")
        {
            Base = nBase;
            Altura = nBase;
        }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return (Altura * 2) + (Base * 2);
        }

    }
}
