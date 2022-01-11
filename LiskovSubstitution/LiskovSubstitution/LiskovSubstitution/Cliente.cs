using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution
{
    class Cliente
    {
        Tiger tiger;
        elephant ele;

        public void main()
        {
            tiger = new Tiger();
            ele = new elephant();

            IList<IRun> list = new List<IRun>();
            list.Add(tiger);
            list.Add(ele);

            foreach(var animal in list)
            {
                animal.run();
            }
        }
    }
}
