//Arreglo
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

static void ejemplo ()
{
    //Declaracion de un arreglo
    int[] calificaciones;
    
    //Creacion de un arreglo con valores iniciales
    calificaciones = new int[] {85,92,77,68,94,10,02,25,56,99};

    // Acceso a un elemento del arreglo
    Console.WriteLine (calificaciones[2]);//Imprime 77
    Console.WriteLine();

    //iteracion
    double sum =0;
    foreach(int numero in calificaciones)
    {
        Console.WriteLine(numero);
        sum = numero + numero;
    }
    Console.WriteLine();
    double indi =calificaciones.Length;
    double promedio = sum/indi;
    Console.WriteLine ("El promedio es: "+promedio);
    Console.WriteLine();

    //FOR para iteraci[on
    for (int i = 0; i<calificaciones.Length; i++)
    {
        sum = i + i;
        Console.WriteLine($"calificaciones{i + 1}:{calificaciones[i]}");
    }
    double prom = sum / calificaciones.Length;
    Console.WriteLine("El promedio por for es: " + promedio);
    Console.WriteLine();
    
    //Array.Sort();
    Array.Sort (calificaciones);
}
ejemplo ();

static void ejemplo2()
{
    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("Original");
    foreach(int item in elementos)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine ("Ordenado");
    Array.Sort(elementos);//Para ordenar 
    foreach (int item in elementos)
    {
        Console.WriteLine(item);
    }
   
}
ejemplo2();

static void despliegue(int[] arreglos)
{
    foreach (int item in arreglos)
    {
        Console.WriteLine(item);
    }
}

static void ejemplo3()
{
    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Array.Reverse (elementos);
    Console.WriteLine("Original");
    despliegue(elementos);
    Console.WriteLine("Ordenado");
    Array.Sort(elementos);
    despliegue(elementos);
    Array.Reverse(elementos);
    Console.WriteLine("Buscar");
    Array.IndexOf(elementos, 90);
    despliegue(elementos);

    bool hayAprobados = Array.Exists(elementos, calif => calif >= 60 );
    
 
}
ejemplo3();