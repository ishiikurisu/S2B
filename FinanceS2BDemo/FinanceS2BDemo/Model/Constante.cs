using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace FinanceS2BDemo.Model
{
    public class Constante
    {
        public static string DataBasePath = Path.Combine(new[]
        {
            ApplicationData.Current.LocalFolder.Path,
            "database",
            "GerenciadorFinanceiro.sqlite"
        });
    }
}
