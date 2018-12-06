/**
 * Kopernicus Planetary System Modifier
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
 * which is copyright 2011-2017 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace Components
    {
        /// <summary>
        /// Modifications for the SunFlare component
        /// </summary>
        public class KopernicusSunFlare : SunFlare
        {
            Camera.CameraCallback cam;

            protected override void Awake()
            {
                // Create CameraCallback
                cam = callback =>
                {
                    Vector3d scaledSpace = target.transform.position - ScaledSpace.LocalToScaledSpace(sun.position);
                    sunDirection = scaledSpace.normalized;
                    if (sunDirection != Vector3d.zero)
                        transform.forward = sunDirection;
                };

                // Add CameraCallback
                Camera.onPreCull += cam;
            }

            protected override void OnDestroy()
            {
                // Remove CameraCallback
                Camera.onPreCull -= cam;

                // Run base OnDestroy()
                base.OnDestroy();
            }
        }
    }
}
