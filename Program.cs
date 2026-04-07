using System;
using System.Collections.Generic;
using menu_biblioteca.Models;
using menu_biblioteca.Services;

class Program
{
    static LibroService libroService = new LibroService();

    static void Main()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Ver libros");
            Console.WriteLine("3. Array vs List");
            Console.WriteLine("4. Salir");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    RegistrarLibro();
                    break;
                case 2:
                    MostrarLibros();
                    break;
                case 3:
                    CompararArrayVsList();
                    break;
            }
        }
    }

    static void RegistrarLibro()
    {
        Console.Clear();

        Console.Write("Título: ");
        string titulo = Console.ReadLine() ?? "";

        Console.Write("Autor: ");
        string autor = Console.ReadLine() ?? "";

        int id = libroService.TotalLibros() + 1;

        Libro libro = new Libro(id, titulo, autor);
        libroService.AgregarLibro(libro);

        Console.WriteLine("\nLibro registrado correctamente.");
        Console.ReadKey();
    }

    static void MostrarLibros()
    {
        Console.Clear();

        foreach (var libro in libroService.ObtenerTodos())
        {
            Console.WriteLine(libro.DetalleCompleto());
        }

        Console.ReadKey();
    }

    static void CompararArrayVsList()
    {
        Console.Clear();

        int[] array = new int[2] { 1, 2 };
        Console.WriteLine("Array tamaño fijo: " + array.Length);

        var lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);

        Console.WriteLine("List tamaño dinámico: " + lista.Count);

        Console.ReadKey();
    }
}