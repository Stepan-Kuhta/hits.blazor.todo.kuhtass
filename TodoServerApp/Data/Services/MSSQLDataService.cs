using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
	public class MSSQLDataService : IDataService
	{
		private readonly ApplicationDbContext context;

		public MSSQLDataService(ApplicationDbContext context)
		{
			this.context = context;
		}

		// Методы для задач
		public async Task<IEnumerable<TaskItem>> GetAllAsync()
		{
			return await context.TaskItems.Include(t => t.Assignee).ToArrayAsync();
		}

		public async Task SaveAsync(TaskItem taskItem)
		{
			if (taskItem.Id == 0)
			{
				taskItem.CreatedDate = DateTime.Now;
				await context.TaskItems.AddAsync(taskItem);
			}
			else
			{
				taskItem.CreatedDate = DateTime.Now;
				context.TaskItems.Update(taskItem);
			}
			await context.SaveChangesAsync();
		}

		public async Task<TaskItem> GetTaskAsync(int id)
		{
			return await context.TaskItems.Include(t => t.Assignee).FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task DeleteAsync(int id)
		{
			var taskItem = await context.TaskItems.FirstOrDefaultAsync(x => x.Id == id);
			if (taskItem != null)
			{
				context.TaskItems.Remove(taskItem);
				await context.SaveChangesAsync();
			}
		}

		// Методы для пользователей
		public async Task<IEnumerable<UserItem>> GetAllUsersAsync()
		{
			return await context.UserItems.ToArrayAsync(); // Получаем все данные о пользователях
		}

		public async Task SaveUserAsync(UserItem user)
		{
			if (user.Id == 0)
			{
				user.RegisteredDate = DateTime.Now; // Присваиваем дату регистрации
				await context.UserItems.AddAsync(user); // Добавляем нового пользователя
			}
			else
			{
				context.UserItems.Update(user); // Обновляем существующего пользователя
			}
			await context.SaveChangesAsync();
		}

		public async Task<UserItem> GetUserAsync(int id)
		{
			return await context.UserItems.FirstOrDefaultAsync(x => x.Id == id); // Получаем пользователя по ID
		}

		public async Task DeleteUserAsync(int id)
		{
			var userItem = await context.UserItems.FirstOrDefaultAsync(x => x.Id == id);
			if (userItem != null)
			{
				context.UserItems.Remove(userItem); // Удаляем пользователя
				await context.SaveChangesAsync();
			}
		}
	}
}
