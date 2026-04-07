namespace biblioteca_menu.Models
{
    public class Usuario
    {
        public int    Id       { get; set; }
        public string Nombre   { get; set; } = "";
        public string Documento{ get; set; } = "";
        public bool   Activo   { get; set; }
 
        public Usuario()
        {
            Activo = true;
        }
 
        public Usuario(int id, string nombre, string documento = "")
        {
            Id       = id;
            Nombre   = nombre;
            Documento= documento;
            Activo   = true;
        }
 
        public string ResumenCorto() => $"[{Id}] {Nombre} (Doc: {Documento})";
 
        public string DetalleCompleto() =>
            $"ID: {Id} | Nombre: {Nombre} | Documento: {Documento} | Activo: {Activo}";
 
        public override string ToString() => DetalleCompleto();
    }
}
 