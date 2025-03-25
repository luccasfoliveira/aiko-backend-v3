using System;
using TheatricalPlayersRefactoringKata.Application.Entitties.Types;
using TheatricalPlayersRefactoringKata.Application.UseCases.Factory;

namespace TheatricalPlayersRefactoringKata.Application.Entitties;

public class Play
{
    public string Name { get; }
    public int Lines { get; }
    public PlayType Type { get; }

    public Play(string name, int lines, string type)
    {
        Name = name;
        Lines = Math.Clamp(lines, 1000, 4000);
        Type = PlayTypeFactory.Create(type);
    }
}