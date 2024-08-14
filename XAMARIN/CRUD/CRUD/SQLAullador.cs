using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using CRUD.Model;

namespace CRUD
{
     public class SQLAullador
    {
        private readonly SQLiteAsyncConnection db;

        public SQLAullador (string dbPath)
        {
            db = new SQLiteAsyncConnection (dbPath);
            db.CreateTableAsync<empleadomodel>();
        }
        public Task<int> CrearEmpleado (empleadomodel empleado)
        {
            return db.InsertAsync(empleado);
        }
        public Task<List<empleadomodel>> LeeEmpleados()
        {
            return db.Table<empleadomodel>().ToListAsync();
        }
        public Task <int> ActualizaEmpleados(empleadomodel empleado)
        {
            return db.UpdateAsync(empleado);
        }
        public Task<int> MatarEmpleado(empleadomodel empleado)
        {
            return db.DeleteAsync(empleado);
        }
    }
}
