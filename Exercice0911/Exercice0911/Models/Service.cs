using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    class Service
    {
        #region Attributs
        public static List<Service> collClassService = new List<Service>();
        private int _idService;
        private string _nomService;
        private Collaborateur _leResponsable;
        #endregion

        #region Constructeur
        public Service(int idService, string nomService, Collaborateur unResponsable)
        {
            _idService = idService;
            _nomService = nomService;
            _leResponsable = unResponsable;
            collClassService.Add(this);

        }
        #endregion

        #region Getters-Setters
        public int IdService { get => _idService; set => _idService = value; }
        public string NomService { get => _nomService; set => _nomService = value; }
        public Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }
        #endregion

        #region Méthodes
        #endregion
    }
}
