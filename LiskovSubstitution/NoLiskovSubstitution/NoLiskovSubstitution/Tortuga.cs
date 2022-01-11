using System;
using System.Collections.Generic;
using System.Text;

namespace NoLiskovSubstitution
{
    class Tortuga : IAnimal
    {
        public void Hunt()
        {
            // No se tendria que poder implementar Rompe el principio
        }

        public void Run()
        {
            // No se tendria que poder implementar Rompe el principio
        }

        public void Walk()
        {
            //Se puede implementar
        }
    }
}
