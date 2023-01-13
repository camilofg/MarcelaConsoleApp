using System;
using System.Diagnostics;

namespace ConsoleAppMarcela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero:");
            var primerNumero = Console.ReadLine();
            var numero1 = int.Parse(primerNumero);
            Console.WriteLine("Ingrese segundo numero:");
            var segundoNumero = Console.ReadLine();
            var numero2 = int.Parse(segundoNumero);

            var invJugos = new InventarioJugos();
            var resultInvJugos = invJugos.InvDisponible(numero1, numero2);

            Console.WriteLine($"Existe inventario de jugos: {resultInvJugos}");

            var invHelados = new InventarioHelados();
            var resultInvHelados = invHelados.InvDisponible(numero1, numero2);

            Console.WriteLine($"Existe inventario de Helados: {resultInvHelados}");

            Console.WriteLine("ingrese operacion");
            var operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine(Sumar(numero1, numero2));
                    break;
                case "-":
                    Console.WriteLine(Restar(numero1, numero2));
                    break;
                case "*":
                    Console.WriteLine(Multiplicar(numero1, numero2));
                    break;
                case "/":
                    Console.WriteLine(Dividir(numero1, numero2));
                    break;
                default:
                    Console.WriteLine("operacion errada");
                    break;
            }
        }

        public static int Sumar(int primerNumero, int segundoNumero)
        {
            var resultado = primerNumero + segundoNumero;
            return resultado;
        }

        public static int Restar(int primerNumero, int segundoNumero)
        {
            var resultado = primerNumero - segundoNumero;
            return resultado;
        }

        public static int Multiplicar(int primerNumero, int segundoNumero)
        {
            var resultado = primerNumero * segundoNumero;
            return resultado;
        }
        public static int Dividir(int primerNumero, int segundoNumero)
        {
            var resultado = primerNumero / segundoNumero;
            return resultado;
        }
    }
}