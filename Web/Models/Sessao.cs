using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTickets.Web.Models
{
    public class Sessao
    {
        public virtual int Id { get; set; }
        public virtual Espetaculo Espetaculo { get; set; }
        public virtual int TotalDeIngressos { get; set; }
        public virtual int IngressosReservados { get; set; }
        public virtual DateTime Inicio { get; set; }
        
        public virtual bool PodeReservar(int NumeroDeIngressos)
        {
            if (NumeroDeIngressos <= 0)
                return false;

            int ingressosRestantes = IngressosRestantes(IngressosDisponiveis, NumeroDeIngressos);
            return ingressosRestantes >= 0;
        }

        private int IngressosRestantes(int pIngressosDisponiveis, int pNumeroDeIngressos)
        {
            return pIngressosDisponiveis - pNumeroDeIngressos;
        }


        public virtual int IngressosDisponiveis
        {
            get
            {
                return TotalDeIngressos - IngressosReservados;
            }
        }


        public virtual void Reserva(int quantidade)
        {
            this.IngressosReservados += quantidade;
        }
    }
}
