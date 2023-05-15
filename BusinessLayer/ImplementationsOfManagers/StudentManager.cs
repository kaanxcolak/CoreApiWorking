using AutoMapper;
using BusinessLayer.ImpementationsOfManagers;
using BusinessLayer.InterfacesOfManagers;
using DataLayer.InterfacesOfRepo;
using EntityLayer.Models;
using EntityLayer.ViewModels;

namespace BusinessLayer.ImplementationsOfManagers
{
    public class StudentManager : Manager<StudentVM, Student, int>, IStudentManager
    {
        public StudentManager(IStudentRepo repo, IMapper mapper) : base(repo, mapper, null)
        {

        }

    }
}
