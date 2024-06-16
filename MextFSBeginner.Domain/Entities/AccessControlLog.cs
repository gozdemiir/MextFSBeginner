using MextFSBeginner.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFSBeginner.Domain.Entities
{
    public class AccessControlLog
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }                   //get: bu değeri döndürür (oku),  set: bu değeri (yazdırır) değiştirir, set ve get olmazsa sadece okunabilir,                                    // set olmazsa sadece yazılabilir ama okunamaz. get olmazsa sadece okunabilir ama yazılamaz.
        public string DeviceSerialNumber { get; set; }
        public AccessType AccessType { get; set; }
        public DateTime Date { get; set; }

    }
}
