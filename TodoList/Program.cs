using TodoList;

// Create a TodoListManager (instantiate it)
var manager = new TodoListManager();

// Create a TodoItem object
var item = new TodoItem("Get Shopping", "Beans, eggs, fish");

// Add the item to the manager
manager.AddTodoItem(item.Title, item.Description);