using IrisCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisCore.Interfaces
{
    public interface IToDoRepository
    {
        Task<List<ToDo>> GetToDotRepository(bool favorite);
        Task<bool> AddToDoRepository(ToDo toDo);
        Task<bool> PutToDoRepository(int id);
        Task<bool> DeleteToDoRepository(int id);
        Task<bool> FavoriteToDoRepository(int id);
    }
}
