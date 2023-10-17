using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Archivo archivo = new Archivo();
        ArchivoGeneric<List<Mascota>> archivoGenericJSON = new ArchivoGeneric<List<Mascota>>();
        ArchivoGeneric<List<Persona>> archivoGenericXML = new ArchivoGeneric<List<Persona>>(); 

    /* personaUno += mascotaUno;
        personaUno += mascotaDos;
        personaDos += mascotaTres;

        veterinaria += personaUno;
        veterinaria += mascotaUno;
        veterinaria += mascotaDos;
        veterinaria += mascotaTres;
        veterinaria += personaDos;
        */
/*
        archivo.EscribirArchivo("infoVeterinaria.txt", veterinaria);
        archivo.SerializarJSON(veterinaria, "infoVeterinaria.json");
        archivo.SerializarXML(veterinaria, "infoVeterinaria.xml");

        Console.WriteLine("----------- DESERIALIZACION XML VETERINARIA 2 -----------");

        Veterinaria veterinaria2 = archivo.DeserializarXML("infoVeterinaria.xml");
        Console.WriteLine(veterinaria2.ToString());


        Console.WriteLine("\n\n----------- DESERIALIZACION JSON VETERINARIA 3 -----------\n");

        Veterinaria veterinaria3 = archivo.DeserializarJSON("infoVeterinaria.json");
        Mascota mascotaCuatro = new Mascota(4, 0, "Albert", false, 3);
        veterinaria3 += mascotaCuatro;
        Console.WriteLine(veterinaria3.ToString());

        Console.WriteLine("\n\n --------------- SERIALIZACION Y DESERIALIZACION JSON GENERIC ------------");
        archivoGenericJSON.SerializarGeneric(veterinaria3.ListaMascotas, "veterinariaTresMascotas.json");
        ((ArchivoGeneric<List<Persona>>)archivoGenericXML).SerializarGeneric(veterinaria3.ListaClientes, "veterinariaTresClientes.xml");
        Veterinaria veterinaria4 = new Veterinaria();

        veterinaria4.ListaMascotas = ((ArchivoGeneric<List<Mascota>>)archivoGenericJSON).DeserializarGeneric("veterinariaTresMascotas.json");
        Console.WriteLine(veterinaria4 .MostrarMascotas());*/


        Console.WriteLine("\n\n --------------- CLASE ADO ------------");
        ADO baseDeDatos = new ADO();

        if(baseDeDatos.ProbarConexion())
        {
            Console.WriteLine("Conexión exitosa");
        }
        else
        {
            Console.WriteLine("Conexión fallida");
        }

        /* if  (baseDeDatos.AgregarCliente(personaDos))
         {
             Console.WriteLine("Cliente agregado");
         }
         else
         {
             Console.WriteLine("Error al agregar cliente");
         }

         try
         {
             List<Persona> listaPersonas = baseDeDatos.ObtenerClientes();
             foreach (Persona item in listaPersonas)
             {
                 Console.WriteLine(item.ToString());
             }
         }
         catch (Exception)
         {

             throw;
         }
        */
        List<Persona> listaPersonas = baseDeDatos.ObtenerClientes();
        try
        {
            if (baseDeDatos.EliminarCliente(-1))
            {
                Console.WriteLine("Se elimino el cliente");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar al cliente");
            }
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
        }


        try
        {
            listaPersonas[1].Nombre = "Juan Ignacio";
            if (baseDeDatos.ModificarCliente(listaPersonas[1]))
            {
                Console.WriteLine("Exito al modificar");
            }
            else
            {
                Console.WriteLine("Error al modificar");
            }
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}