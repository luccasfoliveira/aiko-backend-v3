using System.IO;
using System.Xml.Serialization;
using TheatricalPlayersRefactoringKata.Application.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Application.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases
{
    public class XmlStatementFormatter: IStatementFormatter
    {
        public string Format(StatementResultDTO statement)
        {
            var stringWriter = new StringWriter();
            var xmlSerializer = new XmlSerializer(typeof(StatementResultDTO));

            xmlSerializer.Serialize(stringWriter, statement);

            return stringWriter.ToString();
        }
    }
}
