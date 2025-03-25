using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatricalPlayersRefactoringKata.Application.Entitties.DTOs
{
    public class PerformanceSummaryDTO
    {
        public string PlayName { get; }
        public decimal Amount { get; }
        public int Audience { get; }

        public PerformanceSummaryDTO(string playName, decimal amount, int audience) =>
            (PlayName, Amount, Audience) = (playName, amount, audience);
    }
}
