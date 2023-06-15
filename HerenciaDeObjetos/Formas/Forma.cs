
namespace HerenciaDeObjetos.Formas
{
    public class Forma
    {
        public string Nombre { get; set; }

        
        public Forma(string sNombre) 
        { 
            Nombre = sNombre;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }
    }
}
