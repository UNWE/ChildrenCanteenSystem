namespace Data.Context
{
    using System.Data.Entity;
    using Migrations;
    using Models;

    public class ChildrenSystemDbContext : DbContext, IChildrenCanteenSystemDbContext
    {
        public ChildrenSystemDbContext()
            : base("ChildrenCanteenSystemDbConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<
                ChildrenSystemDbContext,
                ChildrenCanteenSystemDbMigrationConfiguration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                   .HasMany<Meal>(menu => menu.Meals)
                   .WithMany(meal => meal.Menus)
                   .Map(mm =>
                   {
                       mm.MapLeftKey("КодМеню");
                       mm.MapRightKey("КодЯстие");
                       mm.ToTable("МенюЯстия");
                   });

            modelBuilder.Entity<User>()
                .HasMany(t => t.Roles)
                .WithMany(t => t.Users)
                .Map(m =>
                {
                    m.MapLeftKey("КодПотребител");
                    m.MapRightKey("КодРоля");
                    m.ToTable("ПотребителРоли");
                });

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<MeasurementUnit> MeasurementUnits { get; set; }

        public IDbSet<MealType> MealTypes { get; set; }

        public IDbSet<Meal> Meals { get; set; }

        public IDbSet<Recipe> Recipes { get; set; }

        public IDbSet<PreliminaryCalculation> PreliminaryCalculations { get; set; }

        public IDbSet<Menu> Menus { get; set; }

        public IDbSet<Request> Requests { get; set; }

        public IDbSet<Availability> Availabilities { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Role> Roles { get; set; } 
    }
}
