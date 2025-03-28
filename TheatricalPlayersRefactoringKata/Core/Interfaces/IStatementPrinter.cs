using System.Threading.Tasks;
using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;

namespace TheatricalPlayersRefactoringKata.Core.Interfaces;
public interface IStatementFormatter
{
    Task<string> FormatAsync(StatementDTO statement);
}