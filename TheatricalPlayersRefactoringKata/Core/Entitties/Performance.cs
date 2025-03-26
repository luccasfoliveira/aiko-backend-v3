namespace TheatricalPlayersRefactoringKata.Core.Entitties;

public class Performance
{
    public string PlayId { get; set; }
    public int Audience { get; set; }

    public Performance(string playID, int audience) =>
        (PlayId, Audience) = (playID, audience);
}
