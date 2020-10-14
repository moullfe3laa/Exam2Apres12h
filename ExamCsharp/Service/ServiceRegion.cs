using ExamCsharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Service
{
    class ServiceRegion
    {
        public DemandeUtilisateur _demandeUtilisateur;
        public List<region> lregion = new List<region>();
        public ServiceRegion(DemandeUtilisateur demandeUtilisateur)
        {
            this._demandeUtilisateur = demandeUtilisateur;
        }
        public region Creeregion()
        {
            region g = new region();
            g.nom = _demandeUtilisateur.saisieNom("Nom de region");
          
            lregion.Add(g);
            return g;
        }
        public region afficherregion()
        {
            region rg = null;
            while (rg == null)
            {            
                foreach (region r in this.lregion)
                {              
                    Console.WriteLine("Nom de region");
                    Console.WriteLine(r.nom);
                    rg = r;
                }
            }
            return rg;

        }
    }
}
