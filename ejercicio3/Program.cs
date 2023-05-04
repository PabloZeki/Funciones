using System;
//3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero 
//si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
//Informar el promedio teniendo en cuenta sólo los números primos.

namespace ejercicio3
{

    class Program
    {
     static void Main(string[] args)
    {
     int Numeros=0;
     float acu,cont,Promedio;
     bool Ban = false;
       

       cont = 0;
       acu = 0;
       Pedirdatos(ref Numeros);
        
       while(Numeros != 0){

       Ban = Primo(Numeros);

       if(Ban){
        acu+=Numeros;
        cont++;
       }

         Pedirdatos(ref Numeros);
       }
        Promedio = acu/cont;

        Console.WriteLine("El promedio de los numeros primos es de: " +Promedio);

        
    }

    static bool Primo(int j){
        int cont = 0;
        for (int i = 1; i <=j; i++)
        {
            if(j%i==0){

                cont++;
            }
        }
        if(cont==2){

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