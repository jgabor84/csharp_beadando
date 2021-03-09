using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    class BitClass
    {
        private BitArray bitek1;
        private BitArray bitek2;
        private BitArray eredmeny;


        public BitArray Bitek1 { get; set; }
        public BitArray Bitek2 { get; set; }
        public BitArray Eredmeny { get; set; }

        public BitClass()
        {
            Bitek1 = new BitArray(20);
            Bitek2 = new BitArray(20);
            Eredmeny = new BitArray(20);
            Bitek1.SetAll(false);
            Bitek2.SetAll(false);
            Eredmeny.SetAll(false);
        }
       
        
        

       

        public void szamolAnd()
        {
            Eredmeny = Bitek1.And(Bitek2);
            
        }
        public void szamolOr()
        {
            Eredmeny = Bitek1.Or(Bitek2);

        }
        public void szamolXor()
        {
            Eredmeny = Bitek1.Xor(Bitek2);

        }
        public void szamolClone()
        {
            Eredmeny = (BitArray)Bitek1.Clone();
        }
    }
}
