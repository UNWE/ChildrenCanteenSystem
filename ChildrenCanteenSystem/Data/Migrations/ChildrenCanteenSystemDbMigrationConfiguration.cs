﻿namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    using Context;
    using Models;

    public class ChildrenCanteenSystemDbMigrationConfiguration
        : DbMigrationsConfiguration<ChildrenSystemDbContext>
    {
        public ChildrenCanteenSystemDbMigrationConfiguration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ChildrenSystemDbContext context)
        {
            if (!context.Products.Any())
            {
                this.AddUsers(context);
                this.AddAdminUser(context);
                this.AddMeasurementUnits(context);
                this.AddProducts(context);
                this.AddAvailabilities(context);
                this.AddMealTypes(context);
                this.AddMeals(context);
                this.AddRecipies(context);
            }
        }

        #region Help seed methods

        private void AddAdminUser(ChildrenSystemDbContext context)
        {
            HashAlgorithm hash = new MD5CryptoServiceProvider();

            string adminPassword = "123456";
            string hashPass =
                Convert.ToBase64String(hash.ComputeHash(Encoding.ASCII.GetBytes(adminPassword)));

            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var adminRole = new Role
                {
                    Name = "Administrator"
                };

                var adminUser = new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Username = "admin",
                    Password = hashPass,
                };

                context.Roles.Add(adminRole);
                context.SaveChanges();
                adminUser.Roles.Add(adminRole);
                context.Users.Add(adminUser);
                context.SaveChanges();
            }
        }

        private void AddUsers(ChildrenSystemDbContext context)
        {
            HashAlgorithm hash = new MD5CryptoServiceProvider();

            string password = "123456";
            string hashPass =
                Convert.ToBase64String(hash.ComputeHash(Encoding.ASCII.GetBytes(password)));


            var mariaUser = new User
            {
                FirstName = "Maria",
                LastName = "Ivanova",
                Username = "maria",
                Password = hashPass,
            };

            context.SaveChanges();
            context.Users.Add(mariaUser);
            context.SaveChanges();

            var nikolaUser = new User
            {
                FirstName = "Nikola",
                LastName = "Petrov",
                Username = "nikola",
                Password = hashPass,
            };

            context.SaveChanges();
            context.Users.Add(nikolaUser);
            context.SaveChanges();
        }

        private void AddMeasurementUnits(ChildrenSystemDbContext context)
        {
            context.MeasurementUnits.AddOrUpdate(
                new MeasurementUnit
                {
                    Name = "кг"
                },
                new MeasurementUnit
                {
                    Name = "бр"
                },
                new MeasurementUnit
                {
                    Name = "л"
                });

            context.SaveChanges();
        }

        private void AddProducts(ChildrenSystemDbContext context)
        {
            context.Products.AddOrUpdate(
                new Product
                {
                    Name = "Лющен боб",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Банани",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Бисквити",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Брашно",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Ванилия",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "бр")
                },
                new Product
                {
                    Name = "Грис",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Джоджен",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Домати консерва",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Замразен зелен фасул",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Замразен грах",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Замразен карфиол",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Захар",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Извара",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Картофи",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Кисело мляко",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Краве масло",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Кус кус",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Леща",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Лук - кромид",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Магданоз",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Макарони",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Мляко - сухо",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Моркови",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Нектар",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "л")
                },
                new Product
                {
                    Name = "Нишесте",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Овесени ядки",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Олио",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "л")
                },
                new Product
                {
                    Name = "Ориз",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Паприкаш",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Пилешки бутчета",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Пилешко филе",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Праз",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Прясно краве мляко",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "л")
                },
                new Product
                {
                    Name = "Пуешко месо",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Пшеница",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Риба",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Сол",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Фиде",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Червен пипер",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Чубрица",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Яйца",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "бр")
                },
                new Product
                {
                    Name = "Телешко месо",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Броколи",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Заешко месо",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Праскови",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Ябълки",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                },
                new Product
                {
                    Name = "Бишкоти",
                    MeasurementUnit = context.MeasurementUnits.First(m => m.Name == "кг")
                });

            context.SaveChanges();
        }

        private void AddAvailabilities(ChildrenSystemDbContext context)
        {
            foreach (var product in context.Products)
            {
                context.Availabilities.Add(new Availability
                {
                    Product = product,
                    Batch = "2015060" + product.Id,
                    Quantity = 50f,
                    UnitPrice = 1.05m
                });
            }

            foreach (var product in context.Products)
            {
                context.Availabilities.Add(new Availability
                {
                    Product = product,
                    Batch = "2015061" + product.Id,
                    Quantity = 50f,
                    UnitPrice = 0.58m
                });
            }

            context.SaveChanges();
        }

        private void AddMealTypes(ChildrenSystemDbContext context)
        {
            context.MealTypes.AddOrUpdate(
                new MealType
                {
                    Name = "Предястие"
                },
                new MealType
                {
                    Name = "Основно"
                },
                new MealType
                {
                    Name = "Десерт"
                });

            context.SaveChanges();
        }

        private void AddMeals(ChildrenSystemDbContext context)
        {
            context.Meals.AddOrUpdate(
                new Meal
                {
                    Name = "Крем супа моркови",
                    MealType = context.MealTypes.First(t => t.Name == "Предястие")
                },
                new Meal
                {
                    Name = "Крем супа картофи",
                    MealType = context.MealTypes.First(t => t.Name == "Предястие")
                },
                new Meal
                {
                    Name = "Супа броколи",
                    MealType = context.MealTypes.First(t => t.Name == "Предястие")
                },
                new Meal
                {
                    Name = "Пуешко яхния",
                    MealType = context.MealTypes.First(t => t.Name == "Основно")
                },
                new Meal
                {
                    Name = "Телешко с картофи и моркови",
                    MealType = context.MealTypes.First(t => t.Name == "Основно")
                },
                new Meal
                {
                    Name = "Заешко с ориз и броколи",
                    MealType = context.MealTypes.First(t => t.Name == "Основно")
                },
                new Meal
                {
                    Name = "Пшеница с мляко",
                    MealType = context.MealTypes.First(t => t.Name == "Десерт")
                },
                new Meal
                {
                    Name = "Кисел от праскова и ябълка",
                    MealType = context.MealTypes.First(t => t.Name == "Десерт")
                },
                new Meal
                {
                    Name = "Сладкиш с праскови и кисело мляко",
                    MealType = context.MealTypes.First(t => t.Name == "Десерт")
                });

            context.SaveChanges();
        }

        private void AddRecipies(ChildrenSystemDbContext context)
        {
            #region Recipe Крем супа моркови
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Моркови"),
                    Quantity = 10
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Лук - кромид"),
                    Quantity = 5
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Брашно"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Олио"),
                    Quantity = 0.100f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Яйца"),
                    Quantity = 13
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа моркови"),
                    Product = context.Products.First(p => p.Name == "Сол"),
                    Quantity = 0.025f
                });
            #endregion

            #region Recipe Крем супа картофи
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Картофи"),
                    Quantity = 10
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Лук - кромид"),
                    Quantity = 5
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Брашно"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Олио"),
                    Quantity = 0.100f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Яйца"),
                    Quantity = 13
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Крем супа картофи"),
                    Product = context.Products.First(p => p.Name == "Сол"),
                    Quantity = 0.025f
                });
            #endregion

            #region Recipe Супа броколи
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Броколи"),
                    Quantity = 12
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Лук - кромид"),
                    Quantity = 5
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Олио"),
                    Quantity = 0.100f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Ориз"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Магданоз"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Супа броколи"),
                    Product = context.Products.First(p => p.Name == "Сол"),
                    Quantity = 0.025f
                });
            #endregion

            #region Recipe Пуешко яхния
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Домати консерва"),
                    Quantity = 2.400f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Лук - кромид"),
                    Quantity = 2.800f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Магданоз"),
                    Quantity = 1
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Олио"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Сол"),
                    Quantity = 0.025f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пуешко яхния"),
                    Product = context.Products.First(p => p.Name == "Пуешко месо"),
                    Quantity = 4
                });
            #endregion

            #region Recipe Телешко с картофи и моркови
            context.Recipes.AddOrUpdate(
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Лук - кромид"),
                Quantity = 2.800f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Магданоз"),
                Quantity = 0.500f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Олио"),
                Quantity = 0.500f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Сол"),
                Quantity = 0.025f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Телешко месо"),
                Quantity = 4
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Картофи"),
                Quantity = 1.300f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Телешко с картофи и моркови"),
                Product = context.Products.First(p => p.Name == "Моркови"),
                Quantity = 1.200f
            });
            #endregion

            #region Recipe Пшеница с мляко
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пшеница с мляко"),
                    Product = context.Products.First(p => p.Name == "Ванилия"),
                    Quantity = 8
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пшеница с мляко"),
                    Product = context.Products.First(p => p.Name == "Захар"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пшеница с мляко"),
                    Product = context.Products.First(p => p.Name == "Прясно краве мляко"),
                    Quantity = 15
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Пшеница с мляко"),
                    Product = context.Products.First(p => p.Name == "Пшеница"),
                    Quantity = 2
                });
            #endregion

            #region Recipe Кисел от праскова и ябълка
            context.Recipes.AddOrUpdate(
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Кисел от праскова и ябълка"),
                    Product = context.Products.First(p => p.Name == "Праскови"),
                    Quantity = 8
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Кисел от праскова и ябълка"),
                    Product = context.Products.First(p => p.Name == "Захар"),
                    Quantity = 0.500f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Кисел от праскова и ябълка"),
                    Product = context.Products.First(p => p.Name == "Ябълки"),
                    Quantity = 9
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Кисел от праскова и ябълка"),
                    Product = context.Products.First(p => p.Name == "Нишесте"),
                    Quantity = 0.200f
                },
                new Recipe
                {
                    Meal = context.Meals.First(m => m.Name == "Кисел от праскова и ябълка"),
                    Product = context.Products.First(p => p.Name == "Прясно краве мляко"),
                    Quantity = 1.300f
                });
            #endregion

            #region Recipe Сладкиш с праскови и кисело мляко
            context.Recipes.AddOrUpdate(
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Сладкиш с праскови и кисело мляко"),
                Product = context.Products.First(p => p.Name == "Праскови"),
                Quantity = 8
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Сладкиш с праскови и кисело мляко"),
                Product = context.Products.First(p => p.Name == "Кисело мляко"),
                Quantity = 1.500f
            },
            new Recipe
            {
                Meal = context.Meals.First(m => m.Name == "Сладкиш с праскови и кисело мляко"),
                Product = context.Products.First(p => p.Name == "Бишкоти"),
                Quantity = 1.200f
            });
            #endregion

            context.SaveChanges();
        }

        #endregion
    }
}
