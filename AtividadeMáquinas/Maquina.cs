public class Maquina
{
    public string Produto;
    public int ProducaoPorDia;
    public string Alimentacao;

    public Maquina()
    {
        
    }

    public Maquina(string produto, int producao, string alimentacao)
    {
        Produto = produto;
        ProducaoPorDia = producao;
        Alimentacao = alimentacao;
    }

    public void Manutencao()
    {
        ProducaoPorDia -= 2;
        Console.WriteLine($"A maquina que produz {Produto}, agora faz {ProducaoPorDia} peças por dia.");
    }
}