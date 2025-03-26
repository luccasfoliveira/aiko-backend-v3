using System;
using TheatricalPlayersRefactoringKata.Core.Entitties.Types;

namespace TheatricalPlayersRefactoringKata.Application.Services.Factory;
public static class PlayTypeFactory
{
    public static PlayType Create(string type) =>
        type.ToLower() switch
        {
            "tragedy" => new Tragedy(),
            "comedy" => new Comedy(),
            "history" => new Historical(),
            _ => throw new ArgumentException("Unknown play type", nameof(type))
        };
}