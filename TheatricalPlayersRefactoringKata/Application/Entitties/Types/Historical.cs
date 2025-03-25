namespace TheatricalPlayersRefactoringKata.Application.Entitties.Types;

public class Historical : PlayType
{
    public override decimal CalculateAmount(Performance performance, int lines)
    {
        var tragedy = new Tragedy().CalculateAmount(performance, lines);
        var comedy = new Comedy().CalculateAmount(performance, lines);
        return tragedy + comedy;
    }

    public override int CalculateCredits(Performance performance) =>
        new Tragedy().CalculateCredits(performance) + new Comedy().CalculateCredits(performance);
}