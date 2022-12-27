using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WorkingBees.Core.Interfaces;
using WorkingBees.Core.Models;

namespace WorkingBees.Infra.Data
{
    public class SkillsRepository : IRepository<Skill>
    {
        private readonly IConfiguration _configuration;

        public SkillsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Skill> ListAll()
        {
            var query = "SELECT * FROM Skills;";

            try
            {
                using var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

                return conn.Query<Skill>(query).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao comunicar com banco. \n\nMessage: {ex.Message} \n\nTarget Site: {ex.TargetSite} \n\nStack Trace: {ex.StackTrace}");
                throw;
            }
        }

        public List<Skill> ListAllByUserId(long Id)
        {
            throw new NotImplementedException();
        }
        public bool Insert(Skill entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(long Id, Skill entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
