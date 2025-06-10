using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using TodoList.Validators;

namespace TodoList
{
    public class TodoListManager
    {
        private readonly List<TodoItem> _todoItems = new();
        public IReadOnlyList<TodoItem> Items => _todoItems.AsReadOnly();

        public (bool Success, List<string> Errors, string SuccessMessage) AddTodoItem(string title, string description = "")
        {
            // Create a new TodoItem
            var newItem = new TodoItem(title, description);

            // Validate the TodoItem
            var validator = new TodoItemValidator();
            ValidationResult result = validator.Validate(newItem);

            if (!result.IsValid)
            {
                // Return validation errors
                return (false, result.Errors.Select(e => e.ErrorMessage).ToList(), string.Empty);
            }

            // Add the item to the list
            _todoItems.Add(newItem);

            // Return success message
            return (true, new List<string>(), "Todo Item added successfully");
        }
    }
}
