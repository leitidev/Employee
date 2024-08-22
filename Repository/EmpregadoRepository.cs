using Employee.Data;
using Employee.Models;
using Employee.Repository.Interface;

namespace Employee.Repository
{
    public class EmpregadoRepository : IEmpregadoRepository
    {
        private readonly dbContext dbContext;

        public EmpregadoRepository(dbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Empregado> AddEmpregado(Empregado empregado)
        {
            var result = await dbContext.Empregado.AddAsync(empregado);
            return result.Entity;
        }

        public void DeleteEmpregado(int empId)
        {
            throw new NotImplementedException();
        }

        public Task<Empregado> GetEmpregado(int empId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empregado>> GetEmpregados()
        {
            throw new NotImplementedException();
        }

        public Task<Empregado> UpdateEmpregado(Empregado empregado)
        {
            throw new NotImplementedException();
        }
    }
}
