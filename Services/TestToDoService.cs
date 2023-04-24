using List_To_Do.Model;
using List_To_Do.Services.Interfaces;

namespace List_To_Do.Services
{
    public class TestToDoService: IToDoService
    {
        private List<ToDo> toDos = new List<ToDo>()
        { new ToDo
        { 
              Id = 1
            , Title = "First Task"
            , Date = DateTime.Now
            , IsDone = false
        },
        new ToDo {

        Id = 2
        , Title = "First Task"
        , Date = DateTime.Now
        , IsDone = true
        }
        };

        public void AddToDo(ToDo toDo)
        {
            toDo.Date = DateTime.Now;
            toDos.Add(toDo);
        }

        public List<ToDo> GetToDoList()
        {
            return toDos;
        }
    }
}
