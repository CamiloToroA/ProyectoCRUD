using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoCRUD.WEB.Models.Entities
{
    public class Maquinaria
    {
        [Key]
        public int IdMaquina { get; set; }

        [DisplayName("Nombre de la maquina")]
        [Column("NombreMaquina", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Column(TypeName = "nvarchar(80)")]
        public string Marca { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Componentes { get; set; }
        [Column(TypeName = "nvarchar(180)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "nvarchar(180)")]
        public string Voltaje { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Potencia { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Amperaje { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Velocidad { get; set; }
        [DisplayName("Protector térmico")]
        public string ProtectorTermico { get; set; }

        [DisplayName("Caja Reductora")]
        public string CajaReductora { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Ubicacion { get; set; }

    }
}
