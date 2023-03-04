using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzWebApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string quizzQuestion { get; set; }
        public string quizzAnswer { get; set; }

        public Question()
        {
                
        }
    }
}
