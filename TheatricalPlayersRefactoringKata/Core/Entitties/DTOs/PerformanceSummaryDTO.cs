using System.Xml.Serialization;

namespace TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
public class PerformanceSummaryDTO
{
    [XmlIgnore]
    public string PlayName { get; init; }

    [XmlElement("AmountOwed")]
    public decimal Amount { get; init; }

    [XmlElement("EarnedCredits")]
    public int EarnedCredits {  get; init; }

    [XmlElement("Seats")]
    public int Audience { get; init; }

    public PerformanceSummaryDTO() { }

    public PerformanceSummaryDTO(string playName, decimal amount, int audience, int earnedCredits) =>
        (PlayName, Amount, Audience, EarnedCredits) = (playName, amount, audience, earnedCredits);
}
