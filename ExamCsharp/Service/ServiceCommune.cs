using ExamCsharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Service
{
    class ServiceCommune:Icommune
    {
      
        private List<Commune> Communes = new List<Commune>();
        private  List<Departement> departement = new List<Departement>();
        private DemandeUtilisateur _demandeUtilisateur;
        private ServiceDepartement _serviceDepartement;
        private Departement d = new Departement();

        public ServiceCommune(DemandeUtilisateur demandeUtilisateur, ServiceDepartement serviceDepartement)
        {
            this._demandeUtilisateur = demandeUtilisateur;
            this._serviceDepartement = serviceDepartement;
        }
        public Commune CreeCommune()
        {
            Commune result = new Commune()
            {
                Nom = _demandeUtilisateur.saisieNom("Nom de la commune :"),
                CodePost = _demandeUtilisateur.saisieEntier(" Code postal :"),
                NbHab = _demandeUtilisateur.saisieEntier("nombre d'habitants :"),
                numdepart = _demandeUtilisateur.saisieEntier("Num de departement")
            };
            int i = _serviceDepartement.VerifDepart(result.numdepart);
            result.numdepart = i;
            Communes.Add(result);
          //  departement.Add.Communes(result);
           
            
            return result;
        }

        public void AfficheCommune()
        {
            int tot;
            foreach (Commune c in Communes)
            {
                Console.WriteLine("Nom commune");
                Console.WriteLine(c.Nom);
                Console.WriteLine("code postale");
                Console.WriteLine(c.CodePost);
                Console.WriteLine("nbr habitant");
                Console.WriteLine(c.NbHab);
                Console.WriteLine("Num Dept");
                Console.WriteLine(c.numdepart);
                depcom(c.numdepart);
                Console.WriteLine("Num tot Habitant");
                tot = Nbrtotal();
                Console.WriteLine(tot);
            }

        }
        public void depcom(int s)
        {
            foreach (Departement d in departement)
            {
                if (s== d.numD)
                {
                    Console.WriteLine("Nom Depart");
                    Console.WriteLine(d.nom);
                }
            }
            Console.WriteLine("**************");
        }

      
        public int Nbrtotal()
        {
            int tot = 0;
            foreach(Departement d in departement)
            { 
            for (int i = 0; i < Communes.Count; i++)
            {
                    if(d.numD== Communes[i].numdepart)
                tot = tot + Communes[i].NbHab;
            }
            }
            return tot;
        }
    }
}

