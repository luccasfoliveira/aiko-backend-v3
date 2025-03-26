using System.Collections.Generic;
using System.Xml.Serialization;

namespace TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;
public class Statement
{
    [XmlElement("Customer")]
    public string Customer { get; set; }

    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<PerformanceSummaryDTO> PerformanceSummaries { get; set; }

    [XmlElement("AmountOwed")]
    public decimal TotalAmount { get; set; }

    [XmlElement("EarnedCredits")]
    public int VolumeCredits { get; set; }

    public Statement() { }

    public Statement(string customer, decimal totalAmount, int volumeCredits, List<PerformanceSummaryDTO> performanceSummaries) =>
        (Customer, TotalAmount, VolumeCredits, PerformanceSummaries) =
        (customer, totalAmount, volumeCredits, performanceSummaries ?? new List<PerformanceSummaryDTO>());
}
