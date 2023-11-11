using System;
using System.Diagnostics.Contracts;

namespace ejercitacion
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio numero 1

//          int numero1, numero2,resultado;
        
//         Console.WriteLine("por favor inserte un numero");
        
//        numero1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("por favor inserte un segundo numero");

//        numero2 = int.Parse(Console.ReadLine());

//        resultado = numero1 + numero2;

//        Console.WriteLine("su resultado es: " + resultado);


            //Ejercicio numero 2

//        int numero1,resultado;

//    Console.WriteLine("por favor inserte un numero");

//   numero1 = int.Parse(Console.ReadLine());

//    resultado = numero1 * 2 ;

//    Console.WriteLine("su numero ingresado elevado al cubo da un resultado de " + resultado);

           //Ejercicio numero 3 

//        int distancia , velocidad, tiempo;

//        Console.WriteLine("Por favor coloque la distancia existente entre las dos ciudades que desea viajar");

//        distancia = int.Parse(Console.ReadLine());

//        Console.WriteLine("por favor coloque su velocidad de viaje promedio");

//        velocidad = int.Parse(Console.ReadLine());

//        tiempo = distancia/velocidad;

//        Console.WriteLine("usted va a tardar aproximadamente " + tiempo + " horas ");


            //Ejercicio numero 5

//            int nota1, nota2, nota3,promedio;

//            Console.WriteLine ("por favor escriba la primer nota");
//            nota1 = int.Parse(Console.ReadLine());

//            Console.WriteLine ("por favor escriba la segunda nota");
//            nota2 = int.Parse(Console.ReadLine());

//            Console.WriteLine ("por favor escriba la tercer nota");
//            nota3 = int.Parse(Console.ReadLine());

//           promedio = (nota1 + nota2 + nota3) / 3;

//           Console.WriteLine("su promedio es de " + promedio);

// ------------------------------------------o---------------------------------------------------------

            //ejercitacion con if / unidad 3 

//            int n1 , n2;
//            Console.WriteLine("por favor ingrese su edad");
//            n1 = int.Parse(Console.ReadLine());
//
//            n2 = 18;
//
//            if(n1>=n2) 
//                Console.WriteLine("felicitaciones eres mayor de edad");
//             else
//            
//                Console.WriteLine("eres menor de edad");


                //acumuladores y contadores:

 //               int contador = 0, edad1 = 20 , edad2 = 30 , edad3 = 40 ;
 //               int acumulador = 0;
 //               int promedio = 3;
                //contador = contador + 1 

//                if (edad1 >18)
//                    contador++
//                    acumulador+=edad1;
//                if (edad2 > 18)
//                    contador++;
//                    acumulador+=edad2;
//                if (edad3 > 18)
//                    contador++;
//                    acumulador+=edad3;
//                promedio = acumulador / promedio;
//               Console.WriteLine("El conteo es de : " + contador );
//                Console.WriteLine("El promedio es de : " + promedio);


            //Ejercicio 1 if unidad 3 

//        int num1 , resultado;

//        Console.WriteLine("por favor coloque un numero ");
//        num1= int.Parse(Console.ReadLine());

//        if (num1>18) {
//            Console.WriteLine("su numero es mayor a 10");
//        } else
//        {
//            Console.WriteLine("su numero es menor a 10");
//
//        }


            //Ejercicio 2 if unidad 3 

//            int num1 ;

//            Console.WriteLine("por favor escriba un numero");
//            num1 = int.Parse(Console.ReadLine());

//            if (num1>0) {
//                Console.WriteLine("su numero es mayor a 0 ");
//            } if (num1==0) {
//                Console.WriteLine("su numero es igual a 0");
//            } if (num1<0)
//            {
//                Console.WriteLine("su numero menor a 0");
//            }



              //Ejercicio 3 if unidad 3 

 //              float importe1 ;
 //              Console.WriteLine("por favor coloque su importe a gastar");
 //              importe1 = float.Parse(Console.ReadLine());

         

