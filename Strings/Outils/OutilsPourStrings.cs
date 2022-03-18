using System;

namespace Strings.Outils
{
    public static class OutilsPourStrings
    {
        public static string GetTexteSepareDuCamelCase(string texte)
        {
            // Recoit une texte dans le format GetTextCamelCase
            // et retourne le texte separé Get Text Camel Case
            return Regex.Matches(requestName, @"[A-Z]{1}[a-z]{1,}").Trim();
        }
    }
}