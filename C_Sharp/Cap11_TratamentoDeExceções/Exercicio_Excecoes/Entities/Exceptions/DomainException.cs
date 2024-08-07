using System;

namespace Exercicio_Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) { 
        }
    }
}