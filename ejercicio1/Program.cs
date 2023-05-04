using System;

//1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
//Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto 
//total a pagar. Usar la función.



namespace ejercicio1

{
     class Program
    {
       static void Main(string[] args)
        {
          int Precio=0,CanVendida=0,MontoTotal;

          PedirDatos(ref CanVendida,ref Precio);

         MontoTotal = Producto(CanVendida,Precio);

         Console.WriteLine("El monto total a abonar es: " +MontoTotal);
            
        }

        static int Producto(int n1,int n2){

            int r;
            r = n1 * n2;
            return r;
        }
        static void PedirDatos(ref int j,ref int k){
            
            Console.WriteLine("Ingrese la cantidad vendida por favor: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio de las ventas: ");
            k = int.Parse(Console.ReadLine());

        }



    }
}