using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace UserStories{
    public class CreateUserStoryModel : PageModel{
        private UserStoryService UserStoryService;
        private static List<int> StoryPointsOptions = new List<int>(){
            1,2,3,5,8,13,21,34
        };
        public CreateUserStoryModel(UserStoryService userStoryService) 
        { 
            UserStoryService = userStoryService;
        }
        public string errorMessage = "";
        [BindProperty]
        public int StoryPoint {get;set;}
        [BindProperty]
        public UserStory UserStory {get;set;}

        public bool IsChecked {get;set;}

        public List<int> BusinessValues = new List<int>(){
            1,2,3,4,5,6,7,8,9,10
        };
        public List<int> PriorityValues = new List<int>(){
            1,2,3,4
        };
        [BindProperty]
        public List<int> StoryPoints {get {return StoryPointsOptions;}}

        public IActionResult OnPost()
        {
            UserStory.StoryPoint = StoryPoint.ToString();

            UserStoryService.CreateUserStory(UserStory);

            return RedirectToPage("UserStories");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
