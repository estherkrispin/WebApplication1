using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class data
    {
        private List<Diamond> diamonds;
        public data() => diamonds = new List<Diamond>();

        public List<Diamond> Diamonds { get => diamonds; set => diamonds = value; }
        
    }
}