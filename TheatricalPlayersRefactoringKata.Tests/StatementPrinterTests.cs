using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using TheatricalPlayersRefactoringKata.Application.Services;
using TheatricalPlayersRefactoringKata.Application.UseCases;
using TheatricalPlayersRefactoringKata.Core.Entitties;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests;
public class StatementPrinterTests
{
    private Dictionary<string, Play> GetPlays() =>
        new Dictionary<string, Play>
        {
            { "hamlet", new Play("Hamlet", 4024, "tragedy") },
            { "as-like", new Play("As You Like It", 2670, "comedy") },
            { "othello", new Play("Othello", 3560, "tragedy") },
            { "henry-v", new Play("Henry V", 3227, "history") },
            { "john", new Play("King John", 2648, "history") },
            { "richard-iii", new Play("Richard III", 3718, "history") }
        };

    private Invoice GetInvoice() =>
        new Invoice(
            "BigCo",
            new List<Performance>
            {
                new Performance("hamlet", 55),
                new Performance("as-like", 35),
                new Performance("othello", 40),
                new Performance("henry-v", 20),
                new Performance("john", 39),
                new Performance("henry-v", 20)
            }
        );

    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void TestStatementExampleLegacy()
    {
        var plays = GetPlays();
        var invoice = new Invoice(
            "BigCo",
            new List<Performance>
            {
                new Performance("hamlet", 55),
                new Performance("as-like", 35),
                new Performance("othello", 40),
            }
        );

        var playCalculator = new PlayCalculator();
        var statementService = new StatementService(playCalculator, new TextStatementFormatter());
        var result = statementService.GenerateStatement(invoice, plays);

        Approvals.Verify(result);
    }

    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void TestTextStatementExample()
    {
        var plays = GetPlays();
        var invoice = GetInvoice();

        var playCalculator = new PlayCalculator();
        var statementService = new StatementService(playCalculator, new TextStatementFormatter());
        var result = statementService.GenerateStatement(invoice, plays);

        Approvals.Verify(result);
    }

    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void TestXmlStatementExample()
    {
        var plays = GetPlays();
        var invoice = GetInvoice();

        var playCalculator = new PlayCalculator();
        var statementService = new StatementService(playCalculator, new XmlStatementFormatter());
        var result = statementService.GenerateStatement(invoice, plays);

        Approvals.Verify(result);
    }
}
