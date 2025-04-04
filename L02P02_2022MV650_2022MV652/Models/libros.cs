using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L02P02_2022VF650_2022MV652.Models
{
    public class libros
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string url_imagen { get; set; }
        public int id_autor { get; set; }
        public int id_categoria { get; set; }
        public double precio { get; set; }
        public string estado { get; set; }
    }
}
