using IrisCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisBusiness.Interfaces
{
    public interface IToDoBusiness
    {
        Task<List<ToDo>> GetToDoList(bool favorite);
        Task<bool> AddToDoList(ToDo toDo);
        Task<bool> PutToDoList(int id);
        Task<bool> DeleteToDoList(int id);
        Task<bool> PutFavoriteToDoList(int id);
    }
}
