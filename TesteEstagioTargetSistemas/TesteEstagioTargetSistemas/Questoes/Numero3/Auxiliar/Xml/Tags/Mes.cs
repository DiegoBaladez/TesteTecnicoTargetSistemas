using System.Xml.Serialization;

namespace TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Xml.Tags
{
    public class Mes
    {
        [XmlAttribute("nome")]
        public string Nome { get; set; }
        [XmlAttribute("ano")]
        public int Ano { get; set; }
        [XmlElement("Dia")]
        public List<Dia> Dias { get; set; }
    }
}
