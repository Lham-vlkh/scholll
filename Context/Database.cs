using Microsoft.EntityFrameworkCore;
using shcool.Models.Student;
using shcool.Models.Teacher;

namespace shcool.Context
{
    public class Database : DbContext
    {

        public DbSet<StudentInfo> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #region studentDB
            optionsBuilder.UseSqlServer("Server=DESKTOP-I2J2NP3;Database=Students_DB;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
            #endregion
            #region teacherDB
   
            #endregion
        }
<<<<<<< HEAD
        #endregion
        #region teacherDB
      
        #endregion
=======

>>>>>>> 7fb0c49bb7e78e961e0ea511dbf01c420e47299a
    }
    public class DB : DbContext
    {
        public DbSet<TeacherInfo> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opbilder)
        {
            opbilder.UseSqlServer("Server=ELIKA\\SQLSERVER2022;Database=Teachers_DB;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(opbilder);
        }
    }
}
