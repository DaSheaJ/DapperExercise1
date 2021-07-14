using System;
using System.Collections.Generic;

namespace DapperExercise1
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
