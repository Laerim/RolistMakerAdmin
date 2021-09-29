using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolistMakerAdmin.GUI
{
    public class RolistMakerContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\Clem\Documents\DEV\CSharp\RolistMakerAdmin\RolistMaker.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MusiquePlaylist>().HasKey(mp => new { mp.MusiqueId, mp.PlaylistId });
            modelBuilder.Entity<PersonnageObjet>().HasKey(po => new { po.PersonnageId, po.ObjetId });
            modelBuilder.Entity<PersonnageRace>().HasKey(pr => new { pr.PersonnageId, pr.RaceId });
            modelBuilder.Entity<PersonnageCompetence>().HasKey(pc => new { pc.PersonnageId, pc.CompetenceId });
            modelBuilder.Entity<PersonnageStatistique>().HasKey(ps => new { ps.PersonnageId, ps.StatistiqueId });
            modelBuilder.Entity<StatistiqueObjet>().HasKey(so => new { so.StatistiqueId, so.ObjetId });
            modelBuilder.Entity<LieuMusique>().HasKey(lm => new { lm.LieuId, lm.MusiqueId });
            modelBuilder.Entity<ClasseCompetence>().HasKey(cc => new { cc.ClasseId, cc.CompetenceId });
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Sexe> Sexes { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Statistique> Statistiques { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Personnage> Personnages { get; set; }
        public DbSet<TypeObjet> TypeObjets { get; set; }
        public DbSet<Objet> Objets { get; set; }
        public DbSet<Musique> Musiques { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Lieu> Lieus { get; set; }
        public DbSet<LieuMusique> LieuMusiques { get; set; }
        public DbSet<MusiquePlaylist> MusiquePlaylists { get; set; }
        public DbSet<PersonnageObjet> PersonnageObjets { get; set; }
        public DbSet<PersonnageCompetence> PersonnageCompetences { get; set; }
        public DbSet<PersonnageStatistique> PersonnageStatistiques { get; set; }
        public DbSet<ClasseCompetence> ClasseCompetences { get; set; }
        public DbSet<StatistiqueObjet> StatistiqueObjets { get; set; }

    }

    public class Game
    {
        public int GameId { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public bool Race { get; set; }
        public bool Classe { get; set; }
        public bool Statistique { get; set; }
        public bool Competence { get; set; }

    }
    public class Sexe
    {
        public int SexeId { get; set; }
        public string Nom { get; set; }
        public Game Game { get; set; }
    }
    public class Competence
    {
        public int CompetenceId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public IList<ClasseCompetence> ClasseCompetences { get; set; }
        public IList<PersonnageCompetence> PersonnageCompetences { get; set; }
    }
    public class Race
    {
        public int RaceId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
    }
    public class Classe
    {
        public int ClasseId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public IList<ClasseCompetence> ClasseCompetences { get; set; }

    }
    public class Statistique
    {
        public int StatistiqueId { get; set; }
        public string Nom { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public bool Active { get; set; }
        public Game Game { get; set; }
        public IList<PersonnageStatistique> PersonnageStatistiques { get; set; }
        public IList<StatistiqueObjet> StatistiqueObjets { get; set; }
    }
    public enum TypeImage
    {
        Icone,
        Portrait,
        Representation
    }
    public class Image
    {
        public int ImageId { get; set; }
        public string Nom { get; set; }
        public string Lien { get; set; }
        public TypeImage Type { get; set; }
        public Game Game { get; set; }
    }
    public class Personnage
    {
        public int PersonnageId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Description { get; set; }
        public Sexe Sexe { get; set; }
        public Game Game { get; set; }
        public Race Race { get; set; }
        public Classe Classe { get; set; }
        public IList<PersonnageRace> PersonnageRaces { get; set; }
        public IList<PersonnageCompetence> PersonnageCompetences { get; set; }
        public IList<PersonnageStatistique> PersonnageStatistiques { get; set; }
        public IList<PersonnageObjet> PersonnageObjets { get; set; }

    }
    public class TypeObjet
    {
        public int TypeObjetId { get; set; }
        public string Nom { get; set; }
        public Image Image { get; set; }
        public Game Game { get; set; }
    }
    public class Objet
    {
        public int ObjetId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public TypeObjet TypeObjet { get; set; }
        public Game Game { get; set; }
        public IList<PersonnageObjet> PersonnageObjets { get; set; }
        public IList<StatistiqueObjet> StatistiqueObjets { get; set; }


    }
    public class De
    {
        public int DeId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int NbFace { get; set; }

    }
    public class Musique
    {
        public int MusiqueId { get; set; }
        public string Nom { get; set; }
        public string Lien { get; set; }
        public Game Game { get; set; }
        public IList<MusiquePlaylist> MusiquePlaylists { get; set; }
        public IList<LieuMusique> LieuMusique { get; set; }
    }
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public IList<MusiquePlaylist> MusiquePlaylists { get; set; }

    }
    public class Lieu
    {
        public int LieuId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public Game Game { get; set; }
        public IList<LieuMusique> LieuMusique { get; set; }

    }
    public class LieuMusique
    {
        public int LieuId { get; set; }
        public Lieu Lieu { get; set; }

        public int MusiqueId { get; set; }
        public Musique Musique { get; set; }

        public int Ordre { get; set; }
    }
    public class PersonnageObjet
    {
        public int PersonnageId { get; set; }
        public Personnage Personnage { get; set; }

        public int ObjetId { get; set; }
        public Objet Objet { get; set; }

        public int Quantite;
    }
    public class ClasseCompetence
    {
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }


        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }
    }
    public class PersonnageRace
    {
        public int PersonnageId { get; set; }
        public Personnage Personnage { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }
    }
    public class PersonnageCompetence
    {
        public int PersonnageId { get; set; }
        public Personnage Personnage { get; set; }

        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }
    }
    public class PersonnageStatistique
    {

        public int PersonnageId { get; set; }
        public Personnage Personnage { get; set; }

        public int StatistiqueId { get; set; }
        public Statistique Statistique { get; set; }

        public int Max { get; set; }
        public int Total { get; set; }
    }
    public class MusiquePlaylist
    {
        public int MusiqueId { get; set; }
        public Musique Musique { get; set; }

        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
    }
    public class StatistiqueObjet
    {
        public int StatistiqueId { get; set; }
        public Statistique Statistique { get; set; }

        public int ObjetId { get; set; }
        public Objet Objet { get; set; }

        public int Bonus { get; set; }
    }
}
