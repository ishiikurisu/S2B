using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static UI ui;

        static void Main(string[] args)
        {
            if (ui == null)
            {
                ui = new UI();
                for (ui.Setup(); ui.Loop(););
            }
        }
    }
}
