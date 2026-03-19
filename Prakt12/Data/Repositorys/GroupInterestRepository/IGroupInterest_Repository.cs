using Prakt12.Models;

namespace Prakt12.Data.Repositorys.GroupInterestRepository
{
    public interface IGroupInterest_Repository
    {
        public void GetAll();
        public void AddInterstGroup(InterestGroup interestGroup);
        public void UpdateInterstGroup();
        public void DeleteInterstGroup(InterestGroup interestGroup);

        public bool GroupIsExist(string title);


    }
}
