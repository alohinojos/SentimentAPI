﻿namespace SentimentAPI.Models
{
    public class CommentRequest
    {
        public string ProductId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string CommentText { get; set; } = string.Empty;
    }
}
