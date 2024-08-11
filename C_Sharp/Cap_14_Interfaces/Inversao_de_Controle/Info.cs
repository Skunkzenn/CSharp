/* 
 * Invers�o de controle
        Padr�o de desenvolvimento que consiste em retirar da classe a
        responsabilidade de instanciar suas depend�ncias.

� Inje��o de depend�ncia
        � uma forma de realizar a invers�o de controle: um componente externo
        instancia a depend�ncia, que � ent�o injetada no objeto "pai". Pode ser
        implementada de v�rias formas:
� Construtor
� Objeto de instancia��o (builder / factory)
� Container / framework

Quando temos um servi�o diretamente ligado a um contrato direto, passamos a ter
um acoplamento forte, pois teremos uma depend�ncia concreta sob a classe.
Se a classe completa mudar, � preciso mudar a a classe que est� a utilizar suas defini��es.

*/

class RentalService
{
    (...)
private BrazilTaxService _brazilTaxService = new BrazilTaxService();

    /* 
    � Acoplamento fraco
    � A classe RentalService n�o conhece a depend�ncia concreta
    � Se a classe concreta mudar, a classe RentalService n�o muda nada
    */

    class RentalService
    {
        (...)
private ITaxService _taxService;

        /* 
       Inje��o de depend�ncia por meio de construtor, com o exemplo do usa da classe RentalService
       */

        class Program
        {
            static void Main(string[] args)
            {
                (...)
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());


        class RentalService
            {
                private ITaxService _taxService;
                public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
                {
                    PricePerHour = pricePerHour;
                    PricePerDay = pricePerDay;
                    _taxService = taxService;
                }