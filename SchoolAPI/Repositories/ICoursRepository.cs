using SchoolAPI.Models;

namespace SchoolAPI.Repositories
{
    public interface ICoursRepository
    {
        IEnumerable<Cours> GetAllCours();
        Cours GetCoursById(int coursId);
        void CreateCours(Cours cours);
        void UpdateCours(Cours cours, int coursId);
        void DeleteCours(int coursId);



    }
}
