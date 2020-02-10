﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pangul.Backend.Web.Core;

namespace Pangul.Backend.Web.Migrations
{
    [DbContext(typeof(ServiceDb))]
    [Migration("20200121052131_MigrationToEf3")]
    partial class MigrationToEf3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Pangul.Core.Data.Questions.Answer", b =>
                {
                    b.Property<long>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AnswerGlobalMetaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<long>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerId");

                    b.HasIndex("AnswerGlobalMetaId")
                        .IsUnique();

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.AnswerGlobalMeta", b =>
                {
                    b.Property<long>("AnswerGlobalMetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerGlobalMetaId");

                    b.ToTable("AnswerGlobalMeta");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.AnswerMeta", b =>
                {
                    b.Property<long>("AnswerMetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AnswerId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnswerMetaId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("UserId");

                    b.ToTable("AnswerMeta");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.Question", b =>
                {
                    b.Property<long>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<long>("QuestionGlobalMetaId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("TimeCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<long>("TopicId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuestionGlobalMetaId")
                        .IsUnique();

                    b.HasIndex("TopicId");

                    b.HasIndex("UserId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.QuestionGlobalMeta", b =>
                {
                    b.Property<long>("QuestionGlobalMetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionGlobalMetaId");

                    b.ToTable("QuestionGlobalMeta");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.QuestionMeta", b =>
                {
                    b.Property<long>("QuestionMetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("QuestionId1")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<bool>("Star")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuestionMetaId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuestionId1");

                    b.HasIndex("UserId");

                    b.ToTable("QuestionMeta");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.QuestionTag", b =>
                {
                    b.Property<long>("QuestionTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionTagId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionTag");
                });

            modelBuilder.Entity("Pangul.Core.Data.Topics.Topic", b =>
                {
                    b.Property<long>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("BLOB");

                    b.Property<string>("IconType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("TimeCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("TopicId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("Pangul.Core.Data.Users.Login", b =>
                {
                    b.Property<long>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Pangul.Core.Data.Users.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("LoginId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.Property<long>("UserContactId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("LoginId")
                        .IsUnique();

                    b.HasIndex("UserContactId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Pangul.Core.Data.Users.UserContact", b =>
                {
                    b.Property<long>("UserContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("BLOB");

                    b.HasKey("UserContactId");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.Answer", b =>
                {
                    b.HasOne("Pangul.Core.Data.Questions.AnswerGlobalMeta", "AnswerGlobalMeta")
                        .WithOne("Answer")
                        .HasForeignKey("Pangul.Core.Data.Questions.Answer", "AnswerGlobalMetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Questions.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.AnswerMeta", b =>
                {
                    b.HasOne("Pangul.Core.Data.Questions.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.Question", b =>
                {
                    b.HasOne("Pangul.Core.Data.Questions.QuestionGlobalMeta", "QuestionGlobalMeta")
                        .WithOne("Question")
                        .HasForeignKey("Pangul.Core.Data.Questions.Question", "QuestionGlobalMetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Topics.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.QuestionMeta", b =>
                {
                    b.HasOne("Pangul.Core.Data.Questions.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pangul.Core.Data.Questions.Question", null)
                        .WithMany("Meta")
                        .HasForeignKey("QuestionId1");

                    b.HasOne("Pangul.Core.Data.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangul.Core.Data.Questions.QuestionTag", b =>
                {
                    b.HasOne("Pangul.Core.Data.Questions.Question", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pangul.Core.Data.Users.User", b =>
                {
                    b.HasOne("Pangul.Core.Data.Users.Login", "Login")
                        .WithOne("User")
                        .HasForeignKey("Pangul.Core.Data.Users.User", "LoginId");

                    b.HasOne("Pangul.Core.Data.Users.UserContact", "UserContact")
                        .WithOne("User")
                        .HasForeignKey("Pangul.Core.Data.Users.User", "UserContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
