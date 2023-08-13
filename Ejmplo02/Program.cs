using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejmplo02
{
    class Program
    {
        Dictionary<int, string> DASCII;
        string msg = "";
        int[] CadASII;
        static void Main(string[] args)
        {
            string Entrada;
            string CadSalida = string.Empty;

            Console.WriteLine("Inserte la cadena...");
            Entrada = Console.ReadLine();
            Console.WriteLine("");

            Program met = new Program();
            met.IniciaDiccionario();
            if (met.ValidaCadena(Entrada) == true)
            {
                foreach (int item in met.CadASII)
                {
                    CadSalida += met.getCharASCII(item);
                }

                Console.WriteLine("El mensaje resuelto es:");
                Console.WriteLine(CadSalida);
            }

                Console.ReadKey();
        }

        public void IniciaDiccionario()
        {
            DASCII = new Dictionary<int, string>()
            {
                {32, " "},
                {36, "$"},
                {37, "%"},
                {38, "&"},
                {40, "("},
                {41, ")"},
                {47, "/"},
                {64, "@"},
                {65, "A"},
                {66, "B"},
                {67, "C"},
                {68, "D"},
                {69, "E"},
                {70, "F"},
                {71, "G"},
                {72, "H"},
                {73, "I"},
                {74, "J"},
                {75, "K"},
                {76, "L"},
                {77, "M"},
                {78, "N"},
                {79, "O"},
                {80, "P"},
                {81, "Q"},
                {82, "R"},
                {83, "S"},
                {84, "T"},
                {85, "U"},
                {86, "V"},
                {87, "W"},
                {88, "X"},
                {89, "Y"},
                {90, "Z"},
                {97, "a"},
                {98, "b"},
                {99, "c"},
                {100, "d"},
                {101, "e"},
                {102, "f"},
                {103, "g"},
                {104, "h"},
                {105, "i"},
                {106, "j"},
                {107, "k"},
                {108, "l"},
                {109, "m"},
                {110, "n"},
                {111, "o"},
                {112, "p"},
                {113, "q"},
                {114, "r"},
                {115, "s"},
                {116, "t"},
                {117, "u"},
                {118, "v"},
                {119, "w"},
                {120, "x"},
                {121, "y"},
                {122, "z"}
            };
        }

        public bool ValidaCadena(string Cad)
        {
            int Cont = 0;
            string[] Splient;
            int salida = 0;
            try
            {
                Splient = Cad.Split(' ');
                CadASII = new int[Splient.Length];

                foreach (string item in Splient)
                {
                    if(!int.TryParse(item, out salida))
                    { msg = $"El valor [{item}] no es un número."; Console.WriteLine(msg); return false; }

                    if(item.Length < 2 || item.Length > 3)
                    { msg = $"El valor [{item}] no es valido (Cantidad de caracteres por código 2 o 3)."; Console.WriteLine(msg); return false; }

                    CadASII[Cont] = Convert.ToInt32(item);
                    Cont += 1;
                }

                msg = "";
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string getCharASCII(int vASCII)
        {
            try
            {
                string itm = DASCII[vASCII];
                if (!string.IsNullOrEmpty(itm))
                    return itm;
                else
                    return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
