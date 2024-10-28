using System.Xml.Serialization;

namespace TesteEstagioTargetSistemas.Questoes.Numero3.Auxiliar.Classes
{
    public static class XmlService
    {
        public static T Deserializacao<T>(string xml)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                using (StreamReader leitor = new StreamReader(xml))
                {
                    return (T)serializador.Deserialize(leitor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Um erro ocorreu: {ex.Message}");
            }
            return default(T);
        } 
    }
}
