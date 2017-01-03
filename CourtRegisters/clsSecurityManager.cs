using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace CourtRegisters
{
    public static class SecurityManager
    {
        public static bool ValidateDb(string sCourt)
        {
            bool isValid = false;
            string sFilePath = Environment.CurrentDirectory + @"\court.dat";
            string sHash = string.Empty;

            if (File.Exists(sFilePath))
            {
                using (StreamReader file = new StreamReader(sFilePath))
                {
                    string sFileHash = file.ReadLine().Trim();

                    using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
                    {
                        tblSecurity sec = db.tblSecurities.FirstOrDefault();
                        if (sec != null)
                        {
                            sHash = HashPassword(sec.Court + sCourt);
                            if (sec.HashValue == sHash && sec.HashValue == sFileHash)
                            {
                                isValid = true;
                            }
                        }

                    }
                }
            }

            return isValid;
        }

        public static string HashPassword(string plainMessage)
        {
            byte[] data = Encoding.UTF8.GetBytes(plainMessage);
            using (HashAlgorithm sha = new SHA256Managed())
            {
                byte[] encryptedBytes = sha.TransformFinalBlock(data, 0, data.Length);
                return Convert.ToBase64String(sha.Hash);
            }
        }

        public static bool GenFile(string sCodeCourt)
        {

            string sFileName = @"\court.dat";
            string filePath = Environment.CurrentDirectory + sFileName;
            string sCourt = ConfigurationManager.AppSettings["SaleLocation"].Trim();
            string sHash = SecurityManager.HashPassword(sCodeCourt + sCourt);

            try
            {
                using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
                {
                    tblSecurity dbSec = db.tblSecurities.FirstOrDefault();

                    if (dbSec == null)
                    {
                        db.AddTotblSecurities(new tblSecurity()
                        {
                            Court = sCodeCourt,
                            HashValue = sHash
                        });

                    }
                    else
                    {
                        dbSec.Court = sCodeCourt;
                        dbSec.HashValue = sHash;
                    }
                    db.SaveChanges();


                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    using (StreamWriter file = new StreamWriter(File.Create(filePath)))
                    {
                        file.WriteLine(sHash);
                    }
                }
                return true;
            }
            catch (Exception err)
            {
                ErrorLogger.LogError(err);
                return false;
            }
        }
    }
}
