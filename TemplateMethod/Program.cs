using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Non_DP;
using TemplateMethod.DP;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //NonDPProgram();
            DPProgram();
            Console.Read();
        }

        private static void NonDPProgram()
        {
            Console.WriteLine("---------------------------------------------------\n" +
                              "            Non-Template Method Program            \n" +
                              "---------------------------------------------------");
            new Athlete().DoRoutine();
            new FastFoodWorker().DoRoutine();
            new Musician().DoRoutine();
            new Police().DoRoutine();
            new Programmer().DoRoutine();
            new Teacher().DoRoutine();
        }

        private static void DPProgram()
        {
            Console.WriteLine("---------------------------------------------------\n" +
                              "              Template Method Program              \n" +
                              "---------------------------------------------------");
            new Athlete2().DoRoutine();
            new FastFoodWorker2().DoRoutine();
            new Musician2().DoRoutine();
            new Police2().DoRoutine();
            new Programmer2().DoRoutine();
            new Teacher2().DoRoutine();
        }
    }
}
