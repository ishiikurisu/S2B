using System.Collections.Generic;

namespace RevisaoTopicosEssenciais
{
    class ManipuladorFTP<T> : IArmazenador<T>, IRecuperador<T> 
    {
        private List<T> Lista = new List<T>();

        public void Armazenar(T item)
        {
            Lista.Add(item);
        }

        public T Recuperar(int codigo)
        {
            return Lista[codigo];
        }
    }
}
