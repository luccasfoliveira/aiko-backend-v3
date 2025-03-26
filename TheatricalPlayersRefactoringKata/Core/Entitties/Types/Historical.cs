namespace TheatricalPlayersRefactoringKata.Core.Entitties.Types;

public class Historical : PlayType
{
    public override decimal CalculateAmount(Performance performance, int lines) =>
         CalculateTragedyComedy(performance, lines);

    private decimal CalculateTragedyComedy(Performance performance, int lines) =>
        new Tragedy().CalculateAmount(performance, lines) + new Comedy().CalculateAmount(performance, lines);
}
