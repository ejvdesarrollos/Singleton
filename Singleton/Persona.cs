using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Persona
    {
        private static Persona instancia = null;

        public string texto;

        protected Persona()
        {
            this.texto = "Hola mundo";
        }
        public static Persona Instancia
        {
            get
            {
                if(instancia == null)
                    instancia = new Persona();
                return instancia;
            }
        }

    }
}
