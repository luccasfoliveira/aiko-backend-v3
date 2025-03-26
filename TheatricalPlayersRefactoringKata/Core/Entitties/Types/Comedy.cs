using TheatricalPlayersRefactoringKata.Core.Entitties;

namespace TheatricalPlayersRefactoringKata.Core.Entitties.Types;

public class Comedy : PlayType
{
    public override decimal CalculateAmount(Performance performance, int lines)
    {
        var thisAmount = lines * 10;
        if (performance.Audience > 20)
        {
            thisAmount += 10000 + 500 * (performance.Audience - 20);
        }
        thisAmount += 300 * performance.Audience;
        return thisAmount;
    }

    public override int CalculateCredits(Performance performance) =>
        base.CalculateCredits(performance) + performance.Audience / 5;
}