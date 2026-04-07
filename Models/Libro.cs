namespace menu_biblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; }

        public Libro(int id, string titulo, string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Disponible = true;
        }

        public string DetalleCompleto()
        {
            return $"ID:{Id} | {Titulo} - {Autor} | Disponible: {Disponible}";
        }
    }
}