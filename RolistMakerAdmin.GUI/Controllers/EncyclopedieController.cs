using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using RolistMakerAdmin.GUI.Models;

namespace RolistMakerAdmin.GUI.Controllers
{
    public  class EncyclopedieController
    {
        
        #region ATTRIBUTS

        private static EncyclopedieController encyclopedie = null;
        private static readonly object myLock = new object();
        private RolistMakerContext db = new RolistMakerContext();
        private static SQL_Models _sqlModels = SQL_Models.GetInstance;



        #endregion

        #region ACCESSEURS
        public static int IDGame { get; set; }
        private static Game myGame { get; set; }

        public static EncyclopedieController GetInstance
        {
            get
            {
                lock (myLock)
                {
                    if (encyclopedie == null)
                        encyclopedie = new EncyclopedieController();
                    return encyclopedie;
                }
            }
        }
        #endregion

        #region METHODES

        private void CreateFolders(string sGameName)
        {
            string sPath = Environment.CurrentDirectory;
            Directory.CreateDirectory(Path.Combine(sPath, sGameName.Trim()));
            sPath = Path.Combine(sPath, sGameName.Trim(), "Ressources");
            foreach (TypeImage value in Enum.GetValues(typeof(TypeImage)))
            {
                Directory.CreateDirectory(Path.Combine(sPath, "Images", value.ToString()));
            }
            Directory.CreateDirectory(Path.Combine(sPath, "Musiques"));
        }
        private string GetGameFolder()
        {
            Game game = GetGame(IDGame);
            string sPath =  Path.Combine(Environment.CurrentDirectory, game.Titre.Trim());
            return sPath;
        }
        
       
        

        #endregion

        #region GAME
        public List<Game> GetAllGames()
        {
            var games = db.Games
                      .OrderBy(b => b.GameId).ToList();

            return games;
        }
        public Game GetGame(int? id)
        {
            try
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == id);
                return game;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer le jeu en à l'id " + id, ex);
            }
        }
        public int SaveGame(int? id, string sTitre, string sDescription)
        {
            try
            {
                if (sTitre.Trim() != string.Empty)
                {
                    Game game = new Game();
                    if (id != 0 && id != null)
                    {
                        game = db.Games.FirstOrDefault(d => d.GameId == id);
                    }
                    game.Titre = sTitre.Trim();
                    game.Description = sDescription.Trim();
                    if (id == 0 || id == null)
                    {
                        
                        db.Games.Add(game);
                        CreateFolders(sTitre.Trim());
                    }
                    db.SaveChanges();
                    IDGame = game.GameId;
                    myGame = game;
                    return game.GameId;
                }
                else
                    throw new Exception("Indiquer un titre à votre jeu");
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible d'enregistrer le jeu :\n"+ ex.Message);
            }
        }
        public void SetParamPersonnages(bool bRace, bool bClasse, bool bCompetence, bool bStatistique)
        {
            try
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                game.Race = bRace;
                game.Classe = bClasse;
                game.Competence = bCompetence;
                game.Statistique = bStatistique;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible d'enregistrer les paramétrage : ", ex);
            }
        }
