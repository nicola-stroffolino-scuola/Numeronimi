namespace Numeronimi
{
    public static class Numeronimo
    {
        public static string Numeronymize(string s, int mode)
        {
            //Se mode == 0 tutte minuscole, salvo i casi particolari indicati
            //Se mode == 1 L'iniziale di ogni numeronimo dovrà essere maiuscola, salvo i casi
            //particolari indicati
            string res = "";
            
            res = s[0] + (s.Length - 2).ToString() + s[s.Length - 1];

            return res;
        }


    }
}