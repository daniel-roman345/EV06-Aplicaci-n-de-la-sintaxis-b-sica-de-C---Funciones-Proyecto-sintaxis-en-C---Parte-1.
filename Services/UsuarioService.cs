using System;
using System.Collections.Generic;
using System.Linq;
using biblioteca_menu.Models;
 
namespace biblioteca_menu.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private int _nextId = 1;
 
        // ================================================
        // AGREGAR
        // ================================================
        public void AgregarUsuario(Usuario usuario)
        {
            usuario.Id = _nextId++;
            usuarios.Add(usuario);
        }
 
        // ================================================
        // ELIMINAR
        // ================================================
        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = usuarios.Find(u => u.Id == id);
            if (usuario == null) return false;
            usuarios.Remove(usuario);
            return true;
        }
 
        // ================================================
        // OBTENER TODOS
        // ================================================
        public List<Usuario> ObtenerTodos() => usuarios;
 
        // ================================================
        // BÚSQUEDAS
        // ================================================
        public Usuario? BuscarPorId(int id) =>
            usuarios.Find(u => u.Id == id);
 
        public List<Usuario> BuscarPorNombre(string nombre) =>
            usuarios.FindAll(u => u.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
 
        public List<Usuario> BuscarPorDocumento(string documento) =>
            usuarios.FindAll(u => u.Documento.Contains(documento, StringComparison.OrdinalIgnoreCase));
 
        // ================================================
        // ORDENACIÓN
        // ================================================
        public List<Usuario> OrdenarPorNombre() =>
            usuarios.OrderBy(u => u.Nombre).ToList();
 
        // ================================================
        // KPIs
        // ================================================
        public int TotalUsuarios() => usuarios.Count;
 
        public int UsuariosActivos() => usuarios.Count(u => u.Activo);
 
        public int UsuariosInactivos() => usuarios.Count(u => !u.Activo);
 
        public void MostrarKPIs()
        {
            Console.WriteLine("\n===== KPIs - USUARIOS =====");
            Console.WriteLine($"  Total de usuarios : {TotalUsuarios()}");
            Console.WriteLine($"  Activos           : {UsuariosActivos()}");
            Console.WriteLine($"  Inactivos         : {UsuariosInactivos()}");
            Console.WriteLine("===========================\n");
        }
    }
}