using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Xml<T>
    {
        public static bool Guarda(string path, T datos)
        {
            bool flag = false;
            XmlTextWriter archivoReceptor = new XmlTextWriter(path, Encoding.UTF8);  
            XmlSerializer serializador = new XmlSerializer(typeof(T)); 

            try
            {
                serializador.Serialize(archivoReceptor, datos); 
                flag = true;
            }
            catch (Exception exception)
            {
                throw new ErrorArchivoException(exception);
            }
            finally
            {
                archivoReceptor.Close();
            }

            return flag;
        }

        public static bool Lee(string path, out T datos)
        {
            bool flag = false;

            XmlTextReader XmlReader = new XmlTextReader(path);
            XmlSerializer objetoDeserializador = new XmlSerializer(typeof(T)); 

            try
            {

                datos = (T)objetoDeserializador.Deserialize(XmlReader);

                flag = true;

            }
            catch (Exception exception)
            {
                throw new ErrorArchivoException(exception);
            }

            finally
            {
                XmlReader.Close();
            }

            return flag;
        }
    }
}
