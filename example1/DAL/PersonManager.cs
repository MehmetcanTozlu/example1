using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonManager : IPersonManager
    {
        readonly DBContextClass _dbContext;
        public PersonManager(DBContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public void delete(int id)
        {
            Person person = _dbContext.Set<Person>().Find(id);
            person.isLive = false;
            _dbContext.Update(person);
            //_dbContext.Remove(person);
            _dbContext.SaveChanges();
            //try
            //{
            //    Person? person = _dbContext.persons.Find(id);
            //    if(person != null)
            //    {
            //        _dbContext.persons.Remove(person);
            //        _dbContext.SaveChanges();
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
        }

        public List<Person> GetPersonDetails()
        {
            try
            {
                return _dbContext.persons.ToList();
            }
            catch 
            {
                throw;
            }
        }

        public void insertion(Person person)
        {
            try
            {
                _dbContext.persons.Add(person);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void update(Person person)
        {
            try
            {
                _dbContext.Update(person);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
