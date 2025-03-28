using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TheatricalPlayersRefactoringKata.Core.Entitties.DTOs;
using TheatricalPlayersRefactoringKata.Core.Interfaces;

public class XmlStatementFormatter : IStatementFormatter
{
    public async Task<string> FormatAsync(StatementDTO statement)
    {
        using (var memoryStream = new MemoryStream())
        using (var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8))
        using (var xmlWriter = XmlWriter.Create(streamWriter, new XmlWriterSettings { Indent = true }))
        {
            var xmlSerializer = new XmlSerializer(typeof(StatementDTO));

            await Task.Run(() =>
            {
                xmlSerializer.Serialize(xmlWriter, statement);
            });

            await streamWriter.FlushAsync();

            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }
    }
}
