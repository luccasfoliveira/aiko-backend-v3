using TheatricalPlayersRefactoringKata.Application.Entitties;

namespace TheatricalPlayersRefactoringKata.Application.Interfaces;

public interface IPlayCalculator
{
    decimal CalculateAmount(Performance performance, Play play);
    int CalculateCredits(Performance performance, Play play);
}