using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class ArrayTest
    {
        public void Test()
        {
            int[] tab = new int[5];
            tab[2] = 72;

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 2;
            }
        }
    }
}
