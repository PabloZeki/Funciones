using System;
//2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
//Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.



namespace ejercicio2
{
    

    class Program
    {

     static void Main(string[] args)
    {
        int Numero=0,cont;
        const int VUELTAS = 20;
        bool Ban = false;

            cont = 0;
        for (int i = 0; i < VUELTAS; i++)
        {
            Pedirdatos(ref Numero);

            Ban = Par(Numero);

            if(Ban){

                cont++;
            }
        }
        
        Console.WriteLine("La cantidad de numeros pares es de: " + cont);



        
  } 
    static bool Par(int j){


     if(j%2==0){

        return true;
     }else
     {
        return false;
     }

    }
    static void Pedirdatos(ref int j){

    Console.WriteLine("Ingrese numeros por favor: ");
    j = int.Parse(Console.ReadLine());

    }



 }
}