//               if (importe1 >= 1000) {
             
//               if (importe1 > 5000)
//                importe1 = importe1 * 0.82f;
//            else 
//                importe1 = importe1 * 0.90f;
               
//               }
            
//            Console.WriteLine("el importe a cobrar es de: " +importe1);



                 //   Ejercicio 4 

                //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

//                int contador = 0 , num1,num2,num3,num4, min ;
                

//                Console.WriteLine("por favor escriba un numero");
//                num1 = int.Parse(Console.ReadLine());

//                Console.WriteLine("por favor escriba un numero");
//               num2 = int.Parse(Console.ReadLine());

//                Console.WriteLine("por favor escriba un numero");
 //               num3 = int.Parse(Console.ReadLine());

 //               Console.WriteLine("por favor escriba un numero");
 //               num4 = int.Parse(Console.ReadLine());
 
 //               if(num1 < num2 ) 
 //                   min = num1;
 //               else 
 //                   min = num2;

 //               if(num3 < min )
 //                   min = num3;

  //              if(num4 < min)
  //                  min = num4;

  //              Console.WriteLine("el valor menor es " + min);

               // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

//                int num1,num2,num3,num4,mayor;
                

//               Console.WriteLine("por favor ingrese un numero");
//                num1 = int.Parse(Console.ReadLine());

//                 Console.WriteLine("por favor ingrese un numero");
//                num2 = int.Parse(Console.ReadLine());

//                 Console.WriteLine("por favor ingrese un numero");
//                num3 = int.Parse(Console.ReadLine());

//                 Console.WriteLine("por favor ingrese un numero");
//                num4 = int.Parse(Console.ReadLine());

//                if (num1>100)
//                Console.WriteLine("el numero " + num1 + " es mayor a 100");

//                if (num2>100)
//               Console.WriteLine("el numero " + num2 + " es mayor a 100");

//                if (num3>100)
//                Console.WriteLine("el numero " + num3 + " es mayor a 100");

//                if (num4 > 100)
//               Console.WriteLine("el numero " + num4 + " es mayor a 100");



                //Ejercicios Numero 4 condicionales

//                int num1 , num2 , resta , suma , producto;

//                Console.WriteLine("por favor ingrese un numero");
//                num1 = int.Parse(Console.ReadLine());

//                Console.WriteLine("Por favor ingrese otro numero");
//                num2= int.Parse(Console.ReadLine());
                
//                resta=num2-num1;
//                suma=num1+num2;
//                producto=num2*num1;

//                if (num1>num2) {
//                    Console.WriteLine("se cumplio la norma de resta " + " su resultado final es " + resta);

//                }

//                if(num1==num2) {
//                    Console.WriteLine("se cumplio la norma de suma" + " su resultado final es " + suma);
//                }

//                if(num1<num2) {
//                    Console.WriteLine("se cumplio la norma de producto" + " su resultado final es " + producto);
//                }
                
//                Console.WriteLine("fin del programa");


                //ejercicio numero 2

//               int litros, descuento10, descuento15,descuento25,precio,preciofinal ;

//                Console.WriteLine("por favor coloque la cantidad de litros comprados");
//               litros = int.Parse(Console.ReadLine());
//                precio = 200;
//                preciofinal = litros * 200; 
//                descuento10 = (litros * precio * 10) / 100;
 //               descuento15 = (litros * precio * 15) / 100;
//                descuento25 = (litros * precio * 25) / 100;
                
//                if (litros>101 && litros<300) {
//                    Console.WriteLine("Se aplica un descuento del 10% " + descuento10 );
//                }

//                if (litros>301 && litros<500) {
//                    Console.WriteLine("se aplica un descuento del 15% " + descuento15);
//                }
//                
//                if (litros>500 ) {
//                   Console.WriteLine("se aplica un descuento del 25% " + descuento25);
//                }
//                
//              if (litros <101 ) {
//               Console.WriteLine("no se aplica ningun descuento " + preciofinal);
//              }


                //Ejercicio numero 3

