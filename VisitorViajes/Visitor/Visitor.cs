using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorViajes.Visitor
{
    public interface Visitor
    {
        void CalcularCosto(UsuarioCasual casual);
        void CalcularCosto(UsuarioPremium premium);
        void CalcularCosto(UsuarioAgenciaViajes agenciaViajes);
    }
}
