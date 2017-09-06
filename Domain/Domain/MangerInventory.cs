using Domain.Specifications;
using System.Collections.Generic;

namespace Domain
{
   public class MangerInventory
    {
       private string[] inventory;
       private List<string> equineList;
       private List<string> bovineList;
       private ISpecification bovineSpecification;
       private ISpecification equineSpecification;
      
       public MangerInventory(string[] inventory,ISpecification bovineSpecification, ISpecification equineSpecification)
       {
           this.equineList = new List<string>();
           this.bovineList = new List<string>();
           this.inventory = inventory;
           this.bovineSpecification = bovineSpecification;
           this.equineSpecification = equineSpecification;
           this.IdentifyEquineAndBovine();
       }


       private void IdentifyEquineAndBovine(){
           foreach (string animalName in this.inventory)
           {
               if (this.equineSpecification.SatisfiedBy(animalName))
               {
                   this.equineList.Add(animalName);
               }
               if (this.bovineSpecification.SatisfiedBy(animalName))
               {
                   this.bovineList.Add(animalName);
               }
           }
       }

       public IEnumerable<string> GetEquineList(){
           return this.equineList;
       }

       public IEnumerable<string> GetBovineList()
       {
           return this.bovineList;
       }
    }
}
