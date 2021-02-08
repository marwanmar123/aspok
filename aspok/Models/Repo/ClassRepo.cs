using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspok.Models.Repo
{
    public class ClassRepo : IClassRepo<Class>
    {
        ClassContext Db;
        //List<Class> classes;
        public ClassRepo(ClassContext Db)
        {
            this.Db = Db;
            //classes = new List<Class>()
            //{
            //    new Class{Id =1, Name="aaaa", Adresse="aaaa@aaa.aa", Age=20},
            //    new Class{Id =2, Name="bbbb", Adresse="bbbb@bbb.b", Age=20},
            //    new Class{Id =3, Name="ccccc", Adresse="ccccc@cccc.cc", Age=20}
            //};
        }
        public void Add(Class item)
        {
            Db.Classes.Add(item);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var clsitem = Find(id);
            Db.Classes.Remove(clsitem);
            Db.SaveChanges();
        }

        public Class Find(int id)
        {
            var clsitem = Db.Classes.SingleOrDefault(c => c.Id == id);
            return clsitem;
        }

        public List<Class> List()
        {
            return Db.Classes.ToList();
        }

        public void Update(int id, Class newitem)
        {
            Db.Classes.Update(newitem);
            Db.SaveChanges();
            //var clsitem = Find(id);
            //clsitem.Id = newitem.Id;
            //clsitem.Name = newitem.Name;
            //clsitem.Adresse = newitem.Adresse;
            //clsitem.Age = newitem.Age;
        }
    }
}
