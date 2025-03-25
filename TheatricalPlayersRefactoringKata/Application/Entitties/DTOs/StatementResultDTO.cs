using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;
public class StatementResultDTO
{
    public string Customer { get; init; }
    public decimal TotalAmount { get; init; }
    public int VolumeCredits { get; init; }
    public List<PerformanceSummaryDTO> PerformanceSummaries { get; init; }

    public StatementResultDTO(string customer, decimal totalAmount, int volumeCredits, List<PerformanceSummaryDTO> performanceSummaries) =>
        (Customer, TotalAmount, VolumeCredits, PerformanceSummaries) =
        (customer, totalAmount, volumeCredits, performanceSummaries ?? new List<PerformanceSummaryDTO>());
}
