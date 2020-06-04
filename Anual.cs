namespace Polimorfismo02
{
    public class Anual : Relatorio
    {
         public override void MostrarRelatorio(){
             base.MostrarRelatorio();
             System.Console.WriteLine("Mostrando relatório anual: ");
             //puxando tudo da classe pai, por isso no resultado aparece o relatorio anual o geral tambem
         }
         
    }
}