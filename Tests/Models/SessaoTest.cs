using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AgileTickets.Web.Models;

namespace Tests.Models
{
    [TestFixture]
    public class SessaoTest
    {
        [Test]
        public void DeveVender1IngressoSeHa2Vagas()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 2;

            Assert.IsTrue(sessao.PodeReservar(1));
        }

        [Test]
        public void Reservar2IngressosQuandoHa1Vaga()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 1;

            Assert.IsFalse(sessao.PodeReservar(2));
        }

        [Test]
        public void ReservarNenhumIngressoQuandoHa3Vagas()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 3;

            Assert.IsFalse(sessao.PodeReservar(0));
        }

        [Test]
        public void Reservar2IngressosQuandoNaoHaVagas()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 0;

            Assert.IsFalse(sessao.PodeReservar(2));
        }

        [Test]
        public void Reservar2IngressosQuandoHa2Vagas() {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 2;

            Assert.IsTrue(sessao.PodeReservar(2));
        }

        [Test]
        public void NaodeveVender3IngressoSeHa2Vagas()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 2;

            Assert.IsFalse(sessao.PodeReservar(3));
        }

        [Test]
        public void ReservarIngressosDeveDiminuirONumeroDeIngressosDisponiveis()
        {
            Sessao sessao = new Sessao();
            sessao.TotalDeIngressos = 5;

            sessao.Reserva(3);
            Assert.AreEqual(2, sessao.IngressosDisponiveis);
        }
    }
}
