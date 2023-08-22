using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio1
{
    internal class MainApp
    {
        public static void Main()
        {

            Cuenta persona1 = new Cuenta("Paco", 4.5);

            persona1.toString();

            persona1.Ingresar(25.6);
            persona1.getCantidad();

            persona1.Retirar(3);
            persona1.getCantidad();

            persona1.Retirar(50);
            persona1.getCantidad();
        }
    }
}
