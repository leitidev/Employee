using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string NomeDepartamento { get; set; }
    }
}
