using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List <IDataConnection> Connections { get; private set; }

        public static void InitilizeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - create the SQL connection
            }

            if (textFiles)
            {
                //TODO - create the SQL connection
            }
        }
    }
}
