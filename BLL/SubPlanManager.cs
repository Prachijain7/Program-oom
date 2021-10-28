using System;
using System.Collections.Generic;
using BOL;
using DAL;
namespace BLL
{
    //Singleton Design pattern
    public class SubPlanManager
    {
        public static SubPlanManager self = null;
        private SubPlanManager()
        {
            Console.WriteLine("Sub Plan manager constructor has been called....");
            self=this;
        }
        public static SubPlanManager GetManager()
        {
            SubPlanManager theManager;
            if(self == null)
            {
                theManager=new SubPlanManager();
                self=theManager;
            }
            else
            {
                theManager=self;
            }
            return theManager;

        }
        public List<SubPlan> GetAll()
        {
            return  SubPlanDAL.GetAll();   
        }

        public SubPlan Get(int id)
        {
            return SubPlanDAL.Get(id);  
        }
        public bool Update(SubPlan SubPlanToBeUpdated)
        {
             return  SubPlanDAL.Update(SubPlanToBeUpdated);  
        }
	    public bool Register(SubPlan subplan)
        {
            return SubPlanDAL.Insert(subplan);
        }
        public bool UnRegister(int id)
        {
            return  SubPlanDAL.Delete(id);  
        }
    }
}
