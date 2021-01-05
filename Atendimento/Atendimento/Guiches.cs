using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atendimento
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
        }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void adicionarGuiche(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
    }
}
