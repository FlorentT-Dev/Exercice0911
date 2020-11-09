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
        public static List<Projet> CollClasseProjet = new List<Projet>();
        private int idProjet;
        private string intituleProjet;
        private DateTime dateDebutPrevue;
        private DateTime dateDebutReelle;
        private DateTime dateFinPrevue;
        private DateTime dateFinReelle;
        private string etat;
        private Collaborateur leResponsable;
        #endregion

        #region Constructeur
        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Collaborateur leResponsable)
        {
            this.IdProjet = idProjet;
            this.IntituleProjet = intituleProjet;
            this.DateDebutPrevue = dateDebutPrevue;
            this.DateDebutReelle = dateDebutReelle;
            this.DateFinPrevue = dateFinPrevue;
            this.DateFinReelle = dateFinReelle;
            this.Etat = etat;
            this.LeResponsable = leResponsable;
            CollClasseProjet.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdProjet { get => idProjet; set => idProjet = value; }
        public string IntituleProjet { get => intituleProjet; set => intituleProjet = value; }
        public DateTime DateDebutPrevue { get => dateDebutPrevue; set => dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => dateDebutReelle; set => dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => dateFinPrevue; set => dateFinPrevue = value; }
        public DateTime DateFinReelle { get => dateFinReelle; set => dateFinReelle = value; }
        public string Etat { get => etat; set => etat = value; }
        internal Collaborateur LeResponsable { get => leResponsable; set => leResponsable = value; }
        #endregion

        #region Méthodes
        public int PourcentageAvacement()
        {
            int compteurTermine = 0;
            foreach (Projet unProjet in CollClasseProjet) if (unProjet.etat == "T") compteurTermine++;
            return compteurTermine / CollClasseProjet.Count();
        }
        #endregion
    }
}
