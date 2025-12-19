// Printer printer = new Printer();

// printer.Print("Hello world");

// BeaultyPrinter bPrinter = new BeaultyPrinter();
// bPrinter.Print("Hello world");

// Log l = new Log();
// l.Print("Print utilizando a classe Log");

// l.Danger("Uma execucao muito perigosa aconteceu");
// l.Warning("Um alertinha de levis");
// l.Info("Para sua informação, algo aconteceu");


// Demonstração de Abstract

// English e = new();
// Portuguese p = new();

// System.Console.WriteLine(e.NewGame());
// System.Console.WriteLine(p.NewGame());


// Demonstração polimorfismo
Language lang = null;

System.Console.WriteLine("Selecione a linguagem");
System.Console.WriteLine("1 - English");
System.Console.WriteLine("2 - Portugues");
int escolha = Int32.Parse(Console.ReadLine());

if(escolha == 1)
    lang = new English();
else if(escolha == 2)
    lang = new Portuguese();

System.Console.WriteLine();
System.Console.WriteLine(lang.NewGame());

lang = new PtBr();
System.Console.WriteLine(lang.Moca());