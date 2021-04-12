//Interface for class schedule unit of work
namespace ClassSchedule.Models
{
    public interface IClassScheduleUnitOfWork
    {
        public Repository<Day> Days { get; }
        public Repository<Teacher> Teachers { get; }
        public Repository<Class> Classes { get; }
        public void Save();
    }
}
