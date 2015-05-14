using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyTree.Models
{
    public class Relationship
    {
        public int Id { get; set; }
        public virtual List<Individual> Individuals { get; set; }
        public List<Family> Families { get; set; }
    }
}