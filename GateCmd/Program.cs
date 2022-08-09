using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateCmd
{
    /// <summary>
    ///  Клиентский код
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}
