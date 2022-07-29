Console.Write("Tempo: ");
var tempo = Console.ReadLine();
int tempoInt = int.Parse(tempo);
tempoInt = 60 / tempoInt;
tempoInt = tempoInt * 1000;
int tic = 0;
while (true)
{
    //use the tempo to wait
    System.Threading.Thread.Sleep(tempoInt);
    Console.Beep(1000, 100);
}