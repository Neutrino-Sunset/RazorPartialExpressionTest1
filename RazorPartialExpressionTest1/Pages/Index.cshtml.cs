using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPartialExpressionTest1.Model;

namespace RazorPartialExpressionTest1.Pages
{
   public class IndexModel : PageModel
   {
      [BindProperty]
      public Movie Movie { get; set; }

      private readonly ILogger<IndexModel> _logger;

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      public void OnGet()
      {

      }

      public void OnPost()
      {
         _logger.LogInformation(Movie.ToString());
      }
   }
}
