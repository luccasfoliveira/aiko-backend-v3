using TheatricalPlayersRefactoringKata.Core.Entitties;
using TheatricalPlayersRefactoringKata.Core.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.Services;
public class PlayCalculator : IPlayCalculator
{
    public decimal CalculateAmount(Performance performance, Play play) =>
        play.Type.CalculateAmount(performance, play.Lines);

    public int CalculateCredits(Performance performance, Play play) =>
        play.Type.CalculateCredits(performance);
}