using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Log : EntityBase, IDatabase
    {
        [Required]
        public int ID { get; set; }
        public User User { get; set; }
        public LogAction Action { get; set; }
        public string Description { get; set; }

    }
}
