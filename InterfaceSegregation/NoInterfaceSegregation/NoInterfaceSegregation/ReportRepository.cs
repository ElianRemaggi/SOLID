using System;
using System.Collections.Generic;
using System.Text;

namespace NoInterfaceSegregation
{
    //Queremos implementar otro repositorio pero esta limitado a implementar métodos de lectura solo para lectura.
    public class ReportRepository : IRepository
    {
        public void Create()
        {
            throw new System.NotImplementedException(); //Esto rompe el principio
        }

        public void Update()
        {
            throw new System.NotImplementedException(); //Esto rompe el principio
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException(); //Esto rompe el principio
        }

        public void Get(int id)
        {
            // implementacion
        }

        public void GetAll()
        {
            // implementacion
        }
    }
}
