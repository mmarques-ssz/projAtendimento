using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
            set { atendimentos = value; }
        }

        public Guiche()
            : this(0)
        {
        }

        public Guiche(int id)
        {
            this.id = id;
            atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            bool temSenha;
            Senha senhaAtendida;

            temSenha = (filaSenhas.Count > 0);
            if (temSenha)
            {
                senhaAtendida = filaSenhas.Dequeue();
                senhaAtendida.DataAtend = DateTime.Today;
                senhaAtendida.HoraAtend = new DateTime(DateTime.Now.Ticks - DateTime.Today.Ticks);
                atendimentos.Enqueue(senhaAtendida);
            }
            return temSenha;            
        }

    }
}
