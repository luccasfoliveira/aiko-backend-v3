using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Application.Interfaces;
public interface IStatementPrinter
{
    string Print(Invoice invoice, Dictionary<string, Play> plays);
}