//                int ram, procesador ;

//                Console.WriteLine("por favor seleccione el procesador que desea " + " 1 = i5 " + " 2 = i7 " + " 3 + i9 ");
//                procesador = int.Parse (Console.ReadLine()); 
                
//                if (procesador == 1) {
//                    Console.WriteLine("usted selecciono un procesador i5");
//                }

//               if (procesador == 2) {
//                    Console.WriteLine("usted selecciono un procesador i7");
//                }
//
//                if (procesador == 3) {
//                    Console.WriteLine("usted selecciono un procesador i9");
//                }
//
//            Console.WriteLine("por favor selecione un memoria ram " + " 4= 8ram " + " 5=16ram " + " 6=32ram ");
//             ram= int.Parse (Console.ReadLine());
//
//             if (ram == 4) {
//                   Console.WriteLine("usted selecciono 8gb de memoria ram ");
//             }
//             if (ram== 5 ) {
//                 Console.WriteLine("usted selecciono 16gb de memoria ram");
//             }
//
//             if (ram== 6 ) {
//                  Console.WriteLine("usted selecciono 32gb de memoria ram");
//             }
//
//             if (procesador == 1 && ram == 4 ) {
 //               Console.WriteLine("usted debe abonar un total de 800usd");
//             }
//
//            if(procesador == 1 && ram == 5 ) {
//                Console.WriteLine("usted debe abonar un total de 900usd");
//            }
//
//           if(procesador == 1 && ram == 6 ) {
//                Console.WriteLine("usted debe abonar un total de 1200usd");
//            }
//
//            if(procesador == 2 && ram == 4 ) {
//                Console.WriteLine("usted debe abonar un total de 900usd");
//            }
//
//            if(procesador == 2 && ram == 5 ) {
//                Console.WriteLine("usted debe abonar un total de 1000usd");
//            }
//
//           if(procesador == 2 && ram == 6 ) {
//                Console.WriteLine("usted debe abonar un total de 1400usd");
//            }

//            if(procesador == 3 && ram == 4 ) {
//                Console.WriteLine("usted debe abonar un total de 12000usd");
//            }
//
//            if(procesador == 3 && ram == 5 ) {
//                Console.WriteLine("usted debe abonar un total de 1400usd");
//            }
//
//            if(procesador == 3 && ram == 6 ) {
//                Console.WriteLine("usted debe abonar un total de 2000usd");
//            }
//
//            if(procesador == 1 && ram == 5 ) {
//                Console.WriteLine("usted debe abonar un total de 900usd");
//            }


            //

//            int num1,num2,num3,suma,producto ;
//            Console.WriteLine("por favor escriba un numero");
//            num1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("por favor escriba otro numero");
//            num2 = int.Parse(Console.ReadLine());

//            Console.WriteLine("por favor ingrese el ultimo numero");
//            num3 = int.Parse(Console.ReadLine());

//            suma= num1 + num2 ;
//            producto = num2 * num3;

//            if (suma>producto) {
//                Console.WriteLine("la suma de los dos primeros numeros es mayor al producto del segundo y tercero");
//            } 
//            Console.WriteLine("fin del programa");
            
            //ejercicios tema 5 

            //ejericio numero 1



//        for (int x = 0; x < 11; x++)        {
//            Console.WriteLine(x);
//        }


            //ejercicio numero 2 
//        int num1 ,maximo = 0;

//            for (int x = 0; x < 10; x++)
//        {
//            Console.WriteLine ("por favor ingrese un numero");
//            num1 = int.Parse(Console.ReadLine());

//            if (x == 0)
//                maximo = num1;
//
//                else {
//                    if(num1 < maximo)
//                        maximo = num1;
//                }


