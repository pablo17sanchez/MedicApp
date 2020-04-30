using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
   public interface INCFLogic
    {

        NFC GetById(int id);
        IEnumerable<NFC> GetList();
        IEnumerable<NFCList> NCFPagedList(int page, int rows);
        int Insert(NFC nfc);
        bool Update(NFC nfc);
        bool Delete(NFC nfc);
    }
}
