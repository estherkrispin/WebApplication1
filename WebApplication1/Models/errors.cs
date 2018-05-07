using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class errors
    {
        private int error_code;
        private String massage;

        public errors() { error_code = 0; massage = ""; }        

        public int Error_code { get => error_code; set => error_code = value; }
        public string Massage { get => massage; set => massage = value; }
    }
}