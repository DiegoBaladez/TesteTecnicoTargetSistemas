using System.Xml.Serialization;
using TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml.Tags;

namespace TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml
{
    [Serializable()]
    [XmlRoot]
    public class Faturamento
    {
        [XmlElement("Mes")]
        public Mes Mes { get; set; }
    }
}
