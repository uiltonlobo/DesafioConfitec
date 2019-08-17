namespace DesafioConfitec.Business.Service
{
    public interface IOperacoesService
    {
         double Somar(double valor1, double valor2);
         double Subtrair(double valor1, double valor2);
         double Multiplicar(double valor1, double valor2);
         double Dividir(double valor1, double valor2);
    }
}