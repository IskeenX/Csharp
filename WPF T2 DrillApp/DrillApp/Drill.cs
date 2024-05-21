using System;
using System.Collections.Generic;
using System.Linq;

namespace DrillApp
{
    public enum Material { Metal, Plastic, Titanium }
    public enum Speed { Slow = 500, Medium = 1350, Fast = 1850 }

    public class Drill
    {
        public string Manufacturer { get; set; }
        public string PackageDimensions { get; set; }
        public string ItemWeight { get; set; }
        public string PartNumber { get; set; }
        public Material Material { get; set; }
        public Usage Usage { get; set; }
        public string Size { get; set; }
        public string PowerSource { get; set; }
        public List<string> IncludeComponents { get; set; }
        public Speed Speed { get; set; }
        public string Torque { get; set; }
        public string InstallationMethod { get; set; }
        public string Note { get; set; }
        public IList<Material> Materials => Enum.GetValues(typeof(Material)).Cast<Material>().ToList();
        public IList<Speed> Speeds => Enum.GetValues(typeof(Speed)).Cast<Speed>().ToList();
    }
}