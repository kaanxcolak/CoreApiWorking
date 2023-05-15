using DataLayer.InterfacesOfRepo;
using EntityLayer.Models;

namespace DataLayer.ImplementationOfRepo
{
    public class StudentRepo : Repository<Student,int> , IStudentRepo
    {
        public StudentRepo(MyContext context) : base(context)
        {
            
        }
    }
}
