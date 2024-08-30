using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace UserStories{
    public class CreateUserStoryModel : PageModel{
        private UserStoryService UserStoryService;
        public string errorMessage = "";
        public CreateUserStoryModel(UserStoryService userStoryService) 
        { 
            UserStoryService = userStoryService;
        }
        [BindProperty]
        public UserStory UserStory {get;set;}
        public bool IsChecked {get;set;}
        public List<int> BusinessValues = new List<int>(){

        };

        public IActionResult OnPost()
        {
            UserStoryService.CreateUserStory(UserStory);
            return RedirectToPage("UserStories");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
