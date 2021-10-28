using System;
using System.Collections.Generic;
using BOL;
using DAL;
namespace BLL
{
    //Singleton Design pattern
    public class PlansManager
    {
        public static PlansManager self = null;
        private PlansManager()
        {
            Console.WriteLine("Plansmanager constructor has been called....");
            self=this;
        }
        public static PlansManager GetManager()
        {
            PlansManager theManager;
            if(self == null)
            {
                theManager=new PlansManager();
                self=theManager;
            }
            else
            {
                theManager=self;
            }
            return theManager;

        }
        public List<Plan> GetAll()
        {
            return  PlanDAL.GetAll();
        }
        public bool Register(Plan plan)
        {
            return PlanDAL.Insert(plan);
        }
        public bool UnRegister(int id)
        {
            return  PlanDAL.Delete(id);  
        }
        
        
         public bool Updated(Plan PlanToBeUpdated)
         {
             return PlanDAL.Update(PlanToBeUpdated);
         }
	    public Plan GetById(int id)
        {
            return PlanDAL.Get(id);  
        }
       
       
    }
}
