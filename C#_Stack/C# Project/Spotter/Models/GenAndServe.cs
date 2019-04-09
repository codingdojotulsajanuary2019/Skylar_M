using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Spotter.Models
{
    public class GenAndServe
    {
        public List<User> PotentialBuddies;

        public GenAndServe()
        {
            PotentialBuddies = new List<User>
            {

            };
        }
    }
}