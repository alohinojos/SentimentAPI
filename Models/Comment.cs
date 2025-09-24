using System;

namespace SentimentAPI.Models
{
    public class Comment
    {
        public int Id { get; set; } // Lo genera la BD automáticamente
        public string ProductId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string CommentText { get; set; } = string.Empty;

        // Se rellenan en el backend
        public string Sentiment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
