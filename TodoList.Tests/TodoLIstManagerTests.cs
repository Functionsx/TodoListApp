using System;
using System.Linq;
using TodoList;
using Xunit;

namespace TodoList.Tests
{
    public class TodoListManagerTests
    {
        [Fact]
        public void AddTodoItem_ValidInput_ReturnsSuccessAndAddsItem()
        {
            // Arrange
            var manager = new TodoListManager();
            string title = "Test Task";
            string description = "Test Description";

            // Act
            var result = manager.AddTodoItem(title, description);

            // Assert
            Assert.True(result.Success);
            Assert.Empty(result.Errors);
            Assert.Equal("Todo Item added successfully", result.SuccessMessage);
            Assert.Single(manager.Items);
            Assert.Equal(title, manager.Items[0].Title);
            Assert.Equal(description, manager.Items[0].Description);
        }

        [Fact]
        public void AddTodoItem_EmptyTitle_ReturnsValidationError()
        {
            // Arrange
            var manager = new TodoListManager();
            string title = "";
            string description = "Some description";

            // Act
            var result = manager.AddTodoItem(title, description);

            // Assert
            Assert.False(result.Success);
            Assert.Contains("Title cannot be empty.", result.Errors);
            Assert.Empty(result.SuccessMessage);
            Assert.Empty(manager.Items);
        }

        [Fact]
        public void AddTodoItem_TitleTooLong_ReturnsValidationError()
        {
            // Arrange
            var manager = new TodoListManager();
            string title = new string('a', 101); // 101 chars
            string description = "Some description";

            // Act
            var result = manager.AddTodoItem(title, description);

            // Assert
            Assert.False(result.Success);
            Assert.Contains("Title cannot exceed 100 characters.", result.Errors);
            Assert.Empty(result.SuccessMessage);
            Assert.Empty(manager.Items);
        }

        [Fact]
        public void AddTodoItem_DescriptionTooLong_ReturnsValidationError()
        {
            // Arrange
            var manager = new TodoListManager();
            string title = "Valid Title";
            string description = new string('b', 501); // 501 chars

            // Act
            var result = manager.AddTodoItem(title, description);

            // Assert
            Assert.False(result.Success);
            Assert.Contains("Description cannot exceed 500 characters.", result.Errors);
            Assert.Empty(result.SuccessMessage);
            Assert.Empty(manager.Items);
        }

        [Fact]
        public void Items_InitiallyEmpty()
        {
            // Arrange
            var manager = new TodoListManager();

            // Act & Assert
            Assert.Empty(manager.Items);
        }
    }
}
