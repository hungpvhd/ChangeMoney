using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeMoney.Data
{
    public class ChangeCurrencycs
    {
        [Key]
        public int Id { get; set; }
        public String Currrency { get; set; }
        public long ratio { get; set; }
    }
}
