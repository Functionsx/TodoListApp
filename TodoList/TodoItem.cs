using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class TodoItem
    {
        // Properties for the TodoItem class
        public int Id { get; private set; } 
        public string Title { get; private set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; private set; }

        // Constructor to initialise a new TodoItem
        public TodoItem(string title, string description = "")
        {
            Title = title;
            Description = description ?? string.Empty;
            CreatedDate = DateTime.Now;
        }
    }
}
