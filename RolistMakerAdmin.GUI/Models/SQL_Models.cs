using System;
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
       
    }
}
