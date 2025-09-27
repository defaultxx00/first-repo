using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercices
{
    public class ex1
    {
        public static void Main(string[] args)
        {
            //codigo principal
            string nome = "joao";

            Console.WriteLine("digita alguma palavra: ");
            string resposta = Console.ReadLine();
            Console.WriteLine(resposta);
            Console.WriteLine(nome);
            mostrarMensagem();
        }
        //metodo 1 - mostra a mensagem na tela
        static void mostrarMensagem()
        {
            Console.WriteLine("oi");
        }
        
        

    }
}