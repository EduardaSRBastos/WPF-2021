using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class ModelNotas
    {
        //Criar delegate
        public delegate void MetodosComString(string str);
        //Criar evento
        public event MetodosComString NotaAdicionada;
        public List<string> ListaNotas { get; private set; }
        public ModelNotas()
        {
            ListaNotas = new List<string>();
        }
        public void Adiciona(string nota)
        {
            ListaNotas.Add(nota);
            //Lançar event
            if (NotaAdicionada != null)
                NotaAdicionada(nota);
        }
    }
}
