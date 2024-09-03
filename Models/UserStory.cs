using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserStories{
    public class UserStory{
        private int id;
        private string title;
        private string description;
        private static int nextId = 1;
        private int businessValue;
        private DateTime creationDate;
        private int priority;
        private string storyPoint;

        public UserStory() { }

        public UserStory(string _title, string _description){
            id = nextId++;
            title = _title;
            description = _description;
            businessValue = BusinessValue;
            creationDate = CreationDate;
            priority = Priority;
            storyPoint = StoryPoint;
        }
        [BindProperty]
        public int Id{
            get{return id;}
            set{id=value;}
        }
        public string Title{
            get{return title;}
            set{title=value;}
        }
        public string Description{
            get{return description;}
            set{description=value;}
        }
        public int BusinessValue{
            get{return businessValue;}
            set{businessValue=value;}
        }
        public DateTime CreationDate{
            get{return creationDate;}
            set{creationDate=value;}
        }
        public int Priority{
            get{return priority;}
            set{priority=value;}
        }
        public string StoryPoint{
            get{return storyPoint;}
            set{storyPoint=value;}
        }
        public List<int> StoryPoints = new List<int>(){
            1,2,3,5,8,13,21,34
        };
        public List<int> GetStoryPoints(){
            return StoryPoints;
        }
    }
}
