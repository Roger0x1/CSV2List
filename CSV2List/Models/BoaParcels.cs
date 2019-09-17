using System;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace CSV2List.Models
{
    public partial class BoaParcels
    {
        public int Objectid { get; set; }
        public string Pin { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastEditedUser { get; set; }
        public DateTime? LastEditedDate { get; set; }
        public string PinLegacy { get; set; }
        public IGeometry Shape { get; set; }
    }
}
