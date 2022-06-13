using System;
using System.Globalization;

namespace Course_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formatar: ToLower(), ToUpper(), Trim()
            // Buscar: IndexOf, LastIndexOf
            // Recortar: Substring(inicio), Substring(inicio, tamanho)
            // Substituir: Replace(char,char), Replace(string, string)
            // String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str)
            // str.Split('') - serve para recortar uma string com base em uma caracter
            // Conversão para numero: int x = int.Parse(str), int x = Convert.ToInt32(str)
            // Conversão de numero: str = x.ToString(), str = x.ToString("c"), str = x.ToString("c3"), str = x.ToString("F2")
                        

            //funções de uso do string

            string original = "abcde FGHIJ ABC abc DEFG";

            
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            // verificar se a string null (vazia)
            bool b1 = String.IsNullOrEmpty(original);

            // verificar se a string null e com espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Orignal: " + original);
            Console.WriteLine("ToUpper: " + s1 + "-");
            Console.WriteLine("ToLower: " + s2 + "-");
            Console.WriteLine("Trim: " + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine("Replace('a', 'x'): " + s6);
            Console.WriteLine("Replace('abc', 'xy'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);




        }

    }

}

