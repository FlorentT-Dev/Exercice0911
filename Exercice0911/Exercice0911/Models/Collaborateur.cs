﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    class Collaborateur
    {
        #region Attributs
        public static List<Collaborateur> collClassCollaborateur = new List<Collaborateur>();
        private int _idCollaborateur;
        private string _nomCollaborateur;
        private Service _leService;
        #endregion

        #region Constructeur
        public Collaborateur(int idCollaborateur, string nomCollaborateur, Service leService)
        {
            _idCollaborateur = idCollaborateur;
            _nomCollaborateur = nomCollaborateur;
            _leService = leService;
            collClassCollaborateur.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdCollaborateur { get => _idCollaborateur; set => _idCollaborateur = value; }
        public string NomCollaborateur { get => _nomCollaborateur; set => _nomCollaborateur = value; }
        public Service LeService { get => _leService; set => _leService = value; }
        #endregion

        #region Méthodes
        #endregion

    }
}
