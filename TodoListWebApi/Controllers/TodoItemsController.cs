using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListWebApi.Data;

namespace TodoListWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController(TodoListDbContext context) : ControllerBase
    {

        private readonly TodoListDbContext _context = context;

        // Get method to fetch all items from the list
        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> GetAllTodoItems()
        {
            return Ok(await _context.TodoItems.ToListAsync());
        }

        // Get method to fetch an item by its ID
        [HttpGet("{id}")] // Combination of route and action parameter
        public async Task<ActionResult<TodoItem>> GetTodoItemById(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item is null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // Post method function to add an item to the Todo list
        [HttpPost]
        public async Task<ActionResult<TodoItem>> AddTodoItem(TodoItem newTodo)
        {
            if (newTodo is null)
                return BadRequest();
            // Add the new item to the list
            _context.TodoItems.Add(newTodo);

            //Save changes to the database
            await _context.SaveChangesAsync();

            // Return the created item with a 201 Created response
            return CreatedAtAction(nameof(GetTodoItemById), new { id = newTodo.Id }, newTodo);
        }

        // Put method to update an existing item
        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateTodoItem(int id, TodoItem updatedTodo)
        {
            // Find the item by ID
            var item = await _context.TodoItems.FindAsync(id);
            if (item is null)
                return NotFound();

            // Update the existing item
            item.Title = updatedTodo.Title;
            item.Description = updatedTodo.Description;
            item.CreatedDate = updatedTodo.CreatedDate;

            // Save changes to the database
            await _context.SaveChangesAsync();
            return NoContent(); 
        }

        // Delete method to remove an item by its ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            // Find the item by ID
            var item = await _context.TodoItems.FindAsync(id);
            if (item is null)
                return NotFound();

            // Remove the item from the list
            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent(); 
            }
        }
}
