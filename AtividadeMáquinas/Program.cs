//Tendo uma linha de produção, faça um script onde
//  calculará quantos produtos será produzidos por dia
//  depois de 20 (vinte dias), onde a cada 2 dias uma 
//  máquina aleatória sofre uma manutenção, onde há uma
//  perda de desempenho de 2 peças/dia na manutenção.
// A Classe Maquina tem que ter os seguintes atributos e 
// métodos:

// - string Produto ("Parafuso")
// - int ProducaoPorDia (350)
// - string Alimentacao (Diesel)
// - void Manutencao().

Random random = new Random();

Maquina m1 = new Maquina("Parafuso", 200, "Eletricidade");
Maquina m2 = new Maquina("Prego", 300, "Eletricidade");
Maquina m3 = new Maquina("Fuso", 50, "Diesel");

Maquina[] Fabrica = [m1, m2, m3];

int Produzidos = 0;

for(int i = 0; i < 20; i++)
{
    Produzidos += Fabrica[0].ProducaoPorDia;
    Produzidos += Fabrica[1].ProducaoPorDia;
    Produzidos += Fabrica[2].ProducaoPorDia;

    if((i % 2) == 0)
    {
        int index = random.Next(0, 3);
        Fabrica[index].Manutencao();
    }
}

int ProducaoAtualPorDia = Fabrica[0].ProducaoPorDia;
ProducaoAtualPorDia += Fabrica[1].ProducaoPorDia;
ProducaoAtualPorDia += Fabrica[2].ProducaoPorDia;

Console.WriteLine($"Producao atualé de {ProducaoAtualPorDia} peças");