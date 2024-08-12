using System;
using System.Collections.Generic;

namespace Course.Services {
    class CalculationService {

        //Funcao que acho o valor maior da função do tipo <T>
        //Os tipos do elemento dessa lista tem de permitir você comparar um com o outro

        // MÉTODO GENÉRICO
        public T Max<T>(List<T> list) where T : IComparable  {
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++) {
                //posicao é maior que max? ter atenção a sintaxe sobre o > 0!
                if (list[i].CompareTo(max) > 0) {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
