using TagConsumer.Data;

namespace Tag.Consumer.Services
{
    public class UnitOfWork
    {
        private DataContext db { get; set; }
        public UnitOfWork(DataContext context)
        {
            db = context;
        }
        private DataService dataService { get; set; }
        public DataService DataRepository
        {
            get
            {
                if(this.dataService == null)
                    this.dataService = new DataService();

                return this.dataService;
            }
        }

        private UserService userService { get; set; }
        public UserService UserRepository
        {
            get
            {
                if(this.userService == null)
                    this.userService = new UserService();

                return this.userService;
            }
        }
    }
}