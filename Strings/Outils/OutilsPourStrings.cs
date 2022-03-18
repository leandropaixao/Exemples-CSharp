using System;
using System.Text.RegularExpressions;

namespace Strings.Outils
{
    public static class OutilsPourStrings
    {
        public static string GetTexteSepareDuCamelCase(string texte)
        {
            // Recoit une texte dans le format GetTextCamelCase
            // et retourne le texte separé Get Text Camel Case
            var retour = "";
            var regexMatches = Regex.Matches(texte, @"[A-Z]{1}[a-z]{1,}");
            foreach(var reg in regexMatches)
            {
                retour += string.Concat(reg, " ");
            }

            return retour.Trim();
        }
    }
}