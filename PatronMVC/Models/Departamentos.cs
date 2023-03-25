namespace PatronMVC.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
         public int Habitaciones { get; set; }

        public int? Baño { get; set; }

        public string? Ubicacion { get; set; }

        public decimal costo { get; set; }
    }
}
