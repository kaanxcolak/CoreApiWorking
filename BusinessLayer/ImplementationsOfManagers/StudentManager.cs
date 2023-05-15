using AutoMapper;
using BusinessLayer.InterfacesOfManagers;
using DataLayer.InterfacesOfRepo;
using EntityLayer.Models;
using EntityLayer.ResultModels;
using EntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ImplementationsOfManagers
{
    public class StudentManager : Manager<StudentVM, Student, int>,IStudentManager
    {
        public StudentManager(IStudentRepo repo, IMapper mapper) : base(repo, mapper, null)
        {

        }
    }
}