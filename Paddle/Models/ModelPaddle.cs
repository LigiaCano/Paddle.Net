namespace Paddle.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelPaddle : DbContext
    {
        public ModelPaddle()
            : base("name=ModelPaddle")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Court> Courts { get; set; }
    }
}
