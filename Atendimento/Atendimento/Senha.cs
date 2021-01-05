using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public int Id
        {
            get { return id; }
        }
        public DateTime DataGerac
        {
            get { return dataGerac; }
        }
        public DateTime HoraGerac
        {
            get { return horaGerac; }
        }
        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }
        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Today;
            horaGerac = new DateTime(DateTime.Now.Ticks - DateTime.Today.Ticks);
            dataAtend = new DateTime(0);
            horaAtend = new DateTime(0);
        }

        public string dadosParciais()
        {
            return this.Id.ToString() + " - " +
                    this.DataGerac.ToShortDateString() + " - " +
                    this.HoraGerac.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return this.dadosParciais() + 
                this.DataAtend.ToShortDateString() + " - " +
                this.HoraAtend.ToLongTimeString();
        }

    }
}
