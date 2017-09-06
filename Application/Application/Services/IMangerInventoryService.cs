using Messages.DTO;
using System.IO;
namespace Application.Services
{
   public interface IMangerInventoryService
    {
       EquineBovineDTO GetMangerInventorDataByFile(Stream streamFile);
    }
}
