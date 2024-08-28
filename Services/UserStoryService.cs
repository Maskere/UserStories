using System.Collections.Generic;
using System.Linq;

namespace UserStories{
    public class UserStoryService{
        private List<UserStory> userStories;

        public UserStoryService(){
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories(){
            return userStories;
        }
    }
}
