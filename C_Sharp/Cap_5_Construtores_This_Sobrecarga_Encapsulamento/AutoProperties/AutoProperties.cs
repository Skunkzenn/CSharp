/*
Propriedades autoimplementadas
• É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações get e set. */

using System.Globalization;
namespace AutoPropriedades_
{
    class AutoPropriedades
    {
        private string _nome5;
        //Podemos em uma única linha definir que o preço do produto nao sofrerá alterações
                                   // Ou seja, não é permitido para outros arquivos, alterarem o valor do preço.
                                   //Queremos para o preço apenas a operação get e a operação set, colocando o privet a frente do set, indicando que o preço não pode ser alterado pro outros arquivos
        public double Preco5 { get; private set; }
        public int Quantidade5 { get; private set; }

        public AutoPropriedades_()
        {
        }
        public AutoPropriedades_(string nome, double preco, int quantidade)
        {
            _nome5 = nome;
            Preco5 = preco;
            Quantidade5 = quantidade;
        }
        //Como o nome possuí uma lógica particular, temos que fazer a implementação manual da properties
        public string Nome
        {
            get { return _nome5; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome5 = value;
                }
            }
        }
        
    }
}