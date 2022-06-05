using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Genericos
    {
        private int _Id;
        private string _Nombre;
        private int _IsActivo;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public int IsActivo
        {
            get
            {
                return _IsActivo;
            }

            set
            {
                _IsActivo = value;
            }
        }
    }
}
