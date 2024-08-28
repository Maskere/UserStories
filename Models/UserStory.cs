using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserStories{
    public class UserStory{
        private int id;
        private string title;
        private string description;
        private static int nextId = 0;

        public UserStory() { }

        public UserStory(string _title, string _description){
            id = nextId++;
            title = _title;
            description = _description;
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
    }
}
