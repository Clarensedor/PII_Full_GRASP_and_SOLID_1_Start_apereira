//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
      
      //Aplica patron expert sigue siendo la experta en la clase y se mantiene el encapsulamiento y aplica srp aunque le puse otro metodo sigue Printrecipe teninedo la responsivilidad de imprimir cosas.
      //Por lo tanto hay solo un motivo por el cual la clase pueda ser modificada.

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }        

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
                               
            }
            Console.WriteLine(this.GetProductionCost());
        }
  
        public double GetProductionCost(){

            double total = 0;
            foreach (Step step in this.steps){
                total += step.getStepCost();
            }
            return total;
        }

    }
}