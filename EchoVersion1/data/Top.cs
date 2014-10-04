using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoVersion1.data
{
    public sealed class Top
    {
        private static Top instance = null;


        public static Top Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Top();
                return instance; 
            }
            
        }

        
        



    }
}
