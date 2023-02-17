using IrisCore.Entities;
using IrisCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisCore.Implementation
{
    public class ToDoRepository : IToDoRepository
    {
        public ToDoDbContex _dbContext;
        public ToDoRepository(ToDoDbContex toDoDbContex)
        {
            _dbContext = toDoDbContex;
        }

        public async Task<bool> AddToDoRepository(ToDo toDo)
        {
            _dbContext.Add<ToDo>(toDo);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        public async Task<List<ToDo>> GetToDotRepository(bool favorite)
        {
            return await _dbContext.ToDo.Where(s => s.IsFavorite == favorite).ToListAsync();
        }

        public async Task<bool> PutToDoRepository(int id)
        {
            bool updateFavorite = false;
            ToDo toDo = await _dbContext.ToDo.Where(s => s.Id == id).FirstOrDefaultAsync();
            if (toDo.Id > 0)
            {
                toDo.IsCompleted = true;
                _dbContext.Update<ToDo>(toDo);
                updateFavorite = (await _dbContext.SaveChangesAsync()) > 0;
            }
            return updateFavorite;
        }
        public async Task<bool> DeleteToDoRepository(int id)
        {
            ToDo toDo = await _dbContext.ToDo.Where(s => s.Id == id).FirstOrDefaultAsync();
            _dbContext.Remove<ToDo>(toDo); 
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        public async Task<bool> FavoriteToDoRepository(int id)
        {
            bool updateFavorite = false;
            ToDo toDo = await _dbContext.ToDo.Where(s => s.Id == id).FirstOrDefaultAsync();
            if (toDo.Id > 0)
            {
                toDo.IsFavorite = true;
                _dbContext.Update<ToDo>(toDo);
                updateFavorite = (await _dbContext.SaveChangesAsync()) > 0;
            }
            return updateFavorite;
        }
    }
}
