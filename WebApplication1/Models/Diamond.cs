using System;

namespace WebApplication1.Models
{
    public class Diamond
    {
        private int diamondID;
        private String shape, color, Clarity;
        private decimal weight;
        
        public int DiamondID { get => diamondID; set => diamondID = value; }
        public string Shape { get => shape; set => shape = value; }
        public string Color { get => color; set => color = value; }
        public string Clarity1 { get => Clarity; set => Clarity = value; }
        public decimal Weight { get => weight; set => weight = value; }
        
    }
}