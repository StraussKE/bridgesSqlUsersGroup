using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class AppIdentityDbContext : IdentityDbContext<User>
    {

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options) { }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many to Many bridge between user and meeting
            modelBuilder.Entity<UserMeeting>()
                .HasKey(um => new { um.UserId, um.MeetingId }); // defines composite key
            modelBuilder.Entity<UserMeeting>()
                .HasOne(um => um.User)
                .WithMany(u => u.AttendedMeetings)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserMeeting>()
                .HasOne(bc => bc.Meeting)
                .WithMany(c => c.MeetingAtendees)
                .HasForeignKey(bc => bc.MeetingId);

            // Many to Many bridge between meeting and tag
            modelBuilder.Entity<MeetingTag>()
                .HasKey(meetTag => new { meetTag.MeetingId, meetTag.TagId }); // defines composite key
            modelBuilder.Entity<MeetingTag>()
                .HasOne(meetTag => meetTag.Meeting)
                .WithMany(m => m.MeetingTags)
                .HasForeignKey(meetTag => meetTag.MeetingId);
            modelBuilder.Entity<MeetingTag>()
                .HasOne(meetTag => meetTag.Tag)
                .WithMany(t => t.TaggedMeetings)
                .HasForeignKey(meetTag => meetTag.TagId);

            // Many to Many bridge between meeting and Speaker
            modelBuilder.Entity<MeetingSpeaker>()
                .HasKey(meetSpeak => new { meetSpeak.MeetingId, meetSpeak.SpeakerId }); // defines composite key
            modelBuilder.Entity<MeetingSpeaker>()
                .HasOne(meetSpeak => meetSpeak.Meeting)
                .WithMany(m => m.MeetingSpeakers)
                .HasForeignKey(meetSpeak => meetSpeak.MeetingId);
            modelBuilder.Entity<MeetingSpeaker>()
                .HasOne(meetSpeak => meetSpeak.Speaker)
                .WithMany(s => s.MeetingsSpokenAt)
                .HasForeignKey(meetSpeak => meetSpeak.SpeakerId);

            // Many to Many bridge between meeting and tag
            modelBuilder.Entity<MeetingSponsor>()
                .HasKey(meetSpons => new { meetSpons.MeetingId, meetSpons.SponsorId }); // defines composite key
            modelBuilder.Entity<MeetingSponsor>()
                .HasOne(meetSpons => meetSpons.Meeting)
                .WithMany(m => m.MeetingSponsors)
                .HasForeignKey(meetSpons => meetSpons.MeetingId);
            modelBuilder.Entity<MeetingSponsor>()
                .HasOne(meetSpons => meetSpons.Sponsor)
                .WithMany(s => s.SponsoredMeetings)
                .HasForeignKey(meetSpons => meetSpons.SponsorId);
        }

        public static async Task CreateAdminAccount(IServiceProvider serviceProvider,
            IConfiguration configuration)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = configuration["Data:AdminUser:Name"];
            string email = configuration["Data:AdminUser:Email"];
            string password = configuration["Data:AdminUser:Password"];
            string role = configuration["Data:AdminUser:Role"];

            if (await userManager.FindByNameAsync(username) == null)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }

                User user = new User
                {
                    UserName = username,
                    Email = email
                };

                IdentityResult result = await userManager
                    .CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
