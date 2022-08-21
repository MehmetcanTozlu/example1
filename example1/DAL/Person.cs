using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string birtDate { get; set; }
        public bool isLive { get; set; }
    }
}
