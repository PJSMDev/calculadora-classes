using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_Calculadora_v02_ComClasses
{
    internal class Calculator
    {
        public string[] menu =      // o menu da calculadora não devia estar na calculadora -> Utility da Calculadora
        {
            "+  Soma",
            "-  Subtração",
            "*  Multiplicação",
            "/  Divisão"
        };

        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Result { get; set; }
        public string Operator { get; set; }


        public void DisplayMenu() 
        {
            Utility.WriteTitle("Calculadora com classes");
            foreach (string item in menu)
            {
                Utility.WriteMessage(item, "", "\n");
            }
        }

        public void ReadValues() 
        {
            Utility.WriteMessage("Value 1: ");
            Value1 = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Operation: ");
            Operator = Console.ReadLine();

            Utility.WriteMessage("Value 2: ");
            Value2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculation()
        {
            switch (Operator) 
            {
                case "+":
                    Add();
                    break;
                case "-":
                    Sub();
                    break;
                case "*":
                    Mult();
                    break;
                case "/":
                    Div();
                    break;
                default:
                    Invalid();
                    break;
            }
        }

        public void Add()
        {
            Result = Value1 + Value2;
        }

        public void Sub()
        {
            Result = Value1 - Value2;
        }

        public void Mult() 
        { 
            Result = Value1 * Value2; 
        }

        public void Div()
        {
            Result = Value1 / Value2;
        }

        public void Impossible()
        {
            Utility.WriteMessage("Impossível", "", "\n");
        }

        public void Invalid()
        {
            Utility.WriteMessage("Operação inválida", "", "\n");
        }

        public void PrintResult()
        {
            if (Value2 == 0 && Operator == "/")
            {
                Impossible();
            }
            else
            {
                Utility.WriteMessage($"{Value1} {Operator} {Value2} = {Result}");
            }
        }
    }
}
