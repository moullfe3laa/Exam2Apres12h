using System;
using System.Collections.Generic;
using System.Text;


namespace ExamCsharp.Model
{
     interface IDepartement
    {
        
         Departement CreeDepartement();

         Departement DemandeDepartement();
        int VerifDepart(int dep);
      
    }
}
