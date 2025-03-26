using System.Xml.Serialization;

namespace TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
public class PerformanceSummaryDTO
{
    [XmlIgnore]
    public string PlayName { get; set; }

    [XmlElement("AmountOwed")]
    public decimal Amount { get; set; }

    [XmlElement("EarnedCredits")]
    public int EarnedCredits {  get; set; }

    [XmlElement("Seats")]
    public int Audience { get; set; }

    public PerformanceSummaryDTO() { }

    public PerformanceSummaryDTO(string playName, decimal amount, int audience, int earnedCredits) =>
        (PlayName, Amount, Audience, EarnedCredits) = (playName, amount, audience, earnedCredits);
}
