using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TheatricalPlayersRefactoringKata.Application.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases;

public class StatementPrinter : IStatementPrinter
{
    private readonly IPlayCalculator _playCalculator;

    public StatementPrinter(IPlayCalculator playCalculator) =>
        _playCalculator = playCalculator;

    public string Print(Invoice invoice, Dictionary<string, Play> plays)
    {
        var totalAmount = 0;
        var volumeCredits = 0;
        var result = new StringBuilder($"Statement for {invoice.Customer}\n");

        CultureInfo cultureInfo = new CultureInfo("en-US");

        foreach (var perf in invoice.Performances)
        {
            var play = plays[perf.PlayId];
            var thisAmount = _playCalculator.CalculateAmount(perf, play);
            var thisCredits = _playCalculator.CalculateCredits(perf, play);

            volumeCredits += thisCredits;
            totalAmount += (int)thisAmount;

            result.AppendFormat(cultureInfo, $" {play.Name}: {(thisAmount / 100).ToString("C", cultureInfo)} ({perf.Audience} seats)\n");
        }

        result.AppendFormat(cultureInfo, $"Amount owed is {(totalAmount / 100).ToString("C", cultureInfo)}\n");
        result.AppendFormat($"You earned {volumeCredits} credits\n");

        return result.ToString();
    }
}
