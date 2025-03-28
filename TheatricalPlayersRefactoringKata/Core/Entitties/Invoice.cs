using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Core.Entitties;

public class Invoice
{
    public string Customer { get; }
    public IReadOnlyCollection<Performance> Performances { get; }

    public Invoice(string customer, IReadOnlyCollection<Performance> performances) =>
        (Customer, Performances) = (customer, performances);
}
