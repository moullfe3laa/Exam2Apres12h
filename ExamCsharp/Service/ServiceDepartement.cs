using ExamCsharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCsharp.Service
{
    class ServiceDepartement : IDepartement
    {
        public DemandeUtilisateur _demandeUtilisateur;
       public List<Departement> departement = new List<Departement>();
        public List<Commune> Communes = new List<Commune>();

        public ServiceDepartement(DemandeUtilisateur demandeUtilisateur)
        {
            this._demandeUtilisateur = demandeUtilisateur;
        }
        public Departement DemandeDepartement()
        {
                Departement result = null;
                while (result == null)
                {

                    // string saisieUtilisateur = _demandeUtilisateur.saisieNom("quel  departement ?");
                    foreach (Departement d in this.departement)
                    {
                        //si on enleve le commentaire pour if on affiche un departement specifie
                        // if (d.nom == saisieUtilisateur)
                        //{
                        Console.WriteLine("Nom departement");
                        Console.WriteLine(d.nom);
                        Console.WriteLine("num departement");
                        Console.WriteLine(d.numD);
                        Console.WriteLine("commune du departement");
                        /*Ca marche pas
                          foreach (Commune c in Communes)
                          {
                              //ça marche pas
                              if (d.numD == c.numdepart)
                              {
                                  Console.WriteLine(c.Nom);

                              }


                          }*/
                        result = d;
                        //}
                    }
                }
                return result;
            
        }
        public Departement DemandeDepartement1()
        {
            Departement result = null;
            while (result == null)
            {

                // string saisieUtilisateur = _demandeUtilisateur.saisieNom("quel  departement ?");
                foreach (Departement d in this.departement)
                {
                    //si on enleve le commentaire pour if on affiche un departement specifie
                    // if (d.nom == saisieUtilisateur)
                    //{
                    Console.WriteLine("Nom departement");
                    Console.WriteLine(d.nom);
                    Console.WriteLine("num departement");
                    Console.WriteLine(d.numD);
                    Console.WriteLine("commune du departement");
                    /*Ca marche pas
                      foreach (Commune c in Communes)
                      {
                          //ça marche pas
                          if (d.numD == c.numdepart)
                          {
                              Console.WriteLine(c.Nom);

                          }


                      }*/
                    result = d;
                    //}
                }
            }
            return result;

        }

        public Departement CreeDepartement()
        {
            Departement d = new Departement();
            d.nom = _demandeUtilisateur.saisieNom("Nom de departement");
            d.numD = _demandeUtilisateur.saisieEntier("Num de departement");
            departement.Add(d);
            return d;
        }

        

        public int VerifDepart(int dep)
        {
            int i = 1;
            while (i == 1)
            {
                foreach (Departement d in departement)
                {
                    if (dep == d.numD)
                    {
                        dep = d.numD;
                        i = 0;
                    }
                    else if (dep != d.numD)
                    {
                        Console.WriteLine("depar introuvable un autre svvp");
                        dep = _demandeUtilisateur.saisieEntier("num dep");
                        d.numD = dep;
                        i =1;
                    }

                }
                         
            }return dep;
        }
      
    }
}
