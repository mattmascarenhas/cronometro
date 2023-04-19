Menu();
//Start(5);

static void Menu()
{
  string data = ""; // valor que o usuario digitp Ex: 40s
  char type = '\0'; // valor do ultimo elemento que o usuario digita
  int time = 0; //valor so com o numero inteiro
  int multiplier = 1; //se for S = 1, se for M = 60
  Console.Clear();
  Console.WriteLine("-------------------------");
  Console.WriteLine("Instruções");
  Console.WriteLine("S - Segundos");
  Console.WriteLine("M - Minutos");
  Console.WriteLine("E - Sair");
  Console.WriteLine("-------------------------");
  Console.WriteLine("Quanto tempo deseja contar?");

  data = Console.ReadLine().ToLower(); // ToLower() converte tudo para minusculo
  type = char.Parse(data.Substring(data.Length - 1, 1)); // substring pega uma quantidade de elementos de uma string de uma determinada posição
  //utilizando o data.Length - 1 ele vai pegar o utltimo elemento da string
  time = int.Parse(data.Substring(0, data.Length - 1)); // captura todos os elementos da string menos o ultimo

  if (type == 'm')
  {
    multiplier = 60;
  }

  PreStart(time * multiplier);
}

static void PreStart(int time)
{
  Console.Clear();
  Console.WriteLine("...1");
  Thread.Sleep(1000);
  Console.WriteLine("...2");
  Thread.Sleep(1000);

  Console.WriteLine("...3 e já!");
  Thread.Sleep(1000);
  Start(time);
}

static void Start(int time)
{
  int currentTime = 0;

  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
  Console.Clear();
  Console.WriteLine("Cronometro finalizado!");
  Thread.Sleep(3000);
  Menu();
}