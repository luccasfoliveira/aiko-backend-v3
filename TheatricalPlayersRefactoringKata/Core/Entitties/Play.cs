using System;
using TheatricalPlayersRefactoringKata.Application.Services.Factory;
using TheatricalPlayersRefactoringKata.Core.Entitties.Types;

namespace TheatricalPlayersRefactoringKata.Core.Entitties;

public class Play
{
    public string Name { get; }
    public int Lines { get; }
    public PlayType Type { get; }

    public Play(string name, int lines, string type) =>
        (Name, Lines, Type) = (name, Math.Clamp(lines, 1000, 4000), PlayTypeFactory.Create(type));
}