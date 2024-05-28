using MextFSBeginner.ConsoleClient.Enums;

namespace MextFSBeginner.ConsoleClient.Entities
{
    public class AccessControlLog
    {
        public Guid Id { get; set; }
        // Shady Presents
        public int UserId { get; set; }
        public string DeviceSerialNumber { get; set; }
        public AccessType AccessType { get; set; }
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; }
        public DateTime ApprovedDate { get; set; }
    }
}