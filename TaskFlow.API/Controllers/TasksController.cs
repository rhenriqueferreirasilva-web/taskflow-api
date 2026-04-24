using TaskFlow.API.Models;
using TaskFlow.API.DTOs;

namespace TaskFlow.API.Controllers;

public class TasksController
{
    private static List<TaskItem> tasks = new();

    public List<TaskItem> GetAll()
    {
        return tasks;
    }

    public TaskItem Create(CreateTaskRequest request)
    {
        var task = new TaskItem
        {
            Id = tasks.Count + 1,
            Title = request.Title,
            Done = false,
            CreatedAt = DateTime.Now
        };

        tasks.Add(task);
        return task;
    }
}
