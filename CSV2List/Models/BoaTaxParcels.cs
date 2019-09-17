using System;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace CSV2List.Models
{
    public partial class BoaTaxParcels
    {
        public int Objectid { get; set; }
        public string Pin { get; set; }
        public string Owner { get; set; }
        public string Owner2 { get; set; }
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string PropAddressNum { get; set; }
        public string PropAddressPreDir { get; set; }
        public string PropAddressStreetName { get; set; }
        public string PropAddressStreetType { get; set; }
        public string PropAddressPostDir { get; set; }
        public string PropAddressUnitType { get; set; }
        public string PropAddressUnitNum { get; set; }
        public string PropAddressCity { get; set; }
        public string PropAddressState { get; set; }
        public string PropAddressZip { get; set; }
        public string PropAddressFull { get; set; }
        public string Municipality { get; set; }
        public string NbhdCodeBoa { get; set; }
        public int? FairMarketValue { get; set; }
        public int? FmvLand { get; set; }
        public int? FmvBuilding { get; set; }
        public string PropertyUse { get; set; }
        public decimal? Acres { get; set; }
        public short? YearBuilt { get; set; }
        public short? EffectiveYb { get; set; }
        public int? SalePrice { get; set; }
        public short? SaleYy { get; set; }
        public short? SaleMm { get; set; }
        public short? SaleDd { get; set; }
        public string SaleQuality { get; set; }
        public string CommercialCat { get; set; }
        public int? TotalAssessment { get; set; }
        public string LegalDescription { get; set; }
        public string SaleBook { get; set; }
        public string SalePage { get; set; }
        public int? StephensDayByv { get; set; }
        public int? StephensDayByvCpi { get; set; }
        public string DistrictLighting { get; set; }
        public string DistrictTransit { get; set; }
        public string DistrictDryTrash { get; set; }
        public string DistrictEnterpriseZone { get; set; }
        public string DistrictTad { get; set; }
        public string LandUse1 { get; set; }
        public string LandUse2 { get; set; }
        public string LandUse3 { get; set; }
        public string LandUse4 { get; set; }
        public short? LandFrontage1 { get; set; }
        public short? LandFrontage2 { get; set; }
        public short? LandFrontage3 { get; set; }
        public short? LandFrontage4 { get; set; }
        public decimal? LandUnits1 { get; set; }
        public decimal? LandUnits2 { get; set; }
        public decimal? LandUnits3 { get; set; }
        public decimal? LandUnits4 { get; set; }
        public string LandType1 { get; set; }
        public string LandType2 { get; set; }
        public string LandType3 { get; set; }
        public string LandType4 { get; set; }
        public DateTime? DateUpdated { get; set; }
        public IGeometry Shape { get; set; }
    }
}
