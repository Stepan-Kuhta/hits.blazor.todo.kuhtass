﻿using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } =
        [
            new() { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedDate=DateTime.Now},
            new() { Id = 2, Title = "Задача 2", Description = "Описание задачи 2", CreatedDate=DateTime.Now},
            new() { Id = 3, Title = "Задача 3", Description = "Описание задачи 3", CreatedDate=DateTime.Now},
        ];
        public Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return Task.FromResult(Tasks);
        }
    }
}
