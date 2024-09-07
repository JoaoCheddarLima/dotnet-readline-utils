using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.utils
{
    internal class Utils
    {

        public static void clear()
        {
            Console.Clear();
        }
        private static bool isValidOptionInRange(int userSelectedValue, int min, int max)
        {
            return userSelectedValue >= min && userSelectedValue <= max;
        }

        public static void writePad(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
        }

        public static void write(string text)
        {
            Console.WriteLine(text);
        }

        public static string question(string questionLabel)
        {
            writePad(questionLabel);
        
            string response = Console.ReadLine();

            return response;
        }

        public static void invalidNumberWarning()
        {
            Console.WriteLine("[AVISO] Número inválido, tente novamente.");
        }
        public static int getNumber(string questionLabel)
        {
            writePad(questionLabel);
            try
            {
            int response = Convert.ToInt16(Console.ReadLine()) ;

            return response;
            }catch (Exception ex)
            {
                clear();
                invalidNumberWarning();
                return getNumber(questionLabel);
            }

        }

        public static int getNumberInRange(string questionLabel, int min, int max)
        {
            writePad(questionLabel);
            try
            {
                int response = Convert.ToInt16(Console.ReadLine());

                if (!isValidOptionInRange(response, min, max)) throw new Exception("Invalid option range");

                return response;
            }
            catch (Exception ex)
            {
                clear();
                invalidNumberWarning();
                return getNumber("O valor deve estar entre " + min + " e " + max + " " + questionLabel);
            }
        }
    }
}
