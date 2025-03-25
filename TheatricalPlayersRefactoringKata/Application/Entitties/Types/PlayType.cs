using System;

namespace TheatricalPlayersRefactoringKata.Application.Entitties.Types;

public abstract class PlayType
{
    public abstract decimal CalculateAmount(Performance performance, int lines);
    public virtual int CalculateCredits(Performance performance) =>
        Math.Max(performance.Audience - 30, 0);
}