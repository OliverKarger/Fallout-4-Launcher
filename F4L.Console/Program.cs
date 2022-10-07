var game = new OliverKarger.F4L.Game();

var paths = game.ScanDrivesForGameExe();
foreach(var path in paths)
{
    if (path.Value)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{path.Key} {path.Value}");
        Console.ResetColor();
    } else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{path.Key} {path.Value}");
        Console.ResetColor();
    }
}