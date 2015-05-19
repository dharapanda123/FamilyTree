using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamilyTree.Models
{
    public class Individual
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Date_Of_birth { get; set; }
        public string Place_Of_Birth { get; set; }
        public virtual List<Relationship> Relations { get; set; }
        
     
      
        
    }
}