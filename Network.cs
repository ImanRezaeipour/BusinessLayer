namespace IR.BusinessLayer
{
    class Network
    {
        public static string GetMacAddress()
        {
            System.Management.ManagementObjectSearcher searcher;
            string query = "SELECT * FROM Win32_NetworkAdapter";
            searcher = new System.Management.ManagementObjectSearcher(query);
            foreach (System.Management.ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["MacAddress"] != null)
                    return wmi_HD["MacAddress"].ToString();
            return null;
        }

        private string GetHDDSerialNumber()
        {
            string msn = "";
            System.Management.ManagementObjectSearcher searcher;
            string query1 = "SELECT * FROM Win32_DiskDrive";
            string query2 = "SELECT * FROM Win32_PhysicalMedia";

            searcher = new System.Management.ManagementObjectSearcher(query1);
            foreach (System.Management.ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["Model"] != null)
                    msn = wmi_HD["Model"].ToString();

            searcher = new System.Management.ManagementObjectSearcher(query2);
            foreach (System.Management.ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["SerialNumber"] != null)
                    msn += wmi_HD["SerialNumber"].ToString();
            return msn;
        }
    }
}
