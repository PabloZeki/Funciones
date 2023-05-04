using System;

namespace ejemplofunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // ACA VA EL CODIGO...
            // FUNCIONES
            // PARTES DE LA FUNCION
            // CABECERA
            // 1. TIPO DE DATO
            // 2. NOMBRE
            // 3. Opcional: PARAMETROS
            // CUERPO
            // DEFINICION/LOGICA
            // Opcional: retorno de valor/resultado

          // int nro = devolverUno();

          //  Console.WriteLine("Fin del programa: " + devolverUno());

          int n1=0,n2=0, resultado;

          PedirDatos(ref n1 ,ref n2);      // llamada a la funcion

           //logica
           //resultado = n1 + n2;
           resultado = sumar(n1,n2);      // llamada a la funcion // aca si agrego (ref) se convierte en pasaje por referencia
           //fin logica
           Console.WriteLine("El resultado es: " +resultado);



        }
        static int devolverUno(){
            int nro = 15;
            return nro;
            

        }

        static int sumar(int a, int b){    // si agregamos (ref) antes de los int de main y de la funcion se convierte en pasaje
                                           // por refencia,a la misma direccion de memoria,que los valores se pueden pisar
            int r;
            r = a + b;               // ejemplo de pasaje por valor (copia en memoria de los valores de la funcion)
            return r;
        }
        
        static void PedirDatos(ref int j,ref int h){
        Console.WriteLine("Ingrese un numero: ");
          j = int.Parse(Console.ReadLine());            // aca le mando por ref para que guarde los datos en n1 y n2 
           Console.WriteLine("Ingrese otro numero: ");
           h = int.Parse(Console.ReadLine());

        }

    }
}
