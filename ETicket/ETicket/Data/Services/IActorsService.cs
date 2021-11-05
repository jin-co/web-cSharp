using ETicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Data.Services
{
    /* It is possible to get data and manipulate data in the Controllers
     * but it is better practice to use Services
     * make an interface -> implement
     */

    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor actor);
        void Delete(int id);
    }
}
