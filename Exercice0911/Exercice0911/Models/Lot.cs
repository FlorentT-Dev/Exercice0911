using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    public class Lot
    {
        #region Attributs
        public static List<Lot> CollClasseLot = new List<Lot>();
        private int idLot;
        private DateTime dateDebutPrevue;
        private DateTime dateDebutReelle;
        private DateTime dateFinPrevue;
        private DateTime dateFinReelle;
        private string etat;
        private Projet leProjet;
        private List<Tache> lesTaches;
        #endregion

        #region Constructeur
        public Lot(int idLot, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat, Projet leProjet, List<Tache> lesTaches)
        {
            this.IdLot = idLot;
            this.DateDebutPrevue = dateDebutPrevue;
            this.DateDebutReelle = dateDebutReelle;
            this.DateFinPrevue = dateFinPrevue;
            this.DateFinReelle = dateFinReelle;
            this.Etat = etat;
            this.LeProjet = leProjet;
            this.LesTaches = lesTaches;
            CollClasseLot.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdLot { get => idLot; set => idLot = value; }
        public DateTime DateDebutPrevue { get => dateDebutPrevue; set => dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => dateDebutReelle; set => dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => dateFinPrevue; set => dateFinPrevue = value; }
        public DateTime DateFinReelle { get => dateFinReelle; set => dateFinReelle = value; }
        public string Etat { get => etat; set => etat = value; }
        public Projet LeProjet { get => leProjet; set => leProjet = value; }
        public List<Tache> LesTaches { get => lesTaches; set => lesTaches = value; }
        #endregion

        #region Méthodes
         /// <summary> Galaad
         /// Permet d'ajouter des tâches au lot en prélevant à la liste triée des taches à réaliser pour le projet
         ///</summary>
         ///<returns>
         /// Ne retourne rien
         ///</returns>
         ///<para>
         ///Le nombre de Tache Ajouter
         ///</para>
        public void AjouterTaches(int nbTacheAjout)
        {
            int compteur = 0;
            foreach (Tache uneTache in Tache.CollClasseTache)
            {
                compteur++;
                if(compteur <= nbTacheAjout) if (uneTache.Etat == "AL") LesTaches.Add(uneTache);
            }
        }
         /// <summary> Galaad
         /// Permet de connaitre le nombre de taches terminés
         ///</summary>
         ///<returns>
         /// Retourne le nombre de taches terminées de type "int"
         ///</returns>
         ///<para>
         ///Aucun param en entrée
         ///</para>
        public int DonneNbTachesTerminees()
        {
            int compteurTermine = 0;
            foreach (Tache uneTache in LesTaches) if (uneTache.Etat == "T") compteurTermine++;
            return compteurTermine;
        }
        /// <summary> Ewen
        ///Permet d'obtenir un pourcentage des tâches terminées dans le lot
        ///</summary>
        ///<returns>
        ///Retourne un pourcentage des tâches en "float"
        ///</returns>
        ///<para>
        ///Aucun parametre n'est utilisé
        ///</para>
        public int PourcentageAvancement()
        {
            return (DonneNbTachesTerminees() / LesTaches.Count()) * 100 ;
        }
        /// <summary> Ewen
        ///Permet de connaitre les differentes tâches à effectuer restantes
        ///</summary>
        ///<returns>
        ///Retourne une liste des tâches qui ont l'état "AA"
        ///</returns>
        ///<para>
        ///Aucun paramètre n'est utilisé
        ///</para>
        public List<Tache> DonneTacheAAffecter()
        {
            List<Tache> taches = new List<Tache>();
            foreach (Tache uneTache in LesTaches) if (uneTache.Etat == "AA") taches.Add(uneTache);
            return taches;
        }
        #endregion
    }
}
