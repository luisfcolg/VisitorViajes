using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorViajes.Visitor
{
    public interface Usuario
    {
        void Aceptar(Visitor visitor);
    }
}
