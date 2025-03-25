using System;
using TheatricalPlayersRefactoringKata.Application.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases;
public class PlayCalculator : IPlayCalculator
{
    public decimal CalculateAmount(Performance performance, Play play) => 
        play.Type.CalculateAmount(performance, play.Lines);

    public int CalculateCredits(Performance performance, Play play) =>
        play.Type.CalculateCredits(performance);
}