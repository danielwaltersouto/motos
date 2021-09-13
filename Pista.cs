using System;
using System.Collections.Generic;
using System.Text;

namespace motos
{
    class Pista : MotoConstructor
    {
        Chasis chasis = new Chasis();
        Motor motor = new Motor();
        Rueda rueda = new Rueda();

        public override void ColocarChasis()
        {
          
            this.chasis.Material = "carbono";

        }

        public override void ColocarMotor()
        {
           
            this.motor.Cilindrada = 900;
        }

        public override void ColocarRueda()
        {
            this.rueda.Radio = 19;
        }
        public override void MostrarProducto()
        {
            Moto moto = new Moto(rueda, motor, chasis);
        }
    }
}