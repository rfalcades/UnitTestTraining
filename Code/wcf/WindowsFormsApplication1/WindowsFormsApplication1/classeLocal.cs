using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class classeLocal
    {
        public string GetNomeFinal(ServiceReference1.IService1 objLocal, string identificador)
        {
            string ValorLocal = objLocal.GetData(Convert.ToInt32(identificador));
            return ValorLocal + "/0001";
        }
    }
}
