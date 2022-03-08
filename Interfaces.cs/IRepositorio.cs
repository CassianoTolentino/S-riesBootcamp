using System.Collections.Generic;

namespace DIO.Series.Interfaces.cs
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetrornaPor Id(int id);

        void Insert(T entidade); 

        void Exclui(int Id);

        void Atualiza(int id, T entidade);

        int ProximoId();   
    }
}