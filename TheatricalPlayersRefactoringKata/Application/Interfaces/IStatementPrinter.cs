using TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;

namespace TheatricalPlayersRefactoringKata.Application.Interfaces;
public interface IStatementFormatter
{
    string Format(Statement statement);
}