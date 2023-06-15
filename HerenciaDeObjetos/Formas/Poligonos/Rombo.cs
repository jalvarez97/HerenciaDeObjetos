
namespace HerenciaDeObjetos.Formas.Poligonos
{
    internal class Rombo : Poligono
    {
        int DiagonalMayor { get; set; }
        int DiagonalMenor { get; set; }
        int Lado1 { get; set; }
        int Lado2 { get; set; }

        public Rombo(int diagonalMayor, int diagonalMenor
                   , int lado1, int lado2) : base(4, "Rombo")
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public override double Area()
        {
            return DiagonalMayor * DiagonalMenor / 2;
        }

        public override double Perimetro()
        {
            return (Lado1 * 2) + (Lado2 * 2);
        }
    }
}
