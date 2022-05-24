using System;
using System.ComponentModel.DataAnnotations;

namespace SmartScales.Model
{
    public class AppInitSettings
    {
        [Key]
        public int AppInitSettingId { get; set; }
        public string SettingName { get; set; }
        public DateTime SettingAvailableFrom { get; set; }
        public DateTime SetAvailableTo { get; set; }
        public string APIActivation { get; set; }
        public string ComputerName { get; set; }
        public string OSVersion { get; set; }
        public string CurrentSerialNO { get; set; }
    }
}
