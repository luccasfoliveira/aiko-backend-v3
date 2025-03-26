using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TheatricalPlayersRefactoringKata.Application.Entitties;
using TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Application.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases;

public class StatementService
{
    private readonly IPlayCalculator _playCalculator;
    private readonly IStatementFormatter _statementFormatter;

    public StatementService(IPlayCalculator playCalculator, IStatementFormatter statementFormatter) =>
        (_playCalculator, _statementFormatter) = (playCalculator, statementFormatter);

    public string GenerateStatement(Invoice invoice, Dictionary<string, Play> plays)
    {
        decimal totalAmount = 0;
        int volumeCredits = 0;
        var performanceSummaries = new List<PerformanceSummaryDTO>();

        foreach (var perf in invoice.Performances)
        {
            var play = plays[perf.PlayId];
            var thisAmount = _playCalculator.CalculateAmount(perf, play);
            var thisCredits = _playCalculator.CalculateCredits(perf, play);

            volumeCredits += thisCredits;
            totalAmount += thisAmount;

            thisAmount /= 100;
            performanceSummaries.Add(new PerformanceSummaryDTO(play.Name, thisAmount, perf.Audience, thisCredits));
        }
        totalAmount /= 100;
        var statement = new Statement(invoice.Customer, totalAmount, volumeCredits, performanceSummaries);

        return _statementFormatter.Format(statement);
    }
}