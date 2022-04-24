//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

//Aplica expert porque se mantiene el encapsulamiento y cumple el patron rsp porque solo hay una causa para poder modificarla

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    
    
        public double getStepCost(){

           return(this.Input.UnitCost * this.Quantity) + (this.Equipment.HourlyCost * this.Time);

        }

    }


}