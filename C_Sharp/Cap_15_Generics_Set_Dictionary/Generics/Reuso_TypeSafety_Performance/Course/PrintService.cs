using System;

namespace Course {
    class PrintService<T> {

        //Variável para armazenar o numero total de valores no array
        private T[] _values = new T[10];

        //Variável para contagem dos inteiros adicionados
        private int _cont = 0;

        public void AddValue(T value) {
            //se o valor for = 10 será sinal que o vetor está cheio
            if (_cont == 10) {
                throw new InvalidOperationException("PrintService is full");
            }
            //Primeiro ciclo, o vetor vai estar na posição 0, assim por diante...
            _values[_cont] = value;
            _cont++; //Atualizar o valor do count no fim da execução
        }

        public T First {
            if(_count == 0){
                throw new InvalidOperationException("PrintService is empty");
            }
            get { return _values[0]; }
        }

        public void Print() {
            Console.Write("["); // vai imprimir até a penúltima posição do vetor (_cont - 1);
            for (int i = 0; i < _cont - 1; i++) {
                Console.Write(_values[i] + ", ");
            }
            if (_cont > 0) {
                //Acessa última posição do elemento no array
                Console.Write(_values[_cont - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
