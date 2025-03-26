using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TheatricalPlayersRefactoringKata.Application.Entitties.DTOs
{
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
}
