using CSV2List.CustomLibrary;
using CSV2List.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace CSV2List
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("OK ... Firing it up");
            string path = @"C:\GISdata\BOA\WeeklyData\GIS_Extract.txt";                 //  Pass in the path to the text file as an arg
            var parcels = ProcessFile(path);                                            //  Process the export file for use as attributes

            Console.WriteLine("The text file is processed, starting the real work...");

            var context = new BOAContext();                                             //  Connect to the database

            Console.WriteLine("Dropping the old data from staging and Tax Parcels tables ....");
            context.Database.ExecuteSqlCommand("Truncate table dbo.BOA_Staging");       //  Truncating because its faster
            context.Database.ExecuteSqlCommand("Truncate table BOA.BOA_Tax_Parcels");

            Console.WriteLine("Loading the staging table with the shiny new data ...");
            var objBulk = new BulkUploadToSql<BOA_Staging>()                            // Bulk insert or we wait forever ...
            {
                InternalStore = parcels.ToList(),
                TableName = "BOA_Staging",
                CommitBatchSize = 50000,
                ConnectionString = "Data Source=YourDBServerHere;Initial catalog=YourCatalogHere;UID=YourUIDHere; PWD=YourPasswordHere;"
            };

            objBulk.Commit();
            Console.WriteLine("Loaded ... doing the Tax parcel table update");
            context.Database.ExecuteSqlCommand("dbo.UpdateTaxParcels");
            Console.WriteLine("Done ... doing the Current parcel table update");
            context.Database.ExecuteSqlCommand("Truncate table BOA.BOA_Parcels_Current");
            context.Database.ExecuteSqlCommand("dbo.UpdateCurrentParcels");             //  Stored procedure does the update because the join won't work outside
                                                                                        //  the db -- ESRI won't update correctly otherwise
            Console.WriteLine("This process is complete.  Have a nice day.");

            
        }


        // Library Routines
        private static decimal? GetValue(double? landUnits1)
        {
            decimal? result = null;
            if (landUnits1 != null) result = (decimal)landUnits1;
            return result;
        }

        

        // The first line contains column headings, which we don't need ...
        private static List<BOA_Staging> ProcessFile(string path)
        {
            return File.ReadAllLines(path).Skip(1).Where(line => line.Length > 1).Select(BOA_Staging.ParseFromCsv).ToList();
        }       

    }
   
}
