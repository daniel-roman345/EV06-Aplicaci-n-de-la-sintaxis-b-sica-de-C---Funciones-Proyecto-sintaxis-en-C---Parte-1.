using System;
 
namespace biblioteca_menu.Models
{
    public class Prestamo
    {
        public int           Id              { get; set; }
        public int           LibroId         { get; set; }
        public int           UsuarioId       { get; set; }
        public DateTime      FechaPrestamo   { get; set; }
        public DateTime?     FechaDevolucion { get; set; }
        public EstadoPrestamo Estado         { get; set; }
 
        public Prestamo()
        {
            Estado          = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }
 
        public Prestamo(int id, int libroId, int usuarioId, DateTime fechaPrestamo)
        {
            Id              = id;
            LibroId         = libroId;
            UsuarioId       = usuarioId;
            FechaPrestamo   = fechaPrestamo;
            Estado          = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }
 
        public bool EstaVencido() =>
            Estado == EstadoPrestamo.Activo && (DateTime.Now - FechaPrestamo).Days > 7;
 
        public int DiasTranscurridos() =>
            (DateTime.Now - FechaPrestamo).Days;
 
        public string ResumenCorto() =>
            $"[{Id}] Libro:{LibroId} | Usuario:{UsuarioId} | Estado:{Estado}";
 
        public string DetalleCompleto() =>
            $"ID: {Id} | LibroID: {LibroId} | UsuarioID: {UsuarioId} | " +
            $"Fecha: {FechaPrestamo:dd/MM/yyyy} | Estado: {Estado} | " +
            $"Devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}";
 
        public override string ToString() => DetalleCompleto();
    }
}