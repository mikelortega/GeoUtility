//===================================================================================================
// Source Control URL : $HeadURL: file:///D:/svn/branch/5.2.0.1/GeoUtility/Localizer/Localizer.cs $
// Last changed by    : $LastChangedBy: sh $
// Revision           : $LastChangedRevision: 381 $
// Last changed date  : $LastChangedDate: 2014-09-23 09:26:17 +0200 (Tue, 23. Sep 2014) $
// Author             : $Author: sh $
// Copyright	      : Copyight (c) 2009-2015 Steffen Habermehl
// Contact            : geoutility@freenet.de
// License            : GNU GENERAL PUBLIC LICENSE Ver. 3, GPLv3
//                      This program is free software; you can redistribute it and/or modify it under the terms 
//                      of the GNU General Public License as published by the Free Software Foundation; 
//                      either version 3 of the License, or (at your option) any later version. 
//                      This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
//                      without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
//                      See the GNU General Public License for more details. You should have received a copy of the 
//                      GNU General Public License along with this program; if not, see <http://www.gnu.org/licenses/>. 
//
// File description   : Definition der internen Localizer Klasse 
//===================================================================================================


using System;
using System.Globalization;

namespace GeoUtility
{

    namespace Localizer
    {

        /// <summary><para>Die interne Klasse holt einen lokalisierten String, die durch eine ID spezifiziert wird, 
        /// und stellt sie der Bibliothek zur Verfügung.</para></summary>
        internal class Message 
        {
            private string _id = "";                                    // Speicherplatz für Message-ID
            private static string _culture = "";                        // Aktuelle Kultur

            /// <summary><para>Der Standard-Konstruktor.</para></summary>
            internal Message() 
            {
                if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "de") _culture = "DE_";
            }


            /// <summary><para>Konstruktor mit Parameter für die Message-ID.</para></summary>
            /// <param name="id">Eine globale Message-ID.</param>
            internal Message(string id) 
            {
                _id = id;
                if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "de") _culture = "DE_";
            }


            /// <summary><para>Die Eigenschaft legt die Message-ID fest, sofern sie nicht bei der Erzeugung der Klasse übergeben wurde.</para></summary>
            internal string ID { get { return _id; } set { _id = value; } }

            /// <summary><para>Die Eigenschaft Text gibt einen lokalisierten String zurück, welche durch die ID-Eigenschaft definiert ist.</para></summary>
            internal string Text
            {
                get
                {
                    string message = "";
                    if (this.ID != "") message = GeoUtility.Properties.Resources.ResourceManager.GetString(_culture + this.ID);
                    return message;
                }
            }
        }
    }
}
