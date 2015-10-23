﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: - Bryce C Schroeder (bryce.schroeder@gmail.com)
 * 			   - Nathaniel R. Lewis (linux.robotdude@gmail.com)
 * 
 * Maintained by: - Thomas P.
 * 				  - NathanKell
 * 
* Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace
 * ------------------------------------------------------------- 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2014 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using System.IO;
using System.Security.Cryptography;

namespace Kopernicus
{
    // Informations about the current version of Kopernicus
    namespace Constants
    {
        public class Version
        {
            // Versioning information
            private static int[] versionNumber = new int[] { 0, 4 }; 

            // Get a string for the logging
            public static string version
            {
                get
                {
                    #if DEBUG
                    bool developmentBuild = true;
                    #else
                    bool developmentBuild = false;
                    #endif
                    return "Kopernicus " + GetVersionNumber(versionNumber) + ((developmentBuild) ? " [Development Build]" : "") + " - (BuildDate: " + BuiltTime().ToString("dd.MM.yyyy HH:mm:ss") + "; AssemblyHash: " + AssemblyHandle() + ")";
                }
            }

            // Returns the current version number
            private static string GetVersionNumber(int[] number)
            {
                string version = "";

                for (int i = 0; i < number.Length; i++)
                {
                    if (i != 0) 
                        version += ".";
                    version += number[i];
                }

                return version;
            }

            // Returns the SHA1 Hash of the assembly
            private static string AssemblyHandle()
            {
                string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
                return Convert.ToBase64String(SHA1Managed.Create().ComputeHash(File.ReadAllBytes(filePath)));
            }

            // Returns the time when the assembly was built
            private static DateTime BuiltTime()
            {
                string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
                const int c_PeHeaderOffset = 60;
                const int c_LinkerTimestampOffset = 8;
                byte[] b = new byte[2048];
                Stream s = null;

                try
                {
                    s = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    s.Read(b, 0, 2048);
                }
                finally
                {
                    if (s != null)
                    {
                        s.Close();
                    }
                }

                int i = BitConverter.ToInt32(b, c_PeHeaderOffset);
                int secondsSince1970 = BitConverter.ToInt32(b, i + c_LinkerTimestampOffset);
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                dt = dt.AddSeconds(secondsSince1970);
                dt = dt.ToLocalTime();
                return dt;
            }
        }
    }
}
