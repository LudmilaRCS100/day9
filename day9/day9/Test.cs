using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    class Test
    {
        public int skaitlis;

        private int Privatais1;

        public int Get()
        {
            
            return Privatais1;
        }

        private void Sent (int value)
        {
            if (value != 0)
            {
                Privatais1 = value;
            }
            else
            {
                Privatais1 = 1;
            }


            
        }
        

        
        


        

    }

       
    

        
        

        
}
