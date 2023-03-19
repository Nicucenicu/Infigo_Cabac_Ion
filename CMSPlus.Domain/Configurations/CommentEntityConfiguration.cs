﻿using CMSPlus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Configurations
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {

            builder.ToTable("Comments");
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x=>x.Comment).IsRequired();
            builder.Property(x=>x.TopicId).IsRequired();
        }
    }
}