//            Console.WriteLine("el maximo es:" + maximo);

//        }


            //Ejercicio numero 3

//            int edades, promedio, contador = 0 , acumulador = 0 ;
            
            

//            for (int x = 0; x < 20; x++)
//            {   
//                Console.WriteLine("por favor coloque su edad ");
//            edades = int.Parse(Console.ReadLine());
            
//                if (edades > 18)            

//                {
//                    acumulador += edades;
//                    contador ++;
//                 Console.WriteLine("las edades ingresadas mayores a 18 son  " + contador  + " : " + edades   );
                  
//                }
//                Console.WriteLine("el promedio de las edades mayores a 18 es de : " + acumulador/contador );
//            }

          

            //ejercicio numero 4 

            //  int num , contador=0 ;
            
      


            // Console.WriteLine("por favor escriba un numero");
            //     num = int.Parse(Console.ReadLine());

            //for (int x = 1; x <= num ; x++)
            //{
             //  if (num % x == 0 )
            //{
            //    contador ++ ;
            //}
            //  if (contador == 2) {
            //    Console.WriteLine("el numero ingresado es primo");
            //  }
           // }


            // Convinacion de ciclo 

            //for con for 
         //   int prom , acumulador  , n  ; 
         //   for (int x = 0; x < 20; x++)
         //   {
         //       acumulador = 0;
         //   for (int i = 0; i < 20 ; i++)
         //   {
         //       Console.WriteLine("ingrese la edad ");
         //       n = int.Parse(Console.ReadLine());
         //       acumulador += n ;
         //   } 
         //   prom = acumulador /20;
         //   Console.WriteLine("el promedio es igual a " + prom);


                   //programa para captar todos los pesajes de mercaderia de un mes massapaper

 //           int valor1 , resultado, contador , acumulador   ;

 //               Console.WriteLine("por favor coloque su 1 para inciar o 0 para salir ");
 //               valor1= int.Parse(Console.ReadLine());
 //               acumulador= 0;
 //               contador = 0;
            
 //           while (valor1 != 0)
 //           { 
 //               contador ++ ; 
                  
 //               Console.WriteLine("por favor coloque su valor de mercaderia ");
 //               valor1= int.Parse(Console.ReadLine());
 //               acumulador += valor1 ;
 //           }
  //              resultado = acumulador;
 //               Console.WriteLine("el total de mercaderia que compro el dia de hoy es de " + resultado + " kg " + contador);
  //      }


                //ejercicio numero 1 tema 6, ciclos convinados 

        //        int num = 0, contador = 0, primo, resultado   ;

        //        Console.WriteLine("ingrese 1 para acceder 0 para salir");

        //        for (int i = 0; i < 10; i++)
        //        {
                  
        //            contador++ ;
        //            Console.WriteLine("por favor escriba 10 numeros ");
        //            num = int.Parse(Console.ReadLine());
                    
        //        } 
                 
                
        //        if (num / num == 1 )
        //        {
                    
        //        for (int x = 0; x < contador; x++)
        //       {
        //            Console.WriteLine("LOS NUMEROS SON " + contador);
        //        }
        //        } 

      //    int num, contador = 0 , acumulador = 0 ;
            
      //    Console.WriteLine("por favor escriba un mnuero positivo para ingresar o negativo para salir");
      //    num = int.Parse(Console.ReadLine());

      //     while (num>=0)
      //   {
        
      //          Console.WriteLine("por favor escribir numeros para la lista ");
      //          num = int.Parse(Console.ReadLine());

              
                 
       
      //      while (num>=  0  )
      //      {
      //          acumulador=0 ;
      //          contador = 0 ;
      //           Console.WriteLine("por favor escribir numeros  ");
      //          num = int.Parse(Console.ReadLine());
      //          contador++;
      //          acumulador+= ;
      //      }
      //      Console.WriteLine("los numeros ingresados en la lista son de " + contador + acumulador);
      //      }


                  //unidad vectores ejercitacion

   //         int[] numeros = new int[10];
   //         for (int x = 0;  x < 10; x++)
   //         {
   //             Console.WriteLine("ingrese un numero");
   //             numeros[x] = int.Parse(Console.ReadLine());
   //         
   //        }

   //         int max = numeros[0];
   //         int pos = 1;
   //         int prom = pos + numeros / 10;

   //         for (int x = 0; x < 10; x++)
   //         {
   //          if(numeros[x] > max ) {
   //             max = numeros[x];
   //             pos = x + 1 ;

   //          }   

   //         }

   //         Console.WriteLine("el maximo es: " + max);
   //          Console.WriteLine("su posicion es: " + pos);
   //          Console.WriteLine("el promedio es: " + prom);    



  //           int[] numeros = new int[10];
  //           int promedio , acumulador = 0 ;
  //          for (int x = 0;  x < 10; x++)
  //          {
  //              Console.WriteLine("ingrese un numero");
  //              numeros[x] = int.Parse(Console.ReadLine());
  //          
  //          }
  //          

  //          for (int x = 0; x < 10; x++)
  //          {
  //         
  //              acumulador += numeros[x];
  //             
  //          }  
  //         promedio = acumulador / 10 ; 

        
   //          Console.WriteLine("el promedio es: " + promedio);   

   //          for (int x = 0; x < 10; x++)
   //          {
   //             if (numeros[x] > promedio ) {
   //                 Console.WriteLine("este numero es mayor al promedio " + numeros[x]);
   //             }
   //          }


   //      int n =   DevolverUno();
   //         Console.WriteLine("fin del programa " + n);
    //  }
      // componentes de una funcion: tipo de dato // nombre // parametros (opcional) // cuerpo // definicion logica // retorno de valor (opcional)
     // static int DevolverUno(){
     //   int numero = 1;
     //   return numero;
     

     // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
     // Luego hacer un programa que pida el precio de un artículo 
     // y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
      


  //  int numero1, numero2, resultado  ;

