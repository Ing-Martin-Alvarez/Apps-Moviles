using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CRUD.Model
{
    public class empleadomodel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
