using System.Globalization;
using System.Text;
using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Core.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases;
public class TextStatementFormatter: IStatementFormatter
{
    private CultureInfo cultureInfo = new CultureInfo("en-US");

    public string Format(Statement statement)
    {
        var result = new StringBuilder($"Statement for {statement.Customer}\n");

        foreach (var perf in statement.PerformanceSummaries)
        {
            result.AppendFormat(cultureInfo, 
                $"  {perf.PlayName}: {perf.Amount.ToString("C", cultureInfo)} ({perf.Audience} seats)\n");
        }

        result.AppendFormat(cultureInfo, $"Amount owed is {statement.TotalAmount.ToString("C", cultureInfo)}\n");
        result.AppendFormat($"You earned {statement.VolumeCredits} credits\n");

        return result.ToString();
    }
}
