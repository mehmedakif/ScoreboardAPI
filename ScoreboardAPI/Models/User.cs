using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoreboardAPI.Models
{
    public class user
    {
        public string userID { get; set; }
        public int score { get; set; }
        public  int difficulty { get; set; }
        public DateTime date { get; set; }
    }
}