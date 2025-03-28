using System.Collections.Generic;
using System.Xml.Serialization;

namespace TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;

[XmlRoot("Statement")]
public class StatementDTO
{
    [XmlElement("Customer")]
    public string Customer { get; init; }

    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<PerformanceSummaryDTO> PerformanceSummaries { get; init; }

    [XmlElement("AmountOwed")]
    public decimal TotalAmount { get; init; }

    [XmlElement("EarnedCredits")]
    public int VolumeCredits { get; init; }

    public StatementDTO() { }

    public StatementDTO(string customer, decimal totalAmount, int volumeCredits, List<PerformanceSummaryDTO> performanceSummaries) =>
        (Customer, TotalAmount, VolumeCredits, PerformanceSummaries) =
        (customer, totalAmount, volumeCredits, performanceSummaries ?? new List<PerformanceSummaryDTO>());
}
