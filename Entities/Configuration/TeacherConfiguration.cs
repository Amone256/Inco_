﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(
                new Teacher
                    {
                        Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                        Name = "Sam Okori",
                        Subject = "English",
                        Class = "Senior one",
                        Position = "HOD English",
                        SchoolId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")

                },new Teacher
                     {
                        Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                        Name = "Anold Emaru Raiden",
                        Subject = "Mathematics",
                        Class = "Senior Five",
                        Position = "Head Teacher",
                        SchoolId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")

                },new Teacher
                    {
                        Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                        Name = "Mathew Amone",
                        Subject = "ICT",
                        Class = "Senior Two",
                        Position = "Assistant HOD ICT",
                        SchoolId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    }
                );
        }
    }
}
