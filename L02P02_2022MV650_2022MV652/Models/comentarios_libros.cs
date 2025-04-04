using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace L02P02_2022VF650_2022MV652.Models
{
    public class comentarios_libros
    {
        public int id { get; set; }
        public int id_libro { get; set; }
        public string comentarios { get; set; }
        public string usuario { get; set; }
    }
}
