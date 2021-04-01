using DoDo.Domain.Entities;
using DoDo.Domain.Enums;
using DoDo.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoDo.Infrastructure.Persistence
{
    public class DataSeed
    {
        public static async Task SeedUsersAndToDoDataAsync(DoDoContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser user = new ApplicationUser
            {
                UserName = "creator",
                FirstName = "Denny",
                LastName = "Yats",
                Sex = Sex.Man,
                Email = "creator@gmail.com",
                EmailConfirmed = true,
                Birthday = new DateTime(2001, 01, 01),
                PhoneNumber = "+380777777777",
                IsPremiumUser = true,
            };

            string[] roles = new string[]
            {
                "SuperAdmin",
                "Admin",
                "PremiumUser",
                "NonPremiumUser"
            };


            if (!db.Roles.Any())
            {
                foreach (string role in roles)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            if (!db.Users.Any())
            {
                await userManager.CreateAsync(user, "Passw0rd.");
                await userManager.AddToRoleAsync(user, "SuperAdmin");
            }

            ToDoList all = new ToDoList { Id = 1, Title = "All", User = user };
            ToDoList today = new ToDoList { Id = 2, Title = "Today", User = user };
            ToDoList tomorrow = new ToDoList { Id = 3, Title = "Tomorrow", User = user };

            List<ToDoList> mainLists = new List<ToDoList>
            {
                all,
                today,
                tomorrow
            };

            List<ToDoItem> sampleItems = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Id = 1,
                    ParentList = all,
                    Title = "First task",
                    Notification = Notification.None,
                },
                new ToDoItem
                {
                    Id = 2,
                    ParentList = all,
                    Title = "Second task",
                    Notification = Notification.SingleStart,
                },
                new ToDoItem
                {
                    Id = 3,
                    ParentList = all,
                    Title = "Third task",
                    Notification = Notification.SingleFinish,
                },
            };

            if (!db.ToDoLists.Any())
            {
                await db.ToDoLists.AddRangeAsync(mainLists);
                await db.SaveChangesAsync();
            }

            if (!db.ToDoItems.Any())
            {
                await db.ToDoItems.AddRangeAsync(sampleItems);
                await db.SaveChangesAsync();
            }
        }
    }
}
