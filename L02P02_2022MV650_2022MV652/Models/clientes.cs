using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace L02P02_2022VF650_2022MV652.Models
{
    public class clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int email { get; set; }
        public int dirección { get; set; }
        public int estado { get; set; }

        [DisplayName("Fecha de Creación")]
        [Required(ErrorMessage = "La fecha de creación es obligatoria")]
        [DataType(DataType.Date)] 
        public DateTime FechaCreacion { get; set; }

    }
}

