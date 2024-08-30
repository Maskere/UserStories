using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserStories{
    public class UserStory{
        private int id;
        private string title;
        private string description;
        private static int nextId = 0;
        private int businessValue;
        private DateTime creationDate;
        private int priority;
        private string storyPoints;

        public UserStory() { }

        public UserStory(string _title, string _description){
            id = nextId++;
            title = _title;
            description = _description;
            businessValue = BusinessValue;
            creationDate = CreationDate;
            priority = Priority;
            storyPoints = StoryPoints;
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
        public string StoryPoints{
            get{return storyPoints;}
            set{storyPoints=value;}
        }
    }
}
