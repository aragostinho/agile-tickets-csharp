using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileTickets.Web.Models
{
    public class Espetaculo
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Sessao> Sessoes { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }

        public Espetaculo()
        {
            this.Sessoes = new List<Sessao>();
        }

        public virtual IList<Sessao> CriaSessoes(DateTime inicio, DateTime fim, Periodicidade periodicidade)
        {
            // ALUNO: Não apague esse metodo. Esse sim será usado no futuro! ;)
            return null;
        }

        public virtual bool PossuiVagas(int qtd, int min)
        {
            // ALUNO: Não apague esse metodo. Esse sim será usado no futuro! ;)


            int totDisp = 0;

            foreach (Sessao s in Sessoes)
            {
                if (s.IngressosDisponiveis < min) return false;
                totDisp += s.IngressosDisponiveis;
            }
            return (totDisp >= qtd);
        }

        public virtual bool PossuiVagas(int qtd)
        {
            // ALUNO: Não apague esse metodo. Esse sim será usado no futuro! ;)
            int totDisp = 0;

            foreach (Sessao s in Sessoes)
            {
                totDisp += s.IngressosDisponiveis;
            }
            return (totDisp >= qtd);
        }
    }
}