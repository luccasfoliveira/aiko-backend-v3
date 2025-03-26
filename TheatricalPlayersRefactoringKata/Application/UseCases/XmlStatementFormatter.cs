using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Core.Interfaces;

namespace TheatricalPlayersRefactoringKata.Application.UseCases;
public class XmlStatementFormatter: IStatementFormatter
{
    public string Format(Statement statement)
    {
        using (var memoryStream = new MemoryStream())
        using (var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8))
        using (var xmlWriter = XmlWriter.Create(streamWriter, new XmlWriterSettings { Indent = true }))
        {
            var xmlSerializer = new XmlSerializer(typeof(Statement));
            xmlSerializer.Serialize(xmlWriter, statement);

            streamWriter.Flush();

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}
