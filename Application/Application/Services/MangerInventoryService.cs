using Domain;
using Domain.Specifications;
using Messages.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Application.Services
{
    public class MangerInventoryService : IMangerInventoryService

    {
        ISpecification equineSpecification;
        ISpecification bovineSpecification;
        public MangerInventoryService(){
            this.equineSpecification = new NonSpecification();
            this.bovineSpecification = new BovineSpecification();
        }

        public EquineBovineDTO GetMangerInventorDataByFile(Stream streamFile)
        {
            MangerInventory mangerInventory = new MangerInventory(GetTextArray(streamFile), this.bovineSpecification, this.equineSpecification);
            return new EquineBovineDTO
            {
                equine = mangerInventory.GetEquineList(),
                bovine = mangerInventory.GetBovineList()
            };
        }

       
        private string[] GetTextArray(Stream streamFile)
        {
            byte[] bytes = new byte[streamFile.Length];
            streamFile.Position = 0;
            streamFile.Read(bytes, 0, (int)streamFile.Length);
            string data = Encoding.ASCII.GetString(bytes);
            string[] lines = data.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            return lines;
        }
    }
}
