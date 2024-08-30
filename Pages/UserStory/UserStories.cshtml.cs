using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace UserStories
{
    public class UserStoriesModel : PageModel
    {
        private UserStoryService userStoryService;

        public UserStoriesModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }
        [BindProperty(SupportsGet = true)]

        public List<UserStory> UserStories { get; private set; }

        public IActionResult OnGet()
        {
            UserStories = userStoryService.GetUserStories();
            return Page();
        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
