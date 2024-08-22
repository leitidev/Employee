using Employee.Models;

namespace Employee.Repository.Interface
{
    public interface IDepartamentoRepository
    {
        IEnumerable<Departamento> GetDepartamentos();
        Departamento GetDepartamento(int id);
    }
}
