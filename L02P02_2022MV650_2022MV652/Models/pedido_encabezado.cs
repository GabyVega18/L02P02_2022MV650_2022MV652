namespace L02P02_2022VF650_2022MV652.Models
{
    public class pedido_encabezado
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int cantidad_libros { get; set; }
        public double total { get; set; }
    }
}
