using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Application.Entitties;

public class Invoice
{
    public string Customer { get; set; }
    public IReadOnlyCollection<Performance> Performances { get; set; }

    public Invoice(string customer, List<Performance> performances)
    {
        Customer = customer;
        Performances = performances;
    }
}
