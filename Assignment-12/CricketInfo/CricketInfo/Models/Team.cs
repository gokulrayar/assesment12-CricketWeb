using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CricketInfo.Models
{
    public class Team
    {
        [Key ]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NOWC { get; set; }

    }
}