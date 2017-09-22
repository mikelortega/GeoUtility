//===================================================================================================
// Source Control URL : $HeadURL: file:///D:/svn/branch/5.2.0.1/GeoUtility/GeoSystem/Base/BaseSystem.cs $
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
// File description   : Definition der abstrakten BaseSystem Basisklasse 
//===================================================================================================


namespace GeoUtility.GeoSystem.Base
{

    /// <summary><para>Abstrakte Basisklasse von der alle Koordinatensystem-Klassen abgeleitet werden.</para></summary>
    /// <remarks><para>
    /// Diese Basisklasse stellt für alle abgeleiteten Klassen die Funktionen der internen Klasse
    /// <see cref="GeoUtility.Transformation"/> zur Verfügung. Die Klasse <see cref="GeoUtility.Transformation"/> führt 
    /// die zugrundeliegenden Transformationen aus, welche von den Koordinatensystem-Klassen in Form von
    /// impliziten und expliziten Typkonvertierungen, sowie den Funktionen <c>ConvertFrom</c> und <c>ConvertTo</c>
    /// zur Verfügung gestellt werden.
    /// </para></remarks>
    public abstract class BaseSystem
    {
        /// <summary><para>Instanz der internen Klasse <see cref="GeoUtility.Transformation"/>.</para></summary>
        internal static GeoUtility.Transformation Transform = new GeoUtility.Transformation();

        /// <summary><para>Der statische Konstruktor.</para></summary>
        static BaseSystem() { }

        /// <summary><para>Der Standard-Konstruktor.</para></summary>
        internal BaseSystem() { }
    }

}
