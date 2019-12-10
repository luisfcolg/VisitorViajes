using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorViajes.Visitor
{
    public class UsuarioCasual : Usuario
    {
        public double Kilometros { get; set; }

        public void Aceptar(Visitor visitor)
        {
            visitor.CalcularCosto(this);
        }
    }
}
