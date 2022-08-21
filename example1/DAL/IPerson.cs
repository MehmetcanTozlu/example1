using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPersonManager
    {
        public void insertion(Person person);
        public void update(Person person);
        public void delete(int id);
        public List<Person> GetPersonDetails();
    }
}
