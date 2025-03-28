using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Core.Interfaces;

public class TextStatementFormatter : IStatementFormatter
{
    private CultureInfo cultureInfo = new CultureInfo("en-US");

    public async Task<string> FormatAsync(StatementDTO statement)
    {
        var result = new StringBuilder($"Statement for {statement.Customer}\n");

        foreach (var perf in statement.PerformanceSummaries)
        {
            await Task.Run(() =>
            {
                result.AppendFormat(cultureInfo,
                    $"  {perf.PlayName}: {perf.Amount.ToString("C", cultureInfo)} ({perf.Audience} seats)\n");
            });
        }

        await Task.Run(() =>
        {
            result.AppendFormat(cultureInfo, $"Amount owed is {statement.TotalAmount.ToString("C", cultureInfo)}\n");
            result.AppendFormat($"You earned {statement.VolumeCredits} credits\n");
        });

        return result.ToString();
    }
}
