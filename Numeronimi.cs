using System.Collections.Generic;
using System.Linq;

namespace Numeronimi
{
    public static class Numeronimo
    {
        public static string Numeronymize(string s, int mode)
        {
            //Se mode == 0 tutte minuscole, salvo i casi particolari indicati
            //Se mode == 1 L'iniziale di ogni numeronimo dovrà essere maiuscola, salvo i casi
            //particolari indicati
            if(! (s.All(c => char.IsLetter(c) || c == ' '))) return "Invalid string";
            string res = "";

            foreach(string word in s.TrimStart().TrimEnd().Split(" ")){
                string tmp = "";
                if(mode == 0) tmp = word.ToLower();
                if(mode == 1 || word == "Kubernetes" || word == "kubernetes"){
                    tmp = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
                res += tmp[0] + (tmp.Length - 2).ToString() + tmp[tmp.Length - 1] + " "; // + " " --> Spazio Separatore 
            }
            res = res.TrimEnd(); // Rimuove lo Spazio Separatore finale

            res = string.Join("", res.ToList<char>().Select(c => 
                c = (c == 'I' ? 'i' : c == 'l' ? 'L' : c == ' ' ? '@' : c)
            ));

            return res;
        }
    }
}