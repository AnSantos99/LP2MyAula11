using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    /// <summary>
    /// Struct to test out selfmade indexers
    /// </summary>
    public struct MyVector
    {
        // Propriedades de escrita e leitura
        public float X { get; set; }
        public float Y { get; set; }

        // Construtor que aceita dois parametros do tipo float
        public MyVector(float x, float y) 
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Indexer do tipo int que guarda os numeros passados no
        /// seu specifico index e retorna-os
        /// </summary>
        /// <param name="index"> Indexer do tipo int</param>
        /// <returns></returns>
        public float this[int index] 
        {
            get 
            {
                if(index == 0) { return X; }
                else if(index == 1) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }

            set 
            {
                if (index == 0) X = value;
                else if (index == 1) Y = value;
                else { throw new IndexOutOfRangeException(); }
            }
        }

        /// <summary>
        /// Indexer com do tipo leitura e escrita do tipo string que
        /// aceita a string e retorna-a.
        /// </summary>
        /// <param name="index"> indexer do tipo string</param>
        /// <returns></returns>
        public float this[string index]
        {
            get
            {
                string a = "xa0";
                string b = "yb1";
                if (a.Contains(index.ToLower())) { return X; }
                else if (b.Contains(index.ToLower())) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }

            set
            {
                string a = "xa0";
                string b = "yb1";

                if (a.Contains(index.ToLower())) X = value;
                else if (b.Contains(index.ToLower())) Y = value;
                else { throw new IndexOutOfRangeException(); }
            }


        }
    }
}
