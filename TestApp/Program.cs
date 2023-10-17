using EntidadesTest;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Archivo<Almacen<Auto>> archivoAlmacenAuto = new Archivo<Almacen<Auto>>();
        Archivo<Almacen<Moto>> archivoAlmacenMoto = new Archivo<Almacen<Moto>>();
        Archivo<List<Auto>> archivoCargarAutos = new Archivo<List<Auto>>();

        Almacen<Auto> almacenAuto = new Almacen<Auto>(5);
        Almacen<Moto> almacenMoto = new Almacen<Moto>(10);

        Auto auto1 = new Auto(1, "Ferrari", 1000000, DateTime.Now);
        Auto auto2 = new Auto(2, "Audi", 300000, DateTime.Now);

        Moto moto1 = new Moto(1, "Jaguar", 100, Estado.Nuevo);
        Moto moto2 = new Moto(2, "XR600", 600, Estado.Seminuevo);
        Moto moto3 = new Moto(3, "Z250", 250, Estado.Usado);

        bool returnAux;

        almacenAuto.Agregar(auto1);
        almacenAuto.Agregar(auto2);
        almacenAuto.Agregar(auto1);
        /*
        almacenMoto.Agregar(moto1);
        almacenMoto.Agregar(moto2);
        almacenMoto.Agregar(moto3);
        almacenMoto.Agregar(moto1);
        */
        /*Console.WriteLine("Almacen Auto -- \n");
        Console.WriteLine(almacenAuto.ToString());
        Console.WriteLine("\n\nAlmacen Moto-- \n");
        Console.WriteLine(almacenMoto.ToString());

        almacenAuto.Remover(auto1);
        almacenMoto.Remover(moto3);

        Console.WriteLine("Almacen Auto -- \n");
        Console.WriteLine(almacenAuto.ToString());

        Console.WriteLine("\n\nAlmacen Moto-- \n");
        Console.WriteLine(almacenMoto.ToString());*/

        returnAux = archivoAlmacenAuto.delegadoSerializarDatos(almacenAuto, "Informacion de almacen de autos");

       

        Console.WriteLine(almacenAuto.ToString());

    }
}