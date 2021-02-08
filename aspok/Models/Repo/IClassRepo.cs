using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspok.Models.Repo
{
    public interface IClassRepo<Item>
    {
        List<Item> List();
        Item Find(int id);
        void Add(Item item);
        void Update(int id, Item item);
        void Delete(int id);
    }
}
