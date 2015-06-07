namespace Data.Context
{
    using System.Data.Entity;
    using Models;

    public interface IChildrenCanteenSystemDbContext
    {
        IDbSet<Product> Products { get; }

        IDbSet<MeasurementUnit> MeasurementUnits { get; }

        IDbSet<MealType> MealTypes { get; }

        IDbSet<Meal> Meals { get; }

        IDbSet<Recipe> Recipes { get; }

        IDbSet<PreliminaryCalculation> PreliminaryCalculations { get; }

        IDbSet<Menu> Menus { get; }

        IDbSet<Request> Requests { get; }

        IDbSet<Availability> Availabilities { get; }

        IDbSet<User> Users { get; }

        IDbSet<Role> Roles { get; }

        int SaveChanges();
    }
}
