using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileTickets.Web.Repositorios
{
    public interface IDao<T>
    {
        IList<T> Todos();
        T Selecione(T pObject);
        void Atualiza(T pObject);
        void Cadastra(T pObject);
        void Apaga(T pObject);
    }
}