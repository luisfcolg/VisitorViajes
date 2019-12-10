using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorViajes.Visitor
{
    class CostoVisitor : Visitor
    {
        public void CalcularCosto(UsuarioCasual casual)
        {
            double costo = casual.Kilometros * 150;
            Console.WriteLine($"Colsto total: {costo}");
            Console.WriteLine($"Puntos premia generados: 0");
        }

        public void CalcularCosto(UsuarioPremium premium)
        {
            double costo = premium.Kilometros * 150;
            Console.WriteLine($"Colsto total: {costo*0.9}");
            Console.WriteLine($"Puntos premia generados: {(int)(costo / 500) * 50}");
        }

        public void CalcularCosto(UsuarioAgenciaViajes agenciaViajes)
        {
            double costo = agenciaViajes.Kilometros * 150;
            Console.WriteLine($"Colsto total: {costo * 0.85}");
            Console.WriteLine($"Puntos premia generados: {(int)(costo / 500) * 100}");
        }
    }
}
