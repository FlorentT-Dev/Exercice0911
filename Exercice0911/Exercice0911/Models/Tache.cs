using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    class Tache
    {
#region Attributs
        public static List<Tache> CollClasseTache = new List<Tache>();
        private int idTache;
        private string intituleTache;
        private DateTime dateDebutPrevue;
        private DateTime dateDebutReelle;
        private DateTime dateFinPrevue;
        private DateTime dateFinReelle;
        private string etat;
        private List<Collaborateur> lesCollaborateur;
        #endregion

        #region Constructeur
        public Tache(int idTache, string intituleTache, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, List<Collaborateur> lesCollaborateur)
        {
            this.IdTache = idTache;
            this.IntituleTache = intituleTache;
            this.DateDebutPrevue = dateDebutPrevue;
            this.DateDebutReelle = dateDebutReelle;
            this.DateFinPrevue = dateFinPrevue;
            this.DateFinReelle = dateFinReelle;
            this.Etat = etat;
            this.LesCollaborateur = lesCollaborateur;
            CollClasseTache.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdTache { get => idTache; set => idTache = value; }
        public string IntituleTache { get => intituleTache; set => intituleTache = value; }
        public DateTime DateDebutPrevue { get => dateDebutPrevue; set => dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => dateDebutReelle; set => dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => dateFinPrevue; set => dateFinPrevue = value; }
        public DateTime DateFinReelle { get => dateFinReelle; set => dateFinReelle = value; }
        public string Etat { get => etat; set => etat = value; }
        internal List<Collaborateur> LesCollaborateur { get => lesCollaborateur; set => lesCollaborateur = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
