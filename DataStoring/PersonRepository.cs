using System.Collections.Generic;
using System.Linq;
using DavidTielke.DMPMA.CrossCutting.DataClasses;

namespace DavidTielke.DMPMA.Data.DataStoring
{
    public class PersonRepository
    {
        public IQueryable<Person> Query => new List<Person>
        {
            new Person(1,"David", 38),
            new Person(2,"Lena", 35),
            new Person(3,"Maximilian", 9),
        }.AsQueryable();
    }
}
