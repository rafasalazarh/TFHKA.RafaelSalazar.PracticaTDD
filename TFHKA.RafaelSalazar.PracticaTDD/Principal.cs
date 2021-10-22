using System;
using TFHKA.RafaelSalazar.PracticaTDDLibrary;

namespace TFHKA.RafaelSalazar.PracticaTDD
{
    class Principal
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un número: ");
                var input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba otro número: ");
                var input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(PracticaTDDL.GetBigger(input1, input2));

                Console.WriteLine("La suma es: " + PracticaTDDL.GetSum(input1, input2));

                Console.WriteLine("La resta es: " + PracticaTDDL.GetSubstraction(input1, input2));

                Console.WriteLine("La multiplicación es: " + PracticaTDDL.GetMultiply(input1, input2));

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al ingresar la información, inténtelo nuevamente.");
            }
            
        }
    }
}
