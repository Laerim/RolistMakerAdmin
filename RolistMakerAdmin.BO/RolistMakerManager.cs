using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolistMakerAdmin.BO
{
    public class RolistMakerManager
    {
        #region ATTRIBUTS

        private static RolistMakerManager rolistMakerManagerInstance = null;
    private static readonly object myLock = new object();
    private RolistMakerContext db = new RolistMakerContext();


    #endregion

    #region ACCESSEURS

    public static RolistMakerManager GetInstance
    {
        get
        {
            lock (myLock)
            {
                if (rolistMakerManagerInstance == null)
                    rolistMakerManagerInstance = new RolistMakerManager();
                return rolistMakerManagerInstance;
            }
        }
    }

    #endregion

    #region METHODES

    public DataTable GetAllGames()
    {
        var games = db.Games;
        DataTable dtDonnees = new DataTable();
        dtDonnees.Columns.Add("Titre", typeof(string));
        foreach (var game in games)
        {
            dtDonnees.Rows.Add(game.Titre);
        }
        return dtDonnees;
    }

    public void SaveNewGame(int? id, string sTitre, string sDescription)
    {
        try
        {
            if (sTitre.Trim() != string.Empty)
            {

                /* Game game = new Game();
                 if(id!= 0 && id != null)
                 {
                     game = db.Games.FirstOrDefault(d => d.GameId == id);
                 }
                 game.Titre = sTitre.Trim();
                 game.Description = sDescription.Trim();
                 if (id == 0 || id == null)
                 {
                     game.GameId = 1;
                     db.Games.Add(game);
                 }
                 db.SaveChanges();*/
                using (var context = new RolistMakerContext())
                {
                    context.Add(new Game { Titre = sTitre, Description = sDescription });
                    context.SaveChanges();
                }
            }
            else
                throw new Exception("Impossible de continuer. Indiquer un titre à votre jeu");
        }
        catch (Exception ex)
        {
            throw new Exception("Impossible d'enregistrer le jeu : ", ex);
        }
    }

    #endregion
}
}
