using TodoServerApp.Data.Interfaces;

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

		private static List<UserItem> Users { get; } = new List<UserItem>
		{
			new UserItem {Id = 1, FullName = "Пользователь 1", Email = "user1@example.com", RegisteredDate = DateTime.Now},
			new UserItem {Id = 2, FullName = "Пользователь 2", Email = "user2@example.com", RegisteredDate = DateTime.Now}
		};

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<TaskItem> GetTaskAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }

		public Task SaveAsync(TaskItem item)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<UserItem>> GetAllUsersAsync()
		{
			throw new NotImplementedException();
		}

		public Task SaveUserAsync(UserItem user)
		{
			throw new NotImplementedException();
		}

		public Task<UserItem> GetUserAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task DeleteUserAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
