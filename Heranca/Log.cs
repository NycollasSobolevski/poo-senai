public class Log : Printer
{

    protected override void printSuperior()
    {
        System.Console.WriteLine("----------- Print ------------");
    }
    
    protected override void printInferior()
    {
        System.Console.WriteLine("----------- ----- ------------");
    }

    public void Danger (string mensagem)
    {
        System.Console.Write("ERRO: ");
        System.Console.Write( mensagem + " ");
        System.Console.WriteLine(DateTime.Now.ToString());
    }

    public void Warning (string mensagem)
    {
        System.Console.Write("Alerta: ");
        System.Console.Write( mensagem + " ");
        System.Console.WriteLine(DateTime.Now.ToString());
    }
    public void Info (string mensagem)
    {
        System.Console.Write("Informacao: ");
        System.Console.Write( mensagem + " ");
        System.Console.WriteLine(DateTime.Now.ToString());
    }

}