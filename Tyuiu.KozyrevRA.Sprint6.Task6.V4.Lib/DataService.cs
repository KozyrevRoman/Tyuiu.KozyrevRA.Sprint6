using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KozyrevRA.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            int count = 0;
            string l2 = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] str = reader.ReadToEnd().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                string line;
                int tr = 0;
                foreach (string str2 in str) 
                {
                    foreach(char str3 in str2)
                    {
                        if (str3 == Convert.ToChar("n"))
                        {
                            tr = 1;
                        }    
                    }
                    if (tr == 1)
                    {
                        l2 += str2;
                        tr = 0;
                    }
                }
            }
            return l2;
        }
    }
}
