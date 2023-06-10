using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11XamarinOpe.Models
{
    public class CalculatorModel
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public int Result { get; set; }

        public void Add()
        {
            Result = Operand1 + Operand2;
        }

        public void Subtract()
        {
            Result = Operand1 - Operand2;
        }

        public void Multiply()
        {
            Result = Operand1 * Operand2;
        }

        public void Divide()
        {
            if (Operand2 != 0)
                Result = Operand1 / Operand2;
            else
                Result = 0; // Manejo del error de división por cero
        }
    }
}