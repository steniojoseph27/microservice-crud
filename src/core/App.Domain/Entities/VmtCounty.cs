using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class VmtCounty
    {
        public int CountyFips { get; set; }
        public string? CountyName { get; set; }
        public string? StateName { get; set; }
        public string? Date { get; set; }
        public long CountyVmt { get; set; }
        public long BaselineJanVmt { get; set; }
        public double PercentChangeFromJan { get; set; }
        public double Mean7CountyVmt { get; set; }
        public double Mean7PercentChangeFromJan { get; set; }
        public string? DateAtLow { get; set; }
        public double Mean7CountyVmtAtLow { get; set; }
        public double PercentChangeFromLow { get; set; }
    }
}
