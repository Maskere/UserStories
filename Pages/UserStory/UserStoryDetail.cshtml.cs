using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace UserStories
{
    public class UserStoryDetailModel : PageModel
    {
        [BindProperty]
        public UserStory UserStory { get; set; }

        public List<UserStory> UserStories { get; private set; }
        private UserStoryService userStoryService;

        public UserStoryDetailModel(UserStoryService userStoryService){
            this.userStoryService = userStoryService;
        }
        public void OnGet(int id)
        {
            UserStories = userStoryService.GetUserStories();
            UserStory = userStoryService.GetUserStory(id);
        }
    }
}
