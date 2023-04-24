using List_To_Do.Data;
using List_To_Do.Model;
using List_To_Do.Services.Interfaces;

namespace List_To_Do.Services
{
    public class toDoService: IToDoService
    {
        private readonly AppDbContext context;
        public toDoService(AppDbContext context)
        {
            this.context = context;
        }
    //    private List<ToDo> toDo = new List<ToDo>() { new ToDo {Id = 1
    //    , Title = "First Task"
    //    , Date = DateTime.Now
    //    , IsDone = false
    //},
    //new ToDo {

    //Id = 2
    //, Title = "First Task"
    //, Date = DateTime.Now
    //, IsDone = false
    //}
    //};
            public List<ToDo> GetToDoList()
            {
            var toDoList = context.ToDo.ToList();
            return toDoList;
            }
        public void AddToDo(ToDo toDo)
        {
            toDo.Date = DateTime.Now;
            toDo.IsDone=false;
            context.ToDo.Add(toDo);
            context.SaveChanges();    
        }
        public void ChangeIsDone(int id, bool isDone)
        {
            var item = context.ToDo
                .SingleOrDefault(x => x.Id == id);
            if(item != null) {
            item.IsDone= isDone;
            context.SaveChanges() ;
            }
        }

      
    }      
}
