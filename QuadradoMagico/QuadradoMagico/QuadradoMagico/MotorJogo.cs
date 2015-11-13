using System.Collections;

namespace QuadradoMagico
{
    public class MotorJogo
    {
        private Hashtable sizes = new Hashtable();

        public MotorJogo()
        {
            sizes.Add("Fácil", "3");
            sizes.Add("Médio", "5");
            sizes.Add("Difícil", "7");
        }
    }
}