﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RolistMakerAdmin.GUI.Models
{
    public class SQL_Models
    {

        #region ATTRIBUTS

        private static SQL_Models instance = null;
        private static readonly object myLock = new object();
        private RolistMakerContext db = new RolistMakerContext();


        #endregion

        #region ACCESSEURS

        public static SQL_Models GetInstance
        {
            get
            {
                lock (myLock)
                {
                    if (instance == null)
                        instance = new SQL_Models();
                    return instance;
                }
            }
        }
        #endregion

        #region GAME

        public Game GetGame(int? idGame)
        {
            Game game = new Game();
            game = db.Games.FirstOrDefault(d => d.GameId == idGame);
            return game;
        }



        #endregion

        #region SEXE

        public List<Sexe> GetAllSexes(int idGame)
        {
            var Sexes = db.Sexes
                .Where(c => c.Game.GameId == idGame)
                .OrderBy(c => c.Nom).ToList();
            return Sexes;
        }
        public Sexe GetSexe(int? idSexe)
        {
            try
            {
                Sexe Sexe = new Sexe();
                Sexe = db.Sexes.FirstOrDefault(m => m.SexeId == idSexe);
                return Sexe;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer ce sexe", ex);
            }
        }
        public void SaveSexe(Sexe Sexe, int idGame)
        {
            try
            {
                Game game = db.Games.FirstOrDefault(m => m.GameId == idGame);
                Sexe.Game = game;
                if (Sexe.SexeId == 0)
                    db.Sexes.Add(Sexe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder le sexe", ex);
            }
        }
        public void DeleteSexe(Sexe Sexe)
        {
            db.Sexes.Remove(Sexe);
            db.SaveChanges();
        }
        #endregion

        #region IMAGE

        public Image GetImage(int? idImage)
        {
            Image image = new Image();
            image = db.Images.FirstOrDefault(i => i.ImageId == idImage);
            return image;
        }

        #endregion

        #region PLAYLIST

        public Playlist GetPlaylist(int? idPlaylist)
        {
            Playlist playlist = new Playlist();
            playlist = db.Playlists.FirstOrDefault(d => d.PlaylistId == idPlaylist);
            return playlist;
        }

        public void SavePlaylist(Playlist playlist)
        {
            try
            {
                if(playlist.PlaylistId == 0)
                    db.Playlists.Add(playlist);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder la playlist", ex);
            }
        }
        public void DeletePlaylist(Playlist playlist)
        {
            db.Playlists.Remove(playlist);
            db.SaveChanges();
        }


        #endregion

        #region MUSIQUE
        public List<Musique> GetAllMusiques(int idGame)
        {
            var Musiques = db.Musiques
                .Where(c => c.Game.GameId == idGame)
                .OrderBy(c => c.Nom).ToList();
            return Musiques;
        }

        public Musique GetMusique(int? idMusique)
        {
            try
            {
                Musique musique = new Musique();
                musique = db.Musiques.FirstOrDefault(m => m.MusiqueId == idMusique);
                return musique;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer cette musique", ex);
            }
        }
        public void SaveMusique(Musique musique, int idGame)
        {
            try
            {
                Game game = GetGame(idGame);
                musique.Game = game;
                if (musique.MusiqueId == 0)
                    db.Musiques.Add(musique);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder la musique", ex);
            }
        }
        public void DeleteMusique(Musique musique, int idGame)
        {
            Game game = GetGame(idGame);
            musique.Game = game;
            db.Musiques.Remove(musique);
            db.SaveChanges();
        }

        #endregion

        #region OBJET - TYPE OBJET

        public List<TypeObjet> GetAllTypeObjets(int idGame)
        {
            var TypeObjets = db.TypeObjets
                .Where(c => c.Game.GameId == idGame)
                .OrderBy(c => c.Nom).ToList();
            return TypeObjets;
        }

        public TypeObjet GetTypeObjet(int? idTypeObjet)
        {
            try
            {
                TypeObjet TypeObjet = new TypeObjet();
                TypeObjet = db.TypeObjets.FirstOrDefault(m => m.TypeObjetId == idTypeObjet);
                return TypeObjet;
            }
            catch (Exception ex)
            {

                throw new Exception("Impossible de récupérer ce Type Objet", ex);
            }
        }
        public void SaveTypeObjet(TypeObjet TypeObjet)
        {
            try
            {
                if (TypeObjet.TypeObjetId == 0)
                    db.TypeObjets.Add(TypeObjet);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de sauvegarder le Type Objet", ex);
            }
        }
        public void DeleteTypeObjet(TypeObjet TypeObjet)
        {
            db.TypeObjets.Remove(TypeObjet);
            db.SaveChanges();
        }

        #endregion
    }
}
