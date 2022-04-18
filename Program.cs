//libraries
using System.IO;
using Magnet2;

//variables for reading
Console.Write("Path to file: ");
string path = Console.ReadLine();
string line;

//variables for "Space" game + token list
string[] tokenListSpace = {
    "import Space",
    "menu(",
    "menu.ScoreCounter(",
    "menu.Go(",
    "menu.Exit(",
};
bool isRun = false;
bool isMenu = false;
bool isScoreCounter = false;
bool isGoOption = false;
bool isExitOption = false;
Space spaceGame = new Space();

//reading file
using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
{
    while ((line = sr.ReadLine()) != null)
    {
        read(line);
    }
}

//updating game
void read(string codeLine)
{
    if (codeLine.Contains(tokenListSpace[0]))
    {
        isRun = true;
    }
    else if (codeLine.Contains(tokenListSpace[1]))
    {
        string IM = codeLine.Split('(').Last();
        isMenu = bool.Parse(IM.Substring(0, IM.IndexOf(')')));
    }
    else if (codeLine.Contains(tokenListSpace[2]))
    {
        string ISC = codeLine.Split('(').Last();
        isScoreCounter = bool.Parse(ISC.Substring(0, ISC.IndexOf(')')));
    }
    else if (codeLine.Contains(tokenListSpace[3]))
    {
        string IGO = codeLine.Split('(').Last();
        isGoOption = bool.Parse(IGO.Substring(0, IGO.IndexOf(')')));
    }
    else if (codeLine.Contains(tokenListSpace[4]))
    {
        string IEO = codeLine.Split('(').Last();
        isExitOption = bool.Parse(IEO.Substring(0, IEO.IndexOf(')')));
    }
    else
        Console.WriteLine("ERROR! On the \"" + codeLine + "\" line");
}


Console.Write("Do you want to run a game? (y/n): ");
string dywrg = Console.ReadLine();

if (dywrg.Contains("y") || dywrg.Contains("Y"))
    run();
else { }

//running
void run()
{
    if (isRun)
    {
        spaceGame.game(isMenu, isScoreCounter, isGoOption, isExitOption);
    }
}