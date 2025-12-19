public class Printer
{

    protected virtual void printSuperior()
    {
        System.Console.WriteLine("A seguir a mensagem: ");
    }

    protected virtual void printInferior()
    {
        System.Console.WriteLine("");
    }

    public void Print(string mensagem)
    {
        printSuperior();
        System.Console.WriteLine(mensagem);
        printInferior();
    }
}