using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class response
    {
        private errors errors;
        private data data;

        public response() { errors = new errors(); data = new data(); }

        public errors Errors { get => errors; set => errors = value; }
        public data Data { get => data; set => data = value; }
    }

    public class responseForMobile
    {
        private errors errors;
        private dataForMobile data;

        public responseForMobile(response r) { errors = r.Errors; data = ChangeDataForMobile(r); }

        public errors Errors { get => errors; set => errors = value; }
        public dataForMobile Data { get => data; set => data = value; }

        /*
         * This function get regular response object that fits for a website version and return
         * the part of the data to be returned in a mobile version
         * */
        public dataForMobile ChangeDataForMobile(response response)
        {
            dataForMobile data = new dataForMobile();

            foreach(Diamond d in response.Data.Diamonds)
                data.Diamonds.Add(new DiamondForMobile(d));

            return data;
        }

        public class dataForMobile
        {
            private List<DiamondForMobile> diamonds;
            public dataForMobile() => diamonds = new List<DiamondForMobile>();


            public List<DiamondForMobile> Diamonds { get => diamonds; set => diamonds = value; }
        }


        public class DiamondForMobile
        {
            private int diamondID;
            private String shape;
            private decimal weight;

            public DiamondForMobile(Diamond d)
            {
                diamondID = d.DiamondID;
                shape = d.Shape;
                weight = d.Weight;
            }

            public int DiamondID { get => diamondID; set => diamondID = value; }
            public string Shape { get => shape; set => shape = value; }
            public decimal Weight { get => weight; set => weight = value; }
        }


    }

}