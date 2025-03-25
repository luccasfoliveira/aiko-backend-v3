using System;
using TheatricalPlayersRefactoringKata.Application.Entitties.Types;

namespace TheatricalPlayersRefactoringKata;

public class Play
{
    public string Name { get; }
    public int Lines { get; }
    public PlayType Type { get; }

    public Play(string name, int lines, PlayType type)
    {
        Name = name;
        Lines = Math.Clamp(lines, 1000, 4000);
        Type = type;
    }
}