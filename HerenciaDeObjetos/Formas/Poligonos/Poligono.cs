
namespace HerenciaDeObjetos.Formas.Poligonos
{
    public class Poligono : Forma
    {
        public int Lados { get; set; }


        public Poligono(int nLados, string nNombre) : base (nNombre)
        {
            Lados = nLados;
        }  
    }
}
