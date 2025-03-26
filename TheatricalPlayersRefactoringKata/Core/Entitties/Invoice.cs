using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Core.Entitties;

public class Invoice
{
    public string Customer { get; set; }
    public IReadOnlyCollection<Performance> Performances { get; set; }

    public Invoice(string customer, IReadOnlyCollection<Performance> performances) =>
        (Customer, Performances) = (customer, performances);
}
