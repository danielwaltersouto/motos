using System;
using System.Collections.Generic;
using System.Text;

namespace motos
{
     class Fabrica
    {

       

        public void Fabricar(MotoConstructor motoConstructor)
        {

            motoConstructor.ColocarChasis();
            motoConstructor.ColocarMotor();
            motoConstructor.ColocarRueda();

            motoConstructor.MostrarProducto();


        }
    }
}