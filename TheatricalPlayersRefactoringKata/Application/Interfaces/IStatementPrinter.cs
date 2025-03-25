using System.Collections.Generic;
using TheatricalPlayersRefactoringKata.Application.Entitties;

namespace TheatricalPlayersRefactoringKata.Application.Interfaces;
public interface IStatementPrinter
{
    string Print(Invoice invoice, Dictionary<string, Play> plays);
}