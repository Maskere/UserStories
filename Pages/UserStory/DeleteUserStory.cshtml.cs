using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace UserStories
{
    public class DeleteUserStoryModel : PageModel
    {
        private UserStoryService UserStoryService;

        public DeleteUserStoryModel(UserStoryService userStoryService){
            UserStoryService = userStoryService;
        }

        [BindProperty(SupportsGet = true)]
        public UserStory UserStory { get; set; }

        public IActionResult OnGet(int id)
        {
            UserStory = UserStoryService.GetUserStory(id);
            return Page();
        }
        public IActionResult OnPost()
        {
            UserStory deleteUserStory = UserStoryService.DeleteUserStory(UserStory.Id);
            return RedirectToPage("UserStories");
        }
    }
}
