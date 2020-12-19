```c#
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF.Models
{
    public class StudentContext : DbContext
    {
    
        public StudentContext() : base("name=StudentContext")
        {
        }

        public System.Data.Entity.DbSet<E.Models.Student> Students { get; set; }
    
    }
}

```

