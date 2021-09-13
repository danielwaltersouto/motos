using System;
using System.Collections.Generic;
using System.Text;

namespace motos
{
    class Enduro : MotoConstructor
    {

        Chasis chasis = new Chasis();
        Motor motor = new Motor();
        Rueda rueda = new Rueda();


        public override void ColocarChasis()
        {
           
            this.chasis.Material = "aluminio";

        }

        public override void ColocarMotor()
        {
          
            this.motor.Cilindrada = 250;
        }

        public override void ColocarRueda()
        {
         
            this.rueda.Radio = 22;
        }

        public override void MostrarProducto()
        {
            Moto moto = new Moto(rueda,motor,chasis);
        }
    }
}