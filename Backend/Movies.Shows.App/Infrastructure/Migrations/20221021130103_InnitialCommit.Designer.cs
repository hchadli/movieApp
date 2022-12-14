// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MovieShowsDbContext))]
    [Migration("20221021130103_InnitialCommit")]
    partial class InnitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("ActorTvShow", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("TvShowsId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "TvShowsId");

                    b.HasIndex("TvShowsId");

                    b.ToTable("ActorTvShow");
                });

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TvShowEpisodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvShowEpisodeId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genres")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Domain.Entities.TvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genres")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TvShows");
                });

            modelBuilder.Entity("Domain.Entities.TvShowEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TvShowSeasonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvShowSeasonId");

                    b.ToTable("TvShowEpisodes");
                });

            modelBuilder.Entity("Domain.Entities.TvShowSeason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<int>("TvShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvShowId");

                    b.ToTable("TvShowSeasons");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActorTvShow", b =>
                {
                    b.HasOne("Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TvShow", null)
                        .WithMany()
                        .HasForeignKey("TvShowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.HasOne("Domain.Entities.TvShowEpisode", null)
                        .WithMany("Actors")
                        .HasForeignKey("TvShowEpisodeId");
                });

            modelBuilder.Entity("Domain.Entities.TvShowEpisode", b =>
                {
                    b.HasOne("Domain.Entities.TvShowSeason", "TvShowSeason")
                        .WithMany("TvShowEpisodes")
                        .HasForeignKey("TvShowSeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TvShowSeason");
                });

            modelBuilder.Entity("Domain.Entities.TvShowSeason", b =>
                {
                    b.HasOne("Domain.Entities.TvShow", "TvShow")
                        .WithMany("TvShowSeasons")
                        .HasForeignKey("TvShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TvShow");
                });

            modelBuilder.Entity("Domain.Entities.TvShow", b =>
                {
                    b.Navigation("TvShowSeasons");
                });

            modelBuilder.Entity("Domain.Entities.TvShowEpisode", b =>
                {
                    b.Navigation("Actors");
                });

            modelBuilder.Entity("Domain.Entities.TvShowSeason", b =>
                {
                    b.Navigation("TvShowEpisodes");
                });
#pragma warning restore 612, 618
        }
    }
}
