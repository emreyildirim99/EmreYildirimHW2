using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmreYildirimTodoWebHW.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Desc { get; set; }
    }
}
