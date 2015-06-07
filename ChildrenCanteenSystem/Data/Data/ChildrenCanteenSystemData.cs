namespace Data.Data
{
    using System;
    using System.Collections.Generic;
    using Context;
    using Models;
    using SkillExchange.Data.Repositories;

    public class ChildrenCanteenSystemData : IChildrenCanteenSystemData
    {
        private readonly IChildrenCanteenSystemDbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        public ChildrenCanteenSystemData() : this(new ChildrenSystemDbContext())
        {
            
        }

        public ChildrenCanteenSystemData(IChildrenCanteenSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        public IRepository<Product> Products
        {
            get { return this.GetRepository<Product>(); }
        }

        public IRepository<MeasurementUnit> MeasuremnetUnits
        {
            get { return this.GetRepository<MeasurementUnit>(); }
        }

        public IRepository<MealType> MealTypes
        {
            get { return this.GetRepository<MealType>(); }
        }

        public IRepository<Meal> Meals
        {
            get { return this.GetRepository<Meal>(); }
        }

        public IRepository<Recipe> Recipes
        {
            get { return this.GetRepository<Recipe>(); }
        }

        public IRepository<PreliminaryCalculation> PreliminaryCalculations
        {
            get { return this.GetRepository<PreliminaryCalculation>(); }
        }

        public IRepository<Menu> Menus
        {
            get { return this.GetRepository<Menu>(); }
        }

        public IRepository<Request> Requests
        {
            get { return this.GetRepository<Request>(); }
        }

        public IRepository<Availability> Availabilities
        {
            get { return this.GetRepository<Availability>(); }
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Role> Roles
        {
            get { return this.GetRepository<Role>(); }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(Repository<T>);
                this.repositories.Add(typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
