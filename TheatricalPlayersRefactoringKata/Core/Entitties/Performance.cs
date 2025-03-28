namespace TheatricalPlayersRefactoringKata.Core.Entitties;

public class Performance
{
    public string PlayId { get; }
    public int Audience { get; }

    public Performance(string playID, int audience) =>
        (PlayId, Audience) = (playID, audience);
}
