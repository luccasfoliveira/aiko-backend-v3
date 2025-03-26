using TheatricalPlayersRefactoringKata.Core.Entitties;

namespace TheatricalPlayersRefactoringKata.Core.Entitties.Types;

public class Tragedy : PlayType
{
    public override decimal CalculateAmount(Performance performance, int lines)
    {
        var thisAmount = lines * 10;
        if (performance.Audience > 30)
        {
            thisAmount += 1000 * (performance.Audience - 30);
        }
        return thisAmount;
    }
}