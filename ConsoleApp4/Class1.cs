using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Almacen<T>
    {
        private T _item;

        public void Guardar(T nuevoItem)
        {
            _item = nuevoItem;
            Console.WriteLine($"Item guardado: {_item}");
        }
        public T Obtener()
        {
            return _item;
        } //T != 'any'


    }
    
    public class Utilidades
    {
        public static void Intercambiar<T>(ref T a, ref  T b)
        {
            //T temp = a
            //a = b
            // b = temp
            a = b;
            b = a;

        }
    }

    public delegate T Operacion<T>(T valor1, T valor2);

    public class Calculadora
    {
        public static int Sumar(int a, int b) => a + b;
        public static string Concatenar(string a, string b) => a + " " + b;
    }
}
    public class Program

    {
        static void Main()
    {
        Ejemplo1();
        Ejemplo2();
        Ejemplo3();

    }

    static void Ejemplo1()
    {
        Almacen<int> almacenEnteros = new();
        almacenEnteros.Guardar(2);
        Console.WriteLine($"Item recuperado: {almacenEnteros.Obtener()}");
        
        Almacen<int> almacentxt = new();
        almacenEnteros.Guardar(2);
        Console.WriteLine($"Item recuperado: {almacentxt.Obtener()}");

    }

    static void Ejemplo2()
    {
        int x = 10;
        int y = 20;

        Console.WriteLine($"Antes de intercambiar: x = {x}, y = {y}");
        Console.WriteLine($"Antes de intercambiar: x = {y}, y = {x}");

    }
    static void Ejemplo3()
    {
        Operacion<int> operacionSuma = Calculadora.Sumar;
        Console.WriteLine($"Suma de enteros: {operacionSuma(5, 11)}");
        
        Operacion<string> operacionConcatenar = Calculadora.Concatenar;
        Console.WriteLine($"Suma de enteros: {operacionConcatenar("sans", "undertale")}");



    }

}

