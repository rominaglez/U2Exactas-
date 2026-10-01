using System;
namespace CS5
{
    class Program
    {
        static void Main(string[]args)
        {
            //Unidad 1: Estructuras de control II 
            //Unidad 2: Funciones II
            //Sesion 12: Instruccion while 30/09/2026

            //Sintaxis: while
            // inicializacion 
            // while(expresion)
            //{
            //         //bloque de intrucciones
            //          iterador; 
            //}
            // Iterar: repetir o terminar ciclo 
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; //inicializacion 
            while(m<=3)//expresion 
            {
                //Bloque de instrucciones 
                m+= 1; //iterador 
                Console.WriteLine($"m: {m}"); 
            }
                //EJERCITACION 1: 
                //1. Definir un ciclo para imprimir tu nombre 5 veces 
                //Nota: para la expresion utilizar el operador <.
                //a. Ciclo ascendente
                int n = 0;
                while(n < 5)
                {
                    Console.WriteLine($"Nombre: Romina "); 
                    n += 1; //iterador 
                } 
                //EJERCITACION 2:
                //b. Ciclo descendente
                int a = 3; 
                while(a >= 1)
            {
                Console.WriteLine($"a: {a}");
                a -= 1; 
            }
            //c. Incrementos (ciclo ascendente)
            //Secuencia: 3 6 9 12 15 18 
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i:{i}");
                i += 3;
            }
            //d. Decrementos
            //EJERCITACION 
            //1.Definir un ciclo para imprimir "331" 8 veces
            //Nota: define un ciclo descendente con decrementos de 2 unidades
            int s = 16;
                while(s > 0)
                {
                    Console.WriteLine(" 331 "); 
                    s -= 2; //iterador 
                } 



    
               
                
            

        }
    }
}
