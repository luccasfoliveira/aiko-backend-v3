using System;
using TheatricalPlayersRefactoringKata.Application.Entitties.Types;

namespace TheatricalPlayersRefactoringKata.Application.UseCases.Factory;
public static class PlayTypeFactory
{
    public static PlayType Create(string type)
    {
        return type switch
        {
            "tragedy" => new Tragedy(),
            "comedy" => new Comedy(),
            "history" => new Historical(),
            _ => throw new ArgumentException("Unknown play type", nameof(type))
        };
    }
}