using System.Xml;

namespace Dal
{
    public class Data
    {
        public string TanachTxt()
        {
            try
            {
                string pathTanach = """C:\Users\sarah\Documents\C#\Lesson5_project\Dal\PL\bin\Debug\net7.0-windows\tora.txt""";
                string ourTanach = File.ReadAllText(pathTanach);
                return ourTanach;
            }
            catch
            {
                throw new Exception("The path is not existing!");
            }
            
        }
        public string JsonFile()
        {
            try
            {
                //string jsonTanach = """C:\Users\sarah\Documents\C#\Lesson5_project\Tanach.json""";
                string jsonTanach = """C:\Users\sarah\Documents\C#\Lesson5_project\Pasmles.json""";
                string ourJsonFile = File.ReadAllText(jsonTanach);
                return ourJsonFile;
            }
            catch
            {
                throw new Exception("The path is not existing!");
            }
        }
       
    }

    
}