using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice0911.Models
{
    public class Service
    {
        #region Attributs
        public static List<Service> collClassService = new List<Service>(); // Collection de Service
        private int _idService; // numéro du Service
        private string _nomService; // nom du Service
        private Collaborateur _leResponsable; // objet de Collaborateur
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
