

using System.Security.Cryptography.X509Certificates;

namespace Estructuras_2027_I
{
    internal struct Cliente
    {
        internal string nombre;
        internal byte edad;
        internal string correo;

        public Cliente()
        {

        }
        public Cliente(string nombre, byte edad, string correo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;

        }

       
    }
}
