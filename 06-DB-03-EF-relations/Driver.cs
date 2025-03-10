using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DB_03_EF_relations
{
    class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int CarId { get; set; } //pro lazy loading

        [ForeignKey("CarId")]
        public Car? Car { get; set; }

    }
}
