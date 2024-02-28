using Intro.DataAccess.Conctretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection
    private readonly CourseDal _courseDal;
    

    public CourseManager(CourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {       
        // Business Rules
        CourseDal courseDal = new CourseDal();
        return courseDal.GetAll();
    }
}
