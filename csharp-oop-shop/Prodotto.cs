using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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

       
        

        //PROPERTIES

        public string Name { get; set; }
        public string Description { get; set; }
        public float Prezzo { get; set; }

        
        public int Code { get; }
             

        private float Iva { get; set; }

        //private string formattedCode;
        //CONSTRUCTOR
        public Prodotto(string name, string description, float prezzo)
        {
            Name = name;
            this.Description = description;
            this.Prezzo = prezzo;
            Code = RandomGen();
            Iva = 1.22f;
            //formattedCode = FormattedNum();

        }


            

        //METHODS

        private int RandomGen() //questo metodo dovrebbe generare un random int e trasformarlo in string con il pad adatto e poi restituirlo
        {
            Random rnd = new Random();
            int codeInt = rnd.Next(1, 100000000);
            return codeInt;
           
        }

        public string FormattedNum()
        {
            int padding = 0;
            padding = Code.ToString().Length;
            padding = 8 - padding;
            string zeros = "";
            
            for ( int i = 0; i < padding; i++ )
            {
                zeros += "0";

            }

            zeros = zeros + Code;
            return zeros;

        }

        public string CodeName()
        {
            string codeName = FormattedNum() + Name;
            return codeName;
        }

      

        float PrezzoBase()
        {
            return Code;
        }

        float PrezzoIva()
        {
            return Code * Iva;
        }
        
    }
}