//    Console.WriteLine("ingrese el precio del producto");
//    numero1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("ingrese la cantidad vendida");
//    numero2 = int.Parse(Console.ReadLine());

    //logica
//    resultado = Producto(numero1, numero2 ) ;
    
//    Console.WriteLine("el resultado es " + resultado );
  

 // int numero1, contador = 0 ;
 // for (int x = 0; x < 20; x++)
 // {
 //   Console.WriteLine("por favor escriba numeros");
 //   numero1 = int.Parse(Console.ReadLine());
 //  if(Par(numero1))
 //  contador++;
 // }
 // Console.WriteLine("la cantidad de numeros pares es de:" + contador);
  
 // int n;
 // Console.WriteLine("ingrese un numero");
 // n= int.Parse(Console.ReadLine());
 // while (n !=0)
 // {
 //   Console.WriteLine("ingrese otro");
 // n= int.Parse(Console.ReadLine());
  
  char operadores ;
  int num1 , num2, resultado ;

    Console.WriteLine("Ingrese dos numeros para hacer la operacion");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("ingrese el siguiente numero");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("ingrese el operador para poder realizar la operacion " + " S = suma " + " R = resta" + " D = division" + " M = multiplicacion");
    operadores = char.Parse(Console.ReadLine());
  switch ("operadores")
{
  case "s":
    if(operadores == 's') {
      Console.WriteLine("la suma de su operacion es " + resultado);
    } 

    break;
   
   case "r":
   if (operadores == 'r') {
   Console.WriteLine("la resta de su operacion es " + resultado);
    }

    break;

    case "d": 
    if (operadores == 'd') {
      Console.WriteLine("la divicion de su operacion es " + resultado);
     } 




  }
    static int Suma(int num1, int num2) {
  int resultado;
  resultado = num1 + num2 ; 
  return resultado ;
}
  
    }    
}
