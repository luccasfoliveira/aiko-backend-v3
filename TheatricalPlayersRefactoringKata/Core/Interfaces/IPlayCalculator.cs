using TheatricalPlayersRefactoringKata.Core.Entitties;

namespace TheatricalPlayersRefactoringKata.Core.Interfaces;

public interface IPlayCalculator
{
    decimal CalculateAmount(Performance performance, Play play);
    int CalculateCredits(Performance performance, Play play);
}