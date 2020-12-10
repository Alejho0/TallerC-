using System;

namespace Actividad_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num != 0)
            {
                //Texto inicial
                Console.WriteLine("Julian Alejandro Forero Avila                                                          \n" +
                                       "ADSI 2067791                                                                      \n" +
                                       "                                                                                  \n" +
                                       "|------------------- POR FAVOR DIGITE EL NUMERO DEL ALGORITMO -------------------|\n" +
                                       "                                                                                  \n" +
                                       "|-------------------             Ejercicio 1                  -------------------|\n" +
                                       "|-------------------             Ejercicio 2                  -------------------|\n" +
                                       "|-------------------             Ejercicio 3                  -------------------|\n" +
                                       "|-------------------             Ejercicio 4                  -------------------|\n" +
                                       "|-------------------             Ejercicio 5                  -------------------|\n" +
                                       "|-------------------             Ejercicio 6                  -------------------|\n" +
                                       "|-------------------             Ejercicio 7                  -------------------|\n" +
                                       "|-------------------             Ejercicio 8                  -------------------|\n" +
                                       "|---------------             Digite 0 para salir                  ---------------|\n");

                
                num = Convert.ToInt32(Console.ReadLine()); //Se pide numero del ejercicio
                Console.Clear(); //Clear para limpiat consola
                switch (num) //El Switch tomara el numero digitado y abrira el casi que corresponda
                {
                    case 1:

                        Console.WriteLine("1.\t Leer un número por teclado y definir si es par o impar\n"); //Texto descriptivo del problema
                        Console.Write("Escriba por favor un numero entero: "); // Se solicita el numero por pantalla
                        int n = Convert.ToInt32(Console.ReadLine()); //Se gaurda el numero ingresado en la variable
                        int r = n % 2; //Se calcula si el numero es divisible entre 2 para ver si es par o no
                        if (n <= 0)  //Si el numero es menor que 0 se dira que no es par ni impar
                        {

                            Console.WriteLine("\n¡El numero no es PAR ni IMPAR!");
                            Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");

                        }

                        else if (r == 0) // Si el calculo es de r es igual a cero el numero sera par
                        {

                            Console.WriteLine("\nEl numero es ¡PAR!");
                            Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        }

                        else // Si no es igual a cero el numero sera impar
                        {

                            Console.WriteLine("\nEl numero ¡IMPAR!");
                            Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        }

                        Console.ReadKey();
                        break;

                    case 2:

                        Console.WriteLine("2.\t Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10"); //Texto descriptivo del problema
                        Console.WriteLine("\nDigite por favor el numero de la tabla de multiplicar que desea ver: "); // Se solicita el numero por pantalla

                        int nu = Convert.ToInt32(Console.ReadLine()); //Se guarda el numero en la variable
                        int c; //Se declara la variable para calcular mas adelante
                        //Console.Clear(); //Se limpia la pantalla para mostrar la solución
                        for (int i = 1; i < 11; i++) //El ciclo for va a recorrer el calculo las 1O Veces y mostrara el resulto
                        {
                            c = nu * i; // con la varibale c se multiplica el numero ingresado por el numero del ciclo que se repite de 1 a 10
                            Console.WriteLine(+nu + " * " + i + " = " + c); //Se muestra a solución
                        }
                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        Console.ReadKey();
                        break;

                    case 3:

                        Console.WriteLine("3.\t Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10\n"); //Texto descriptivo del problema
                        for (int j = 2; j < 10; j++) //El primer ciclo for va a repetir el ciclo que esta adentro las veces que indiquemos
                        {
                            Console.WriteLine("\nTabla del " + j); //Se mostrara el numero de tabla y se dara salto de linea                           
                            for (int i = 1; i < 11; i++) //Este ciclo for va a realizar el calculo y lo repetira 
                            {
                                r = j * i; //Se realiza la multiplicación
                                Console.WriteLine(+j + " * " + i + " = " + r); //Se muestra a solución
                            }
                        }
                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        Console.ReadKey();
                        break;

                    case 4:
                        // Un número entero mayor que 1 es primo si es divisible únicamente por 1 y por sí mismo.
                        Console.WriteLine("4.\t Leer un número por teclado y definir si es primo o no\n"); //Texto descriptivo del problema
                        Console.Write("Escriba un número mayor que 1: "); // Se solicita el numero por pantalla                                     
                        int primo = int.Parse(Console.ReadLine()); //Se guarda el numero en la variable                        
                        int contador = 0; //Se inicializa el contador en                         

                        if (primo < 1) //Si el numero es menor a 1 se indica que digite el numero debe ser mayor a 1
                        {
                            Console.WriteLine("¡Por favor digite un numero mayor que 1!");
                        }
                        for (int i = 1; i <= primo; i++) //Con el ciclo se recorre el calculo dividiendo el numero para validar si es primo
                        {
                            int numero = primo % i; //Calculo: se divide el numero ingresado desde uno hasta si mismo                            
                            if (numero == 0) //Si el calculo da 0 el contador se activa y empezara a sumar de uno en uno
                            {
                                contador += 1; //Si el resultado del contador es mayor que dos el numero no es primo porque no es divisible por uno y por si mismo                                
                            }

                            if (contador > 2)
                            {
                                //Console.Clear();
                                Console.WriteLine("\n¡El numero digitado NO es primo!");
                            }

                            if (primo == i && contador <= 2) //Si el numero ingresado es igual a i y contador menor o igual que 2 el numero si es primo
                            {
                                //Console.Clear();
                                Console.WriteLine("\n!El numero digitado SI es primo¡");
                            }
                        }
                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("5.\t Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente\n"); //Texto descriptivo del problema
                        int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 }; //Se crea array con las edades
                        int temp; //Se crea variable que guardara un dato temporal mas adelante
                        int t = edad.Length; //Esta variable recorre el array de edades

                        Console.WriteLine("\n\nDESORDENADO");
                        foreach (int datos in edad) //Se recorre el arreglo con el foreach
                        {
                            Console.Write(datos + "-"); //Se muestran los datos que se van guardando en la variable datos
                        }
                        Console.WriteLine("\n\nDigite el numero 1 para ordenar el vector..."); //Esto lo agregue para que se vea mejor el programa
                        int com = 0; //Se declara esta variable como bandera para el While

                        while (com != 1) //Con este While mientras que no se digite el 1 se seguira pidiendo que lo digite para poder mostrar la solución
                        {
                            com = Convert.ToInt32(Console.ReadLine()); //La variable tomara el digito que se ingrese por teclado
                            if (com == 1) //Si el digito es 1 se va a mostrar la solución
                            {
                                for (int j = 1; j < t; j++) //Con este for
                                {
                                    for (int i = 0; i < t - j; i++)
                                    {
                                        if (edad[i] > edad[i + 1])
                                        {
                                            temp = edad[i];
                                            edad[i] = edad[i + 1];
                                            edad[i + 1] = temp;
                                        }

                                    }
                                }
                                Console.WriteLine("\n\nVECTOR ORDENADO");
                                foreach (int datos in edad)
                                {

                                    Console.Write(datos + "-");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Digite el numero 1 para ordenar el vector...");
                            }

                        }

                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("6.\t Datos los vectores\n\n" +
                                          "Edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45\n" +
                                          "Nombre = ['juan', 'maria', 'tereza', 'pedro', 'javier', 'ana', 'diana', 'jorge', 'dayana', 'lady']\n\n" +
                                          "Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje\n" +
                                          "que el nombre no existe\n\n");

                        int[] edad1 = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        String[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

                        string nombre;
                        nombre = Console.ReadLine();
                        if (nombre == "Juan" || nombre == "juan")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 12);
                        }
                        else if (nombre == "Maria" || nombre == "maria")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 50);
                        }
                        else if (nombre == "Tereza" || nombre == "tereza")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 23);
                        }
                        else if (nombre == "Pedro" || nombre == "pedro")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 10);
                        }
                        else if (nombre == "Javier" || nombre == "javier")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 18);
                        }
                        else if (nombre == "Ana" || nombre == "ana")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 35);
                        }
                        else if (nombre == "Diana" || nombre == "diana")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 41);
                        }
                        else if (nombre == "Jorge" || nombre == "jorge")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 85);
                        }
                        else if (nombre == "Dayana" || nombre == "dayana")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 16);
                        }
                        else if (nombre == "Lady" || nombre == "lady")
                        {
                            Console.WriteLine("\nLa edad de " + nombre + " es " + 45);
                        }
                        else
                        {
                            Console.WriteLine("\nDisculpe, el nombre digitado no existe en el vector ");

                        }
                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        Console.ReadKey();
                        break;

                    ///* definir dos variables */
                    //Boolean existe = false; /* me a decir si el ususario exisete */
                    //int indice = 0;  /* guardare el valor de la posicion del arreglo  donde existe el usasrio */
                    //string NombreBuscar;
                    //int indiceMayor = 0;
                    //int edadMayor = 0;

                    //foreach (string nombre in nombres)
                    //{
                    //    Console.Write(nombre + " , ");
                    //}

                    //Console.Write("\n");

                    ///*   leer el nombre a buscar */
                    //Console.Write("Digite el nombre a buscar: ");
                    //NombreBuscar = Console.ReadLine();


                    ///*  recorra el vector y me diga si existe y la posiscion */
                    //for (int i = 0; i < nombres.Length; i++)
                    //{

                    //    // - busco el nombre
                    //    if (NombreBuscar == nombres[i])
                    //    {
                    //        existe = true;
                    //        indice = i;
                    //    }
                    //    // comparo las edades 
                    //    if (edad1[i] > edadMayor)
                    //    {
                    //        edadMayor = edad1[i];
                    //        indiceMayor = i;
                    //    }
                    //}

                    case 7:

                        Console.WriteLine("7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres\n" +
                                          "con su edad.");
                        string buscar;
                        bool existe = false;
                        int indice = 0;
                        int mayor = 0;
                        int edadmayor = 0;
                        int menor = 0;
                        int edadmenor = 0;
                        //Console.WriteLine("Buscar usuario y mostar su edad");
                        int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nom = { "juan", "maria", "teresa", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        Console.WriteLine("\nDigite el nombre a buscar");
                        buscar = Console.ReadLine();

                        for (int ei = 0; ei < nom.Length; ei++)
                        {
                            if (buscar == nom[ei])
                            {
                                existe = true;
                                indice = ei;
                            }
                            for (int ej = 0; ej < edades.Length; ej++)
                            {
                                if (edades[ej] > edadmayor)
                                {
                                    edadmayor = edades[ej];
                                    mayor = ej;
                                }
                            }

                            for (int ej = 0; ej < edades.Length; ej++)
                            {
                                if (edades[ej] < edadmenor)
                                {
                                    edadmenor = edades[ej];
                                    menor = ej;
                                }
                            }

                        };
                        if (existe)
                        {
                            Console.WriteLine("* La edad de " + buscar + " es " + edades[indice]);
                            
                        }
                        else
                            Console.WriteLine("* El usuario " + buscar + " no existe");

                        Console.WriteLine("\nlos usurios mayor y menor son:");
                        Console.WriteLine("* El usuario mayor es " + nom[mayor] + " y su edad es " + edades[mayor]);
                        Console.WriteLine("* El usuario menor es " + nom[menor] + " y su edad es " + edades[menor]);
                        Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");

                        Console.ReadKey();
                        break;

                    case 8:

                        Console.Write("8. \t Dado una palabra definir si es palíndromo o no.\n");
                        string str = string.Empty;
                        Console.Write("\nIntroduzca una palabra para validar si es palidromo o no: ");
                        string palabra; 
                        palabra = Console.ReadLine();
                        int i_p = palabra.Length;
                        for (int lj = i_p - 1; lj >= 0; lj--)
                        {
                            str = str + palabra[lj];
                        }
                        if (str == palabra)
                        {
                            Console.WriteLine("\nLa palabra " + palabra + " si es palindromo");
                            Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        }
                        else
                        {
                            Console.WriteLine("\nLa palabra: "+palabra+", no es palindromo ya que invertida es: "+str);
                            Console.WriteLine("\n\nPresione ENTER para volver al menu inicial...");
                        }
                        Console.ReadKey();
                        break;


                }
                Console.Clear();
            }
        }
    }
}
