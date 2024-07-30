using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicios.Entities
{                               //Exibirá o erro a dizer que é impossível herdar uma classe selada
                                //Serve para proteger quando não queremos que uma classe seja herdada
    internal class SavingAccountPlus : SavingsAccount
    {
    }
}
