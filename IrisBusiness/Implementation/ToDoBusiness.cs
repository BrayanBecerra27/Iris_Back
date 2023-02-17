using IrisBusiness.Interfaces;
using IrisCore.Entities;
using IrisCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisBusiness.Implementation
{
    public class ToDoBusiness : IToDoBusiness
    {
        public IToDoRepository _toDoRepository;
        public ToDoBusiness(IToDoRepository toDoRepository)
        {

            _toDoRepository = toDoRepository;
        }

        public async Task<bool> AddToDoList(ToDo toDo)
        {

            try
            {
                return await _toDoRepository.AddToDoRepository(toDo);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<List<ToDo>> GetToDoList(bool favorite)
        {
            try
            {
                return await _toDoRepository.GetToDotRepository(favorite);
            }
            catch(Exception ex)
            {
                return new List<ToDo>();
            }
            
        }

        public async Task<bool> PutToDoList(int id)
        {
            try
            {
                return await _toDoRepository.PutToDoRepository(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<bool> DeleteToDoList(int id)
        {
            try
            {
                return await _toDoRepository.DeleteToDoRepository(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> PutFavoriteToDoList(int id)
        {
            try
            {
                return await _toDoRepository.FavoriteToDoRepository(id);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
