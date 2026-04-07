using System;
using System.Collections.Generic;
using System.Linq;
using biblioteca_menu.Models;
 
namespace biblioteca_menu.Services
{
    public class LibroService
    {
        // ================================================
        // COLECCIÓN PRINCIPAL (List<T> vs Array - ver abajo)
        // ================================================
        private List<Libro> libros = new List<Libro>();
        private int _nextId = 1;
 
        // ================================================
        // COMPARACIÓN: ARRAY vs LIST (punto 7 del enunciado)
        // ================================================
        public static void MostrarComparacionArrayVsList()
        {
            Console.WriteLine("\n===== COMPARACIÓN: ARRAY vs LIST =====");
 
            // --- ARRAY ---
            // Tamaño fijo: hay que declararlo con un tamaño máximo.
            // No se puede agregar ni eliminar elementos fácilmente.
            string[] arrayLibros = new string[3];
            arrayLibros[0] = "Cien años de soledad";
            arrayLibros[1] = "Don Quijote";
            arrayLibros[2] = "El Principito";
            Console.WriteLine("\n[ARRAY] Libros registrados:");
            foreach (var t in arrayLibros)
                Console.WriteLine("  - " + t);
 
            // Para "eliminar" en array se deja en null o se reconstruye: ineficiente.
            // arrayLibros[1] = null; // Deja un hueco → problemas al iterar
 
            // --- LIST ---
            // Tamaño dinámico: crece y decrece automáticamente.
            // Métodos Add, Remove, Find, Sort integrados.
            List<string> listaLibros = new List<string>();
            listaLibros.Add("Cien años de soledad");
            listaLibros.Add("Don Quijote");
            listaLibros.Add("El Principito");
            Console.WriteLine("\n[LIST] Libros registrados:");
            foreach (var t in listaLibros)
                Console.WriteLine("  - " + t);
 
            listaLibros.Remove("Don Quijote"); // Eliminar es sencillo
            Console.WriteLine("\n[LIST] Después de eliminar 'Don Quijote':");
            foreach (var t in listaLibros)
                Console.WriteLine("  - " + t);
 
            Console.WriteLine("\nCONCLUSIÓN:");
            Console.WriteLine("  Array  → tamaño fijo, acceso rápido por índice, sin métodos de colección.");
            Console.WriteLine("  List   → tamaño dinámico, Add/Remove/Find/Sort integrados, ideal para datos variables.");
            Console.WriteLine("======================================\n");
        }
 
        // ================================================
        // AGREGAR
        // ================================================
        public void AgregarLibro(Libro libro)
        {
            libro.Id = _nextId++;
            libros.Add(libro);
        }
 
        // ================================================
        // ELIMINAR
        // ================================================
        public bool EliminarLibro(int id)
        {
            Libro? libro = libros.Find(l => l.Id == id);
            if (libro == null) return false;
            libros.Remove(libro);
            return true;
        }
 
        // ================================================
        // OBTENER TODOS
        // ================================================
        public List<Libro> ObtenerTodos() => libros;
 
        // ================================================
        // BÚSQUEDAS
        // ================================================
        public Libro? BuscarPorId(int id) =>
            libros.Find(l => l.Id == id);
 
        public List<Libro> BuscarPorTitulo(string titulo) =>
            libros.FindAll(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase));
 
        public List<Libro> BuscarPorAutor(string autor) =>
            libros.FindAll(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase));
 
        public List<Libro> BuscarPorIsbn(string isbn) =>
            libros.FindAll(l => l.ISBN.Contains(isbn, StringComparison.OrdinalIgnoreCase));
 
        // ================================================
        // ACTUALIZAR
        // ================================================
        public bool ActualizarLibro(int id, string nuevoTitulo, string nuevoAutor, string nuevoIsbn, int nuevoAnio)
        {
            Libro? libro = libros.Find(l => l.Id == id);
            if (libro == null) return false;
            libro.Titulo = nuevoTitulo;
            libro.Autor = nuevoAutor;
            libro.ISBN = nuevoIsbn;
            libro.Anio = nuevoAnio;
            return true;
        }
 
        // ================================================
        // ORDENACIÓN
        // ================================================
        public List<Libro> OrdenarPorTitulo() =>
            libros.OrderBy(l => l.Titulo).ToList();
 
        public List<Libro> OrdenarPorAutor() =>
            libros.OrderBy(l => l.Autor).ToList();
 
        public List<Libro> OrdenarPorAnio() =>
            libros.OrderBy(l => l.Anio).ToList();
 
        // ================================================
        // KPIs
        // ================================================
        public int TotalLibros() => libros.Count;
 
        public int LibrosDisponibles() => libros.Count(l => l.Disponible);
 
        public int LibrosPrestados() => libros.Count(l => !l.Disponible);
 
        public void MostrarKPIs()
        {
            Console.WriteLine("\n===== KPIs - LIBROS =====");
            Console.WriteLine($"  Total de libros   : {TotalLibros()}");
            Console.WriteLine($"  Disponibles       : {LibrosDisponibles()}");
            Console.WriteLine($"  Prestados         : {LibrosPrestados()}");
            Console.WriteLine("=========================\n");
        }
    }
}