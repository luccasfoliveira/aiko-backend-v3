using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using TheatricalPlayersRefactoringKata.Application.Entitties;
using TheatricalPlayersRefactoringKata.Application.Entitties.Types;
using TheatricalPlayersRefactoringKata.Application.UseCases;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests
{
    public class StatementPrinterTests
    {
        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void TestStatementExampleLegacy()
        {
            var plays = new Dictionary<string, Play>
            {
                { "hamlet", new Play("Hamlet", 4024, new Tragedy()) },
                { "as-like", new Play("As You Like It", 2670, new Comedy()) },
                { "othello", new Play("Othello", 3560, new Tragedy()) }
            };

            Invoice invoice = new Invoice(
                "BigCo",
                new List<Performance>
                {
                    new Performance("hamlet", 55),
                    new Performance("as-like", 35),
                    new Performance("othello", 40),
                }
            );

            var playCalculator = new PlayCalculator();
            StatementPrinter statementPrinter = new StatementPrinter(playCalculator);
            var result = statementPrinter.Print(invoice, plays);

            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void TestTextStatementExample()
        {
            var plays = new Dictionary<string, Play>
            {
                { "hamlet", new Play("Hamlet", 4024, new Tragedy()) },
                { "as-like", new Play("As You Like It", 2670, new Comedy()) },
                { "othello", new Play("Othello", 3560, new Tragedy()) },
                { "henry-v", new Play("Henry V", 3227, new Historical()) },
                { "john", new Play("King John", 2648,new Historical()) },
                { "richard-iii", new Play("Richard III", 3718, new Historical()) }
            };

            Invoice invoice = new Invoice(
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

            var playCalculator = new PlayCalculator();
            StatementPrinter statementPrinter = new StatementPrinter(playCalculator);
            var result = statementPrinter.Print(invoice, plays);

            Approvals.Verify(result);
        }
    }
}
