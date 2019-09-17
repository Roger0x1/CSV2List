using CSV2List.CustomLibrary;
using System;
using System.ComponentModel.DataAnnotations;

namespace CSV2List.Models
{
    public class BOA_Staging
    {
        [Key]
        [MaxLength(15)]
        [Required]
        public string P_Id { get; set; }
        public string Owner { get; set; }
        public string Owner2 { get; set; }
        public string Mailing_Address { get; set; }
        public string Mailing_City { get; set; }
        public string Mailing_State { get; set; }
        public string Mailing_Zip { get; set; }
        public string PropAddress_Num { get; set; }
        public string PropAddress_PreDir { get; set; }
        public string PropAddress_StreetName { get; set; }
        public string PropAddress_StreetType { get; set; }
        public string PropAddress_PostDir { get; set; }
        public string PropAddress_UnitType { get; set; }
        public string PropAddress_UnitNum { get; set; }
        public string PropAddress_City { get; set; }
        public string PropAddress_State { get; set; }
        public string PropAddress_Zip { get; set; }
        public string PropAddress_Full { get; set; }
        public string Municipality { get; set; }
        public string Nbhd_Code_Boa { get; set; }
        public int? FairMarketValue { get; set; }
        public int? Fmv_Land { get; set; }
        public int? Fmv_Building { get; set; }
        public string Property_Use { get; set; }
        public decimal? Acres { get; set; }
        public short? YearBuilt { get; set; }
        public short? Effective_Yb { get; set; }
        public int? Sale_Price { get; set; }
        public short? Sale_Yy { get; set; }
        public short? Sale_Mm { get; set; }
        public short? Sale_Dd { get; set; }
        public string Sale_Quality { get; set; }
        public string Commercial_Cat { get; set; }
        public int? Total_Assessment { get; set; }
        public string Legal_Description { get; set; }
        public string Sale_Book { get; set; }
        public string Sale_Page { get; set; }
        public int? StephensDay_Byv { get; set; }
        public int? StephensDay_Byv_Cpi { get; set; }
        public string District_Lighting { get; set; }
        public string District_Transit { get; set; }
        public string District_DryTrash { get; set; }
        public string District_EnterpriseZone { get; set; }
        public string District_Tad { get; set; }
        public string Land_Use_1 { get; set; }
        public string Land_Use_2 { get; set; }
        public string Land_Use_3 { get; set; }
        public string Land_Use_4 { get; set; }
        public short? Land_Frontage_1 { get; set; }
        public short? Land_Frontage_2 { get; set; }
        public short? Land_Frontage_3 { get; set; }
        public short? Land_Frontage_4 { get; set; }
        public decimal? Land_Units_1 { get; set; }
        public decimal? Land_Units_2 { get; set; }
        public decimal? Land_Units_3 { get; set; }
        public decimal? Land_Units_4 { get; set; }
        public string Land_Type_1 { get; set; }
        public string Land_Type_2 { get; set; }
        public string Land_Type_3 { get; set; }
        public string Land_Type_4 { get; set; }
        public DateTime? Date_Updated { get; set; }

