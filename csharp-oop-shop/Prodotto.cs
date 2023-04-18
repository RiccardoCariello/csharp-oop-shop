using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        //attributi
        /*
        private int code;
        private string name;
        private string description;
        private float prezzo;
        private int iva;
        */

        public string Name { get; set; }
        public string Description { get; set; }
        public float Prezzo { get; set; }

        private int code;
        private int iva;
        //PROPERTIES

        


        //CONSTRUCTOR
        public Prodotto(string name, string description, float prezzo)
        {
            
            

        }


            

        //METHODS

        private string CodeFormatter()
        {
            Random rnd = new Random();
            this.code = rnd.Next(1, 100000000);

            string code = this.code.ToString("D8");
            
            return code;
        }
    }
}
