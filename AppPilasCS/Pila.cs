using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPilasCS
{
    class Pila  //FILO 
    {
        Contacto top; //falta agregar las clases contacto y persona para que jale

        public Pila() //inicializar la pila
        {
            top = null;
        }

        public void Push(Contacto n)//void porque no regresa nada
        {
            if (top == null)
            {
                top = n;
                return;
            }
            //para ir insertando datos desde top y asi continuamente (push)
            n.Siguiente = top;
            top = n;
        }
        public Contacto Pop() //Contacto porque es una pila de contacto
        {
            if (top != null)
            {
                Contacto c = top;  //lo que esta en top es lo que quiero regresar
                top = top.Siguiente; //para que se mueva el top
                return c;
            }
            return top;
        }
    }
}
