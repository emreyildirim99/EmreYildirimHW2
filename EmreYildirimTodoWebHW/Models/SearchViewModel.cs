using System.Collections.Generic;

namespace EmreYildirimTodoWebHW.Models
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }
        public bool ShowAll { get; set; }
        
        public bool CategoryDescSearch { get; set; }

        public List<TodoItem> Result { get; set; }
        
        public List<Category> CategoryResult { get; set; }
    }
}