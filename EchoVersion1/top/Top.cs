using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoVersion1.top
{
    public class Top
    {
        private static Top instance;

        private static Top()
        {

        }


        public Top Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Top();
                return instance; 
            }
            
        }

        public void biloSta()
        {

        }
        



    }
}
