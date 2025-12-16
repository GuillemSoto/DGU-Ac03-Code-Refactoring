namespace Refactor
{
    public class Program //class Program & static void Main -> public, since you cannot test otherwise
    {
        public static void Main(string[] args)
        {
            //unusedVar simplement no es feia servir al programa i només ocupava espai.
            const string WelcomeMsg = "Benvingut al programa de càlculs!";
            const string EndingMsg = "Finalitzant el programa...";
            Console.WriteLine(WelcomeMsg);
            //Console.WriteLine("Benvingut al programa de càlculs!"); i Console.WriteLine("Finalitzant el programa..."); estaven duplicats i a més tots els missatges estàn posats com a literals en comptes de com a constants.

            //Hem de posar noms descriptius a les variables
            int firstNum = 5;
            int secondNum = 10;
            int thirdNum = 15;
            int result = 0;
            CalculateResult(ref firstNum, ref secondNum, ref thirdNum, out result);
            //El programa tenia codi que no estava fent res, així que l'hem esborrat.

            
            Console.WriteLine(EndingMsg);
        }
        public static void CalculateResult(ref int firstNum, ref int secondNum, ref int thirdNum, out int result)
        {
            if (firstNum <= 0)
            {
                result = 0;
            }
            else if(secondNum <= 0)
            {
                result = firstNum;
            }
            else if(thirdNum <= 0)
            {
                result = firstNum + secondNum;
            }
            else
            {
                result = firstNum + secondNum + thirdNum;
            }
            PrintResult(result);
            //Hi havia una cadena d'if//else estranya que funcionaba però no era correcta
        }
        public static void PrintResult(int result)
        {
            const string PositiveMsg = "El resultat és positiu.";
            const string ZeroMsg = "El resultat és zero.";

            // Eliminem switch + default (branca morta)
            if (result == 0)
            {
                Console.Write(ZeroMsg);
            }
            else
            {
                Console.Write(PositiveMsg);
            }
        }

    }
}
