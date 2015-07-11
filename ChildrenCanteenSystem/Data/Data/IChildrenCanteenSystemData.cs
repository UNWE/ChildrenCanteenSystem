namespace Data.Data
{
    using Models;
    using Repositories;

    public interface IChildrenCanteenSystemData
    {
        IRepository<Product> Products { get; }

        IRepository<MeasurementUnit> MeasuremnetUnits { get; }

        IRepository<MealType> MealTypes { get; }

        IRepository<Meal> Meals { get; }

        IRepository<Recipe> Recipes { get; }

        IRepository<PreliminaryCalculation> PreliminaryCalculations { get; }

        IRepository<Menu> Menus { get; }

        IRepository<Request> Requests { get; }

        IRepository<Availability> Availabilities { get; }

        IRepository<User> Users { get; }

        IRepository<Role> Roles { get; } 

        int SaveChanges();
    }
}
