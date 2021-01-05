using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento
        {
            get { return proximoAtendimento; }
        }

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
        }

        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            proximoAtendimento = 1;
        }

        public void gerar()
        {
            filaSenhas.Enqueue(new Senha(proximoAtendimento++));
        }
    }
}
