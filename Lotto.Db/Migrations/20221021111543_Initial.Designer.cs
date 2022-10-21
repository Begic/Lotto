﻿// <auto-generated />
using System;
using Lotto.Db.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lotto.Db.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20221021111543_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Lotto.Db.Entities.Lotto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfWinning")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FifthWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FourthWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("HasWon")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("PaidSum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SecondWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SixthWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdWinNumber")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("WonSum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lottos");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoJokerNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Draw")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("JokerNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LottoNumberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LottoNumberId");

                    b.ToTable("LottoJokerNumbers");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FifthNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FourthNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LottoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SixthNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ThirdNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TippNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LottoId");

                    b.ToTable("LottoNumbers");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoPlusNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Draw")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LottoNumberId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberFifth")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberFirst")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberFourth")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberSecond")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberSixth")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlusNumberThird")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LottoNumberId");

                    b.ToTable("LottoPlusNumbers");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoJokerNumber", b =>
                {
                    b.HasOne("Lotto.Db.Entities.LottoNumber", "LottoNumber")
                        .WithMany("LottoJokerNumbers")
                        .HasForeignKey("LottoNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LottoNumber");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoNumber", b =>
                {
                    b.HasOne("Lotto.Db.Entities.Lotto", "Lotto")
                        .WithMany("LottoNumbers")
                        .HasForeignKey("LottoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lotto");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoPlusNumber", b =>
                {
                    b.HasOne("Lotto.Db.Entities.LottoNumber", "LotoNumber")
                        .WithMany("LottoPlusNumbers")
                        .HasForeignKey("LottoNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LotoNumber");
                });

            modelBuilder.Entity("Lotto.Db.Entities.Lotto", b =>
                {
                    b.Navigation("LottoNumbers");
                });

            modelBuilder.Entity("Lotto.Db.Entities.LottoNumber", b =>
                {
                    b.Navigation("LottoJokerNumbers");

                    b.Navigation("LottoPlusNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}