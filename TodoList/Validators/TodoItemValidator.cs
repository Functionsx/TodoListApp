using FluentValidation;

namespace TodoList.Validators
{
    public class TodoItemValidator : AbstractValidator<TodoItem>
    {
        public TodoItemValidator()
        {
            // Rule: Title is required and must not exceed 100 characters
            RuleFor(item => item.Title)
                .NotEmpty().WithMessage("Title cannot be empty.")
                .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.");

            // Rule: Description is optional but must not exceed 500 characters
            RuleFor(item => item.Description)
                .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");
        }
    }
}

