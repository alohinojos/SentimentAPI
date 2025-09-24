using Microsoft.AspNetCore.Mvc;
using SentimentAPI.Data;
using SentimentAPI.Models;
using SentimentAPI.Services;

namespace SentimentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CommentsController(AppDbContext context)
        {
            _context = context;
        }

        // POST api/Comments
        [HttpPost]
        public async Task<IActionResult> PostComment([FromBody] CommentRequest request)
        {
            var sentiment = SentimentAnalyzer.Analyze(request.CommentText);

            var comment = new Comment
            {
                ProductId = request.ProductId,
                UserId = request.UserId,
                CommentText = request.CommentText,
                Sentiment = sentiment,
                CreatedAt = DateTime.UtcNow
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return Ok(comment);
        }

        // GET api/Comments
        [HttpGet]
        public IActionResult GetComments()
        {
            return Ok(_context.Comments.ToList());
        }

        // GET api/Comments/sentiment-summary
        [HttpGet("sentiment-summary")]
        public IActionResult GetSentimentSummary()
        {
            var summary = _context.Comments
                .GroupBy(c => c.Sentiment)
                .Select(g => new { Sentiment = g.Key, Count = g.Count() })
                .ToList();

            return Ok(summary);
        }
    }
}


