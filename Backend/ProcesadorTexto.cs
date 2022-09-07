using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ProcesadorTexto
    {
        public string TextoOriginal { get; set; }
        public string TextoResultado { get; set; }
        public string TextoBusqueda { get; set; }

        private int res;

        public int Buscar()
        {
            res = -1;
            string pepe = "";

            for (int i=0; i < TextoOriginal.Length; i++)
            {
                pepe = TextoOriginal.Substring(i);
                if(pepe.StartsWith(TextoBusqueda))
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public void Borrar()
        {
            //int res = Buscar();
            if (res != -1)
            {
                TextoResultado = TextoOriginal.Remove(res, TextoBusqueda.Length);
            }
            else
            {
                TextoResultado = TextoOriginal;
            }
        }
    }
}
