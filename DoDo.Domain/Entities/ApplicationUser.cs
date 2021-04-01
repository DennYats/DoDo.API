using DoDo.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DoDo.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime JoinDate { get; set; }
        public int? GoogleId { get; set; }
        public bool IsPremiumUser { get; set; }
        public DateTime? PremiumSubscriptionUntil { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTime? Birthday { get; set; }


        public Lang Language { get; set; } = Lang.en;
        public Theme Theme { get; set; } = Theme.Default;
        public DateFormat DateFormat { get; set; } = DateFormat.DD_MM_YYYY;
        public TimeFormat TimeFormat { get; set; } = TimeFormat.full;
        public Day StartDayOfWeek { get; set; } = Day.Monday;


        public List<ToDoList> ToDoLists { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}