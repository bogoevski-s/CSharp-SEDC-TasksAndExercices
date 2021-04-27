using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    interface ITeacher : IUser
    {
        string Subject { get; set; }
    }
}
