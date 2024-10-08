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

        public void CreateUserStory(UserStory userStory){
            userStories.Add(userStory);
        }

        public UserStory GetUserStory(int id){
            foreach(UserStory userStory in userStories){
                if(userStory.Id == id){
                    return userStory;
                }
            }
            return null;
        }

        public UserStory DeleteUserStory(int userStoryId){
            UserStory userStoryToBeDeleted = null;
            foreach(UserStory us in userStories){
                if(us.Id == userStoryId){
                    userStoryToBeDeleted = us;
                    break;
                }
            }
            if(userStoryToBeDeleted != null){
                userStories.Remove(userStoryToBeDeleted);
            }
            return userStoryToBeDeleted;
        }
    }
}
