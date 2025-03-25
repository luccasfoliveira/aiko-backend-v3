using System.Globalization;
using System.Text;
using TheatricalPlayersRefactoringKata.Application.Entitties;
using TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Application.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases
{
    public class TextStatementFormatter: IStatementFormatter
    {
        private CultureInfo cultureInfo = new CultureInfo("en-US");

        public string Format(StatementResultDTO statement)
        {
            var result = new StringBuilder($"Statement for {statement.Customer}\n");

            foreach (var perf in statement.PerformanceSummaries)
            {
                result.AppendFormat(cultureInfo, 
                    $"  {perf.PlayName}: {(perf.Amount / 100).ToString("C", cultureInfo)} ({perf.Audience} seats)\n");
            }

            result.AppendFormat(cultureInfo, $"Amount owed is {(statement.TotalAmount / 100).ToString("C", cultureInfo)}\n");
            result.AppendFormat($"You earned {statement.VolumeCredits} credits\n");

            return result.ToString();
        }
    }
}
