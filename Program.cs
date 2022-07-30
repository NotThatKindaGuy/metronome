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
    if (tic != 0)
    {
        Console.Beep(500, 100);
        if (tic == 3)
        {
            tic = 0;
        }
        else
        {
            tic++;
        }
    }
    else
    {
        Console.Beep(1000, 100);
        tic++;
    }
}
