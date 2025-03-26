using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;

namespace TheatricalPlayersRefactoringKata.Core.Interfaces;
public interface IStatementFormatter
{
    string Format(Statement statement);
}