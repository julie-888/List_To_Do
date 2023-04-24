using List_To_Do.Model;

namespace List_To_Do.Services.Interfaces
{
    public interface IToDoService
    {
        public List<ToDo> GetToDoList();
        public void AddToDo(ToDo toDo);
    }
}
