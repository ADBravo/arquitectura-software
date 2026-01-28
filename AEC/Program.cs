using System;
using Usuarios;

class Program
{
    static void Main()
    {
        UsuarioServicio servicio = new UsuarioServicio();
        Usuario[] usuarios = servicio.Listar();

        Console.WriteLine("Usuarios del sistema:");

        for (int i = 0; i < usuarios.Length; i++)
        {
            Console.WriteLine(usuarios[i].id + " - " + usuarios[i].nombre);
        }
    }
}