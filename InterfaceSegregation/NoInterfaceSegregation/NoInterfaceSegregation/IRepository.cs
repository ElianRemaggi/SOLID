using System;

namespace NoInterfaceSegregation
{
    public interface IRepository
    {
        //Esto es lo que se conoce como una super clase.
        //Si bien se puede aplicar, rompe el principio de segregacion de interfaces
        void Update();
        void Create();
        void Remove(int id);
        void Get(int id);
        void GetAll();
    }
}
