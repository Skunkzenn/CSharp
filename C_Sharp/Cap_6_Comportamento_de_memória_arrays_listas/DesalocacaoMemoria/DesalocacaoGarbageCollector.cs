using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_C_.DesalocacaoMemoria
{
    class DesalocacaoGarbageCollector
    {
        Product p1, p2;

        //Quando fazemos isso, nos temos no stack o endereço de memória que estão apontando para os objetos criados no heap
        p1 = new Product("TV", 900.00, 0);
        p2 = new Product("Mouse", 30.00, 0);

        //Aprendemos que ao fazer isso, fazemos o p1 apontar para onde o p2 aponta, p1 vai perder toda a referência para ele, assim o garbage collector vai dectar que ele nao tem mais referencia e vai entender que no futuro ele será desalocado
        p1 = p2;
    }
}
