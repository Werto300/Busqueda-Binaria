using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
    class Vector
    {
        public int comparemos = -1;
        public int[] _vector;
        public int tamaño { get; set; }
        public int limite { get; set; }
        public int limitInfe = 0, limitSuper = 0, comparaciones = -1;

        public Vector(int tamaño, int limite)
        {
            this.tamaño = tamaño;
            this.limite = limite;
            _vector = new int[tamaño];
        }

        public void llenar()
        {
            Random rnd = new Random();
            for (int i = 0; i < _vector.Length; i++)
            {
                _vector[i] = rnd.Next(0, limite + 1);
            }
        }


        public void ordenar()
        {
            Array.Sort(_vector);
        }

        public int busqueda(int num)
        {
            limitSuper = _vector.Length - 1;
            int salida = -1;
            while (limitInfe <= limitSuper)
            {
                comparemos = (limitSuper + limitInfe) / 2;
                comparaciones++;
                if (_vector[comparemos] == num)
                {
                    salida = comparemos;
                    break;
                }

                if (_vector[comparemos] < num)
                {
                    limitInfe = comparemos + 1;
                }
                else
                {
                    limitSuper = comparemos - 1;
                }
            }

            return salida;
        }

        public override string ToString()
        {
            string salida = "";

            for (int i = 0; i < _vector.Length; i++)
            {
                salida += "[" + i + "] = " + _vector[i].ToString() + Environment.NewLine;
            }

            return salida;
        }
    }
}
