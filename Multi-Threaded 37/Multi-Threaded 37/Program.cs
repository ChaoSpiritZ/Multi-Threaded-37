using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threaded_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- simple calculator only:

            //SimpleCalculator calc = new SimpleCalculator();
            //int num1 = calc.NumberGetter();
            //int num2 = calc.NumberGetter();
            //calc.PrintMenu();
            //int oper = calc.GetUserChoice();
            //calc.PrintResultNicely(calc.Calculate(num1, num2, oper));

            // -- with delegates:
            SimpleCalculator sCalc = new SimpleCalculator();
            AtomicCalculator aCalc = new AtomicCalculator();
            aCalc.GetNumberFromUser = sCalc.NumberGetter;
            aCalc.MenuPrinter = sCalc.PrintMenu;
            aCalc.GetUserChoice = sCalc.GetUserChoice;
            aCalc.Calculate = sCalc.Calculate;
            aCalc.ResultPrinter = sCalc.PrintResultNicely;
            aCalc.Run();
        }
    }
}
