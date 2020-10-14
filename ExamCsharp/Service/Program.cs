using Microsoft.Win32.SafeHandles;
using System;
using ExamCsharp;
using System.Collections.Generic;
using ExamCsharp.Model;

namespace ExamCsharp.Service
{

    class Program
    {
        private static DemandeUtilisateur _demandeUtilisateur = new DemandeUtilisateur();
        static void Main(string[] args)
        {

            DemandeUtilisateur _demandeUtilisateur = new DemandeUtilisateur();
            ServiceDepartement _serviceDepartement = new ServiceDepartement( _demandeUtilisateur);
            ServiceCommune _serviceCommune = new ServiceCommune(_demandeUtilisateur, _serviceDepartement);
            ServiceRegion _serviceRegion = new ServiceRegion(_demandeUtilisateur);
            List<Departement> departements = new List<Departement>();
            List<Commune> Communes = new List<Commune>();
            while (true)
            {
                int choix = MenuUtilisateur(_demandeUtilisateur);

                if (choix == 1)
                {
                    _serviceDepartement.CreeDepartement();
                }
               else if (choix == 2)
                {
                    _serviceDepartement.DemandeDepartement();
                }
                else if (choix == 3)
                {
                    _serviceCommune.CreeCommune();
                }
                 else if (choix == 4)
                {
                    _serviceCommune.AfficheCommune();
                }
                else if (choix == 5)
                {
                    _serviceRegion.Creeregion();
             }
                else if (choix == 6)
                {
                    _serviceRegion.afficherregion();
                }               
            }
        }

    
         static  int MenuUtilisateur(DemandeUtilisateur _demandeUtilisateur)
        {
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Créer un Departement");
            Console.WriteLine("2. Afficher la liste des departement");
            Console.WriteLine("3. Créer une commune");
            Console.WriteLine("4. Afficher les communes");
            Console.WriteLine("5. Créer un departement");
            Console.WriteLine("6. Afficher un departement");
            Console.WriteLine("Q. Quitter");
            int choixUtilisateur = _demandeUtilisateur.saisieEntier("");
            return choixUtilisateur;
        }

    }
    }
