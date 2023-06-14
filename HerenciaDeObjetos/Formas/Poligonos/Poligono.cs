
namespace HerenciaDeObjetos.Formas.Poligonos
{
    public class Poligono : Forma
    {
        public int Lados { get; set; }

        public Poligono(int nLados) : base ("Poligono")
        {
            Lados = nLados;
        }  
    }
}