#endregion

        #region SEXE
        public List<Sexe> GetAllSexes()
        {
            var sexes = db.Sexes
                .Where(b=> b.Game.GameId == IDGame)
                      .OrderBy(b => b.SexeId).ToList();
            return sexes;
        }
        public Sexe GetSexeById(int idSexe)
        {
            try
            {
                if (idSexe != 0)
                {
                    Sexe sexe = db.Sexes.FirstOrDefault(d => d.SexeId == idSexe);
                    return sexe;
                }
                else
                    throw new Exception("Veuillez sélectionner un sexe !");

            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le sexe\n : ", ex);
            }
           
        }
        public void AddSexe(int? idSexe, string sNom )
        {
            if (sNom.Trim() != string.Empty)
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                Sexe sexe = new Sexe();
                if (idSexe != 0 && idSexe != null)
                    sexe = db.Sexes.FirstOrDefault(d => d.SexeId == idSexe);
                
                sexe.Nom = sNom.Trim();
                if (idSexe == 0 || idSexe == null)
                {
                    sexe.Game = game;
                    db.Sexes.Add(sexe);
                }
                db.SaveChanges();
            }
        }
        public void DeleteSexe(int idSexe)
        {
            try
            {
                Sexe sexe = GetSexeById(idSexe);
                db.Sexes.Remove(sexe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de supprimer le sexe\n : ", ex);
            }
        }
        #endregion

        #region RACE

        public List<Race> GetAllRaces()
        {
            var Races = db.Races
                      .Where(c => c.Game.GameId == IDGame)
                      .OrderBy(c => c.RaceId).ToList();
            return Races;
        }
        public Race GetRaceById(int idRace)
        {
            try
            {
                if (idRace != 0)
                {
                    Race Race = db.Races.FirstOrDefault(d => d.RaceId == idRace);
                    return Race;
                }
                else
                    throw new Exception("Veuillez sélectionner une race !");

            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le race\n : ", ex);
            }

        }
        public void AddRace(int? idRace, string sNom, string sDescription)
        {
            if (sNom.Trim() != string.Empty)
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                Race Race = new Race();
                if (idRace != 0 && idRace != null)
                    Race = db.Races.FirstOrDefault(d => d.RaceId == idRace);

                Race.Nom = sNom.Trim();
                Race.Description = sDescription.Trim();
                if (idRace == 0 || idRace == null)
                {
                    Race.Game = game;
                    db.Races.Add(Race);
                }
                db.SaveChanges();
            }
        }
        public void DeleteRace(int idRace)
        {
            try
            {
                Race Race = GetRaceById(idRace);
                db.Races.Remove(Race);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de supprimer la race\n : ", ex);
            }
        }

        #endregion

        #region CLASSE

        public List<Classe> GetAllClasses()
        {
            var Classes = db.Classes
                .Where(c => c.Game.GameId == IDGame)
                .OrderBy(c => c.ClasseId).ToList();
            return Classes;
        }
        public Classe GetClasseById(int idClasse)
        {
            try
            {
                if (idClasse != 0)
                {
                    Classe Classe = db.Classes.FirstOrDefault(d => d.ClasseId == idClasse);
                    return Classe;
                }
                else
                    throw new Exception("Veuillez sélectionner une Classe !");

            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le Classe\n : ", ex);
            }

        }
        public void AddClasse(int? idClasse, string sNom, string sDescription)
        {
            if (sNom.Trim() != string.Empty)
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                Classe Classe = new Classe();
                if (idClasse != 0 && idClasse != null)
                    Classe = db.Classes.FirstOrDefault(d => d.ClasseId == idClasse);

                Classe.Nom = sNom.Trim();
                Classe.Description = sDescription.Trim();
                if (idClasse == 0 || idClasse == null)
                {
                    Classe.Game = game;
                    db.Classes.Add(Classe);
                }
                db.SaveChanges();
            }
        }
        public void DeleteClasse(int idClasse)
        {
            try
            {
                Classe Classe = GetClasseById(idClasse);
                db.Classes.Remove(Classe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de supprimer la Classe\n : ", ex);
            }
        }

        #endregion

        #region STATISTIQUES

        public List<Statistique> GetAllStatistiques()
        {
            var Statistiques = db.Statistiques
                .Where(c => c.Game.GameId == IDGame)
                .OrderBy(c => c.StatistiqueId).ToList();
            return Statistiques;
        }
        public Statistique GetStatistiqueById(int idStatistique)
        {
            try
            {
                if (idStatistique != 0)
                {
                    Statistique Statistique = db.Statistiques.FirstOrDefault(d => d.StatistiqueId == idStatistique);
                    return Statistique;
                }
                else
                    throw new Exception("Veuillez sélectionner une Statistique !");

            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de récupérer le Statistique\n : ", ex);
            }

        }
        public void AddStatistique(int? idStatistique, string sNom, int iMin, int iMax, bool bActive)
        {
            if (sNom.Trim() != string.Empty)
            {
                Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                Statistique Statistique = new Statistique();
                if (idStatistique != 0 && idStatistique != null)
                    Statistique = db.Statistiques.FirstOrDefault(d => d.StatistiqueId == idStatistique);

                Statistique.Nom = sNom.Trim();
                Statistique.Min = iMin;
                Statistique.Max = iMax;
                Statistique.Active = bActive;
                if (idStatistique == 0 || idStatistique == null)
                {
                    Statistique.Game = game;
                    db.Statistiques.Add(Statistique);
                }
                db.SaveChanges();
            }
        }
        public void DeleteStatistique(int idStatistique)
        {
            try
            {
                Statistique Statistique = GetStatistiqueById(idStatistique);
                db.Statistiques.Remove(Statistique);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de supprimer la Statistique\n : ", ex);
            }
        }

        #endregion

        #region IMAGES

        public List<Image> GetAllImages()
        {

            var Images = db.Images
                .Where(c => c.Game.GameId == IDGame)
                .OrderBy(c => c.Nom).ToList();
            return Images;

        }
        public Array GetTypeImages()
        {
            return Enum.GetValues(typeof( TypeImage)) ;
        }

        public void AddImage(int? idImage, string sNom, string sLienFrom, TypeImage myTypeImage)
        {
            try
            {
                if (sNom.Trim() != string.Empty && sLienFrom.Trim() != string.Empty)
                {
                    Game game = db.Games.FirstOrDefault(d => d.GameId == IDGame);
                    Image Image = new Image();
                    if (idImage != 0 && idImage != null)
                        Image = db.Images.FirstOrDefault(d => d.ImageId == idImage);

                    Image.Nom = sNom.Trim();
                    Image.Game = game;
                    Image.Type = myTypeImage;
                    AddImageFile(sLienFrom, ref Image);
                    if (idImage == 0 || idImage == null)
                    {
                        Image.Game = game;
                        db.Images.Add(Image);
                    }
                    db.SaveChanges();
                }
                else
                    throw new Exception("Les informations nécessaires n'ont pas été renseignées, impossible de continuer");
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible d'enregister l'image", ex);
            }
        }
        /// <summary>
        /// Supprimer l'image de la base de données
        /// </summary>
        /// <param name="idImage"></param>
        /// <param name="bDeleteFile">true si vous désirez supprimer le fichier</param>
        public void DeleteImage(int? idImage, bool bDeleteFile)
        {
            if (idImage != 0 && idImage != null)
            {
                Image image = new Image();
                image = db.Images.FirstOrDefault(d => d.ImageId == idImage);
                if(bDeleteFile)
                    File.Delete(image.Lien);
                db.Images.Remove(image);
            }
            else
                throw new Exception("Aucune image n'a été sélectionnée, impossible de la supprimer");
        }
        private void AddImageFile(string sOldPath, ref Image image)
        {
            string sPathGame = GetGameFolder();
            string sNewPath = Path.Combine(sPathGame, "Ressources","Images", image.Type.ToString(), image.Nom.Trim());
            File.Copy(sOldPath, sNewPath, true);
            image.Lien = sNewPath;
        }

        #endregion

        #region PLAYLIST

        public List<Playlist> GetPlaylists()
        {
            var playlists = db.Playlists
                .Where(p => p.Game.GameId == IDGame)
                .OrderBy(p => p.Nom)
                .ToList();
            return playlists;

        }
        public void AddPlaylist(int? idPlaylist, string sNom, string sDescription)
        {
            Playlist playlist = new Playlist();
            if (idPlaylist != 0 && idPlaylist != null)
                playlist = _sqlModels.GetPlaylist(idPlaylist);
            playlist.Game = myGame;
            playlist.Nom = sNom.Trim();
            playlist.Description = sDescription.Trim();
            _sqlModels.SavePlaylist(playlist);

        }


        #endregion

        #region MUSIQUE

        public List<Musique> GetAllMusiques()
        {
            return _sqlModels.GetAllMusiques(IDGame);
        }


        public void AddMusique(int? idMusique, string sNom, string sLienFrom)
        {
            try
            {
                if (sNom.Trim() != string.Empty && sLienFrom.Trim() != string.Empty)
                {
                   
                    Musique musique = new Musique();
                    if (idMusique != 0 && idMusique != null)
                        musique = _sqlModels.GetMusique(idMusique);

                    musique.Nom = sNom.Trim();
                    musique.Game = myGame;
                    AddMusiqueFile(sLienFrom, ref musique);
                    _sqlModels.SaveMusique(musique);
                }
                else
                    throw new Exception("Les informations nécessaires n'ont pas été renseignées, impossible de continuer");
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible d'enregister la musique", ex);
            }
        }
        /// <summary>
        /// Supprimer la musique de la base de données
        /// </summary>
        /// <param name="idMusique"></param>
        /// <param name="bDeleteFile">true si vous désirez supprimer le fichier</param>
        public void DeleteMusique(int? idMusique, bool bDeleteFile)
        {
            if (idMusique != 0 && idMusique != null)
            {
                Musique Musique = new Musique();
                Musique = db.Musiques.FirstOrDefault(d => d.MusiqueId == idMusique);
                if (bDeleteFile)
                    File.Delete(Musique.Lien);
                db.Musiques.Remove(Musique);
            }
            else
                throw new Exception("Aucune musique n'a été sélectionnée, impossible de la supprimer");
        }
        private void AddMusiqueFile(string sOldPath, ref Musique musique)
        {
            string sPathGame = GetGameFolder();
            string sNewPath = Path.Combine(sPathGame, "Ressources","Musiques", musique.Nom.Trim());
            File.Copy(sOldPath, sNewPath, true);
            musique.Lien = sNewPath;
        }

        #endregion

        #region OBJET / TYPE OBJET

        public List<TypeObjet> GetAllTypeObjet()
        {
            return _sqlModels.GetAllTypeObjets(IDGame);
        }
        public TypeObjet GetTypeObjet(int idTypeObjet)
        {
            return _sqlModels.GetTypeObjet(idTypeObjet);
        }
        public void SaveTypeObjet(int? idTypeObjet, string sNom, int? idImage )
        {
            if (sNom.Trim() != string.Empty)
            {
                TypeObjet typeObjet = new TypeObjet();
                if (idTypeObjet != 0 && idTypeObjet != null)
                    typeObjet = _sqlModels.GetTypeObjet(idTypeObjet);
                if (idImage != 0 && idImage != null)
                {
                    Image image = _sqlModels.GetImage(idImage);
                    typeObjet.Image = image;
                }
                typeObjet.Nom = sNom.Trim();
                typeObjet.Game = myGame;
                _sqlModels.SaveTypeObjet(typeObjet);
            }
            else
                throw new Exception("Veuillez indiquer le nom de type d'objet");

        }

        #endregion


    }
}
