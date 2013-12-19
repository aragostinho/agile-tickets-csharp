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

        public virtual bool PossuiVagas(int qtd, int qtdMinimaDeVagas)
        {
            if (!PossuiQtdeMinimaDeVagas(Sessoes, qtdMinimaDeVagas))
                return false;

            int totalDisponivel = ObterTotalDisponivel();
            return (totalDisponivel >= qtd);
        }

        private bool PossuiQtdeMinimaDeVagas(IList<Sessao> olSessao, int qtdMinimaDeVagas)
        {
            foreach (Sessao s in olSessao)
            {
                if (s.IngressosDisponiveis < qtdMinimaDeVagas) return false;

            }
            return true;
        }

        public virtual bool PossuiVagas(int qtdDeVagasRequisitadas)
        {
            // ALUNO: Não apague esse metodo. Esse sim será usado no futuro! ;)
            int totalDisponivel = ObterTotalDisponivel();
            return (totalDisponivel >= qtdDeVagasRequisitadas);
        }

        private int ObterTotalDisponivel()
        {
            int totalDisponivel = 0;
            foreach (Sessao s in Sessoes)
            {
                totalDisponivel += s.IngressosDisponiveis;
            }
            return totalDisponivel;
        }
    }
}