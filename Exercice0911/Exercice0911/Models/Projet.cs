﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    class Projet
    {
        #region Attributs
        private int idProjet;
        private string intituleProjet;
        private DateTime dateDebutPrevue;
        private DateTime dateDebutReelle;
        private DateTime dateFinPrevue;
        private DateTime dateFinReelle;
        private string etat;
        private Collaborateur leResponsable;
        private List<Tache> lesTachesRestantARealiser;
        private List<Lot> lesLots;
        #endregion

        #region Constructeurs

        public Projet (int uneId, string unIntutile, DateTime uneDateDebutPrevue, DateTime uneDateDebutReelle, DateTime dateFinPrevue, DateTime dateFiunReelle, string unEtat, Collaborateur unResponsable, List<Tache> uneListeTache, List<Lot> uneListeLot)
        {
            IdProjet= uneId;
            IntituleProjet = unIntutile;
            DateDebutPrevue = uneDateDebutPrevue;
            DateDebutReelle = uneDateDebutReelle;
            DateFinPrevue = dateFinPrevue;
            DateFinReelle = dateFiunReelle;
            Etat = unEtat;
            LeResponsable = unResponsable;
            LesTachesRestantARealiser = uneListeTache;
            LesLots = uneListeLot;


        }

        #endregion

        #region Getters Setters
        public int IdProjet { get => idProjet; set => idProjet = value; }
        public string IntituleProjet { get => intituleProjet; set => intituleProjet = value; }
        public DateTime DateDebutPrevue { get => dateDebutPrevue; set => dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => dateDebutReelle; set => dateDebutReelle = value; }
        public DateTime DateFinPrevue { get => dateFinPrevue; set => dateFinPrevue = value; }
        public DateTime DateFinReelle { get => dateFinReelle; set => dateFinReelle = value; }
        public string Etat { get => etat; set => etat = value; }
        public Collaborateur LeResponsable { get => leResponsable; set => leResponsable = value; }
        public List<Tache> LesTachesRestantARealiser { get => lesTachesRestantARealiser; set => lesTachesRestantARealiser = value; }
        public List<Lot> LesLots { get => lesLots; set => lesLots = value; }

        #endregion

        #region Methodes
        public float pourcentageAvancement() //Je retourne un pourcentage des tache deja fini du projet
        {
            int X = 0;
            int Y = 0;
            foreach (Tache uneTache in LesTachesRestantARealiser)
            {
                if (uneTache.Etat == "terminee")
                {
                    X++;
                }
                Y++;
            }
            return X / Y * 100;
        }
        #endregion

}