        internal static BOA_Staging ParseFromCsv(string line)
        {
            // temp variables for the TryParse statements
            int val;
            decimal value;
            Int16 v;
            DateTime date;

            //  -- Begin parsing routine

            var parcel = new BOA_Staging();
            var col = line.Split('^');

            parcel.P_Id = col[0];
            parcel.Owner = col[1];
            parcel.Owner2 = col[2];
            parcel.Mailing_Address = col[3].Truncate(50);
            parcel.Mailing_City = col[4];
            parcel.Mailing_State = col[5];
            parcel.Mailing_Zip = col[6];
            parcel.PropAddress_Num = col[7];
            parcel.PropAddress_PreDir = col[8];
            parcel.PropAddress_StreetName = col[9];
            parcel.PropAddress_StreetType = col[10];
            parcel.PropAddress_PostDir = col[11];
            parcel.PropAddress_UnitType = col[12];
            parcel.PropAddress_UnitNum = col[13];
            parcel.PropAddress_Zip = col[14];
            parcel.PropAddress_City = col[15];
            parcel.PropAddress_State = col[16];
            parcel.Municipality = col[17];
            parcel.Nbhd_Code_Boa = col[18];
            parcel.FairMarketValue = int.TryParse(col[19], out val) ? int.Parse(col[19]) : (int?)null;
            parcel.Fmv_Land = int.TryParse(col[20], out val) ? int.Parse(col[20]) : (int?)null;
            parcel.Fmv_Building = int.TryParse(col[21], out val) ? int.Parse(col[21]) : (int?)null;
            parcel.Property_Use = col[22];
            parcel.Acres = decimal.TryParse(col[23], out value) ? decimal.Parse(col[23]) : (decimal?)null;
            parcel.YearBuilt = Int16.TryParse(col[24], out v) ? Int16.Parse(col[24]) : (Int16?)null;
            parcel.Sale_Price = Int16.TryParse(col[25], out v) ? Int16.Parse(col[25]) : (Int16?)null;
            parcel.Sale_Yy = Int16.TryParse(col[26], out v) ? Int16.Parse(col[26]) : (Int16?)null;
            parcel.Sale_Mm = Int16.TryParse(col[27], out v) ? Int16.Parse(col[27]) : (Int16?)null;
            parcel.Sale_Dd = Int16.TryParse(col[28], out v) ? Int16.Parse(col[28]) : (Int16?)null;
            parcel.Sale_Quality = col[29];
            parcel.Total_Assessment = int.TryParse(col[30], out val) ? int.Parse(col[30]) : (int?)null;
            parcel.Legal_Description = col[31].Truncate(50);
            parcel.Sale_Book = col[32];
            parcel.Sale_Page = col[33];
            parcel.StephensDay_Byv = int.TryParse(col[34], out val) ? int.Parse(col[34]) : (int?)null;
            parcel.StephensDay_Byv_Cpi = int.TryParse(col[35], out val) ? int.Parse(col[35]) : (int?)null;
            parcel.District_Lighting = col[36];
            parcel.District_Transit = col[37];
            parcel.District_DryTrash = col[38];
            parcel.District_Tad = col[39];
            parcel.Land_Use_1 = col[40];
            parcel.Land_Frontage_1 = Int16.TryParse(col[41], out v) ? Int16.Parse(col[41]) : (Int16?)null;
            parcel.Land_Units_1 = decimal.TryParse(col[42], out value) ? decimal.Parse(col[42]) : (decimal?)null;
            parcel.Land_Type_1 = col[43];
            parcel.Land_Use_2 = col[44];
            parcel.Land_Frontage_2 = Int16.TryParse(col[45], out v) ? Int16.Parse(col[45]) : (Int16?)null;
            parcel.Land_Units_2 = decimal.TryParse(col[46], out value) ? decimal.Parse(col[46]) : (decimal?)null;
            parcel.Land_Type_2 = col[47];
            parcel.Land_Use_3 = col[48];
            parcel.Land_Frontage_3 = Int16.TryParse(col[49], out v) ? Int16.Parse(col[49]) : (Int16?)null;
            parcel.Land_Units_3 = decimal.TryParse(col[50], out value) ? decimal.Parse(col[50]) : (decimal?)null;
            parcel.Land_Type_3 = col[51];
            parcel.Land_Use_4 = col[52];
            parcel.Land_Frontage_4 = Int16.TryParse(col[53], out v) ? Int16.Parse(col[53]) : (Int16?)null;
            parcel.Land_Units_4 = decimal.TryParse(col[54], out value) ? decimal.Parse(col[54]) : (decimal?)null;
            parcel.Land_Type_4 = col[55];
            parcel.Commercial_Cat = col[56];
            parcel.District_EnterpriseZone = col[57];
            parcel.Effective_Yb = Int16.TryParse(col[58], out v) ? Int16.Parse(col[58]) : (Int16?)null;
            parcel.Date_Updated = DateTime.TryParse(col[59], out date) ? DateTime.Parse(col[59]) : (DateTime?)null;

            parcel.PropAddress_Full = GetFullAddress(col[7], col[8], col[9], col[10], col[11], col[13]);
            return parcel;
        }

        private static string GetFullAddress(string propaddressNum, string propaddressPredir, string propaddressStreetname, string propaddressStreettype, string propaddressPostdir, string propaddressUnitnum)
        {
            string address = String.Empty;
            if (propaddressNum != String.Empty) address = propaddressNum + " ";
            if (propaddressPredir != String.Empty) address = address + propaddressPredir + " ";
            if (propaddressStreetname != String.Empty) address = address + propaddressStreetname;
            if (propaddressStreettype != String.Empty) address = address + " " + propaddressStreettype;
            if (propaddressPostdir != String.Empty) address = address + " " + propaddressPostdir;
            if (propaddressUnitnum != String.Empty) address = address + " #" + propaddressUnitnum;
            return address;
        }
    }
}
