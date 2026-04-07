using System;
using System.Collections.Generic;
using System.Linq;
using biblioteca_menu.Models;
 
namespace biblioteca_menu.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();
        private int _nextId = 1;
 
        // ================================================
        // AGREGAR
        // ================================================
        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamo.Id = _nextId++;
            prestamos.Add(prestamo);
        }
 
        // ================================================
        // ELIMINAR
        // ================================================
        public bool EliminarPrestamo(int id)
        {
            Prestamo? prestamo = prestamos.Find(p => p.Id == id);
            if (prestamo == null) return false;
            prestamos.Remove(prestamo);
            return true;
        }
 
        // ================================================
        // OBTENER TODOS
        // ================================================
        public List<Prestamo> ObtenerTodos() => prestamos;
 
        // ================================================
        // BÚSQUEDAS
        // ================================================
        public Prestamo? BuscarPorId(int id) =>
            prestamos.Find(p => p.Id == id);
 
        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado) =>
            prestamos.FindAll(p => p.Estado == estado);
 
        public List<Prestamo> BuscarPorUsuarioId(int usuarioId) =>
            prestamos.FindAll(p => p.UsuarioId == usuarioId);
 
        public List<Prestamo> BuscarPorLibroId(int libroId) =>
            prestamos.FindAll(p => p.LibroId == libroId);
 
        // ================================================
        // REGISTRAR DEVOLUCIÓN
        // ================================================
        public bool RegistrarDevolucion(int id)
        {
            Prestamo? prestamo = prestamos.Find(p => p.Id == id);
            if (prestamo == null) return false;
            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.Estado = EstadoPrestamo.Devuelto;
            return true;
        }
 
        // ================================================
        // ACTUALIZAR VENCIDOS (llamar al listar para mantener estados al día)
        // ================================================
        public void ActualizarVencidos()
        {
            foreach (var p in prestamos)
            {
                if (p.Estado == EstadoPrestamo.Activo && p.EstaVencido())
                    p.Estado = EstadoPrestamo.Vencido;
            }
        }
 
        // ================================================
        // ORDENACIÓN
        // ================================================
        public List<Prestamo> OrdenarPorFechaLimite() =>
            prestamos.OrderBy(p => p.FechaPrestamo.AddDays(7)).ToList();
 
        public List<Prestamo> OrdenarPorEstado() =>
            prestamos.OrderBy(p => p.Estado).ToList();
 
        // ================================================
        // KPIs
        // ================================================
        public int TotalPrestamos() => prestamos.Count;
 
        public int PrestamosActivos() => prestamos.Count(p => p.Estado == EstadoPrestamo.Activo);
 
        public int PrestamosVencidos() => prestamos.Count(p => p.Estado == EstadoPrestamo.Vencido);
 
        public int PrestamosDevueltos() => prestamos.Count(p => p.Estado == EstadoPrestamo.Devuelto);
 
        public double PromedioDiasPrestamo()
        {
            if (!prestamos.Any()) return 0;
            return prestamos.Average(p => p.DiasTranscurridos());
        }
 
        public void MostrarKPIs()
        {
            ActualizarVencidos();
            Console.WriteLine("\n===== KPIs - PRÉSTAMOS =====");
            Console.WriteLine($"  Total de préstamos     : {TotalPrestamos()}");
            Console.WriteLine($"  Activos                : {PrestamosActivos()}");
            Console.WriteLine($"  Vencidos               : {PrestamosVencidos()}");
            Console.WriteLine($"  Devueltos              : {PrestamosDevueltos()}");
            Console.WriteLine($"  Promedio días préstamo : {PromedioDiasPrestamo():F1} días");
            Console.WriteLine("============================\n");
        }
    }
}
 