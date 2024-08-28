using System.Collections.Generic;

namespace UserStories{
    public class MockUserStories{
        private static List<UserStory> userStories = new List<UserStory>(){
            new UserStory("Create Story", "As P.O I want to create a new Story So..."),
            new UserStory("Edit Story", "As P.O I want to edit a new Story So..."),
            new UserStory("Move Story", "As team memer I want to move a new Story So..."),
            new UserStory("Delete Story", "As team memember I want to delete a new Story So...")
        };

        public MockUserStories(){
            GetMockUserStories();
        }

        public static List<UserStory> GetMockUserStories(){
            return userStories;
        }
    }
}
