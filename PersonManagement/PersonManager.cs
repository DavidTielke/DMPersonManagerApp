using System.Linq;
using DavidTielke.DMPMA.CrossCutting.DataClasses;
using DavidTielke.DMPMA.Data.DataStoring;

namespace DavidTielke.DMPMA.Logic.PersonManagement
{
    public class PersonManager
    {
        private readonly PersonRepository _repository;

        public PersonManager()
        {
            _repository = new PersonRepository();
        }

        public IQueryable<Person> GetAllAdults() => _repository.Query.Where(p => p.Age >= 18);
        public IQueryable<Person> GetAllChildren() => _repository.Query.Where(p => p.Age < 18);

    }
}
