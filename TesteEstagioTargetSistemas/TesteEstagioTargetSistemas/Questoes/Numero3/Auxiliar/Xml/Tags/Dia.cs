using System.Xml.Serialization;

namespace TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml.Tags
{
    public class Dia
    {
        [XmlAttribute("data")]
        public string Data { get; set; }
        [XmlElement("Total")]
        public decimal Total { get; set; }
    }
}
