using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MyController : ApiController
    {
        //TODO check how to make it constant
        private static String[] legal_shape =  {"Round", "Pear", "Princess", "Marquise", "Sq. Emerald", "Oval", "Radiant", "Emerald",
                    "Trilliant", "Heart", "European Cut", "Old Miner", "Flanders", "Cushion Brilliant", "Cushion Modified"};

        // GET: api/Default/5
        /*
         * [HttpGet]
         * [Route("api/Diamond")]
         * implementation for website
         */
        public response GetDiamonds(String shape, decimal fromSize, decimal toSize)
        {
            return GetResponse(shape, fromSize, toSize);
        }

        /*
         * [HttpGet]
         * [Route("api/MobileDiamond")]
         * implementation for mobile
        */
        //public responseForMobile GetDiamondsForMobile(String shape, decimal fromSize, decimal toSize)
        //{
        //    return new responseForMobile(GetResponse(shape, fromSize, toSize));
        //}
        

        /**
         * the main function that get the arguments and return the proper diamonds collection
         * */
        private response GetResponse(String shape, decimal fromSize, decimal toSize)
        {
            response response = new response();
            if(fromSize > toSize)
            {
                response.Errors.Error_code = 0;
                response.Errors.Massage = "Illegal size. from is bigger than to";
                return response;
            }
            if (!legal_shape.Contains(shape))
            {
                response.Errors.Error_code = 1;
                response.Errors.Massage = "Illegal shape: " + shape ;
                return response;
            }
            IList<Diamond> diamondCollection = ReadJSON.PageLoad();

            foreach (Diamond d in diamondCollection)
                if (d.Shape.Equals(shape) && fromSize <= d.Weight && d.Weight <= toSize)
                    response.Data.Diamonds.Add(d);

            return response;
        }
        
    }
}
