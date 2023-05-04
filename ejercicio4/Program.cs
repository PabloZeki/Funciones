using System;
//4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba 
//un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por 
//referencia con:

//a. 1 si el número es positivo.
//b. -1 si el número es negativo.
//c. 0 si el número es cero.

namespace ejercicio4
{

     class Program
    {
        static void Main(string[] args)
        {
         int Numero=0,Aux=0;
         

         PedirDatos(ref Numero);

         PositivoNegativoCero(Numero,ref Aux);

         if(Aux==0){

            Console.WriteLine("El numero ingresado es cero");

         } else if (Aux == 1){

            Console.WriteLine("El numero ingresado es Positivo");

         }else
         {

            Console.WriteLine("El numero ingresado Negativo");
         }
        

        
        }
        static void PositivoNegativoCero(int j,ref int k){

            if (j==0)
            {
                k=0;
                
            } else if (j > 0){

                k = 1;
            } else
            {
                k = -1;
            }
            


        }

        static void PedirDatos (ref int j){

            Console.WriteLine("Ingrese un numero por favor: ");
            j = int.Parse(Console.ReadLine());
        }



     }     
       
}       