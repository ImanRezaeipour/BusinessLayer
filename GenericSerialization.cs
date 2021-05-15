using System.IO;
using System.Xml.Serialization;

public class GenericSerialization<T> where T : new()
{
    public static bool Serialize(object _object, string _path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        FileStream fs = null;
        try
        {
            fs = new FileStream(_path, FileMode.Create);
            serializer.Serialize(fs, _object);
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            fs.Close();
        }
    }

    public static T Deserialize(string _path) 
    {
        T result;
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        FileStream fs = new FileStream(_path, FileMode.OpenOrCreate);
        try
        {
            result = (T) serializer.Deserialize(fs);
        }
        catch
        {
            result = new T();
        }
        finally
        {
            fs.Close();
        }
        return result;
    } 
}