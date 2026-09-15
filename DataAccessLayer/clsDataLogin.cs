using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataLogin
    {
       
       

        public static bool ReadLoginFile(ref string username, ref string password)
        {

            try
            {


                if (!File.Exists(clsSettings.FileName))
                    return false;

                string Lines = File.ReadAllText(clsSettings.FileName);
                string[] lines = Lines.Split(clsSettings.Seprator);

                if (lines.Length == 2)
                {
                    username = lines[0];
                    password = lines[1];
                    return true;
                }

            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
                return false;
                
            }
            return false;
       
         }


        public static bool WriteLoginData(string username, string password)
        {
            try
            {

               
                File.WriteAllText(clsSettings.FileName,username.Trim() + clsSettings.Seprator+ password.Trim());
                return true;
            }
                catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            
            return false;
            }
        }


        public static bool ReadRigestry(ref string username, ref string password)
        {
            try
            {
                // OpenSubKey opens the key. Pass 'false' because we only need read access
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(clsSettings.keyPath, writable: false))
                {
                    if (key != null)
                    {
                        string value = key.GetValue(clsSettings.ValueName1, null) as string;
                        string value2 = key.GetValue(clsSettings.ValueName2, null) as string;

                        if (value != null && value2 != null )
                        {
                            username = value;
                            password = value2;
                            return true;
                        }
                        else
                        {
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Registry key path not found.");
                    }
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            return false;
        }

        public static bool WriteRigestry(string username, string password)
        {
            try
            {
                // CreateSubKey opens the key if it exists or creates it if it doesn't
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(clsSettings.keyPath))
                {
                    if (key != null)
                    {
                        key.SetValue(clsSettings.ValueName1, username, RegistryValueKind.String);
                        key.SetValue(clsSettings.ValueName2, password, RegistryValueKind.String);

                    }
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

            return true;
        }


        public static void ClearRigestry()
        {
            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(clsSettings.subKey, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(clsSettings.ValueName1);
                            key.DeleteValue(clsSettings.ValueName2);


                            return;
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }

        }



        public static void ClearFile()
        {

            try
            {
                File.WriteAllText(clsSettings.FileName, "");
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(clsSettings.SourceName, e.ToString(), EventLogEntryType.Error);
            }


        }





    }
}
