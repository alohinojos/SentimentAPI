using System.Linq;

namespace SentimentAPI.Services
{
    public static class SentimentAnalyzer
    {
        private static readonly string[] Positive =
        {
            "excelente","genial","fantástico","bueno","increíble",
            "bonita","linda","me encanta","perfecto","maravilloso",
            "hermoso","feliz","recomiendo","encantó","encanta"
        };

        private static readonly string[] Negative =
        {
            "malo","terrible","problema","defecto","horrible",
            "no me gustó","feo","pésimo","odio","decepcionado",
            "decepcionante","no lo recomiendo","lento","dañado"
        };

        public static string Analyze(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "neutral";
            var t = text.ToLower();
            if (Positive.Any(w => t.Contains(w))) return "positivo";
            if (Negative.Any(w => t.Contains(w))) return "negativo";
            return "neutral";
        }
    }
}
