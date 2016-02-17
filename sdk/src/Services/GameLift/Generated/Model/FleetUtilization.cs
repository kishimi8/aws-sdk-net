/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Current status of fleet utilization, including the number of game and player sessions
    /// being hosted.
    /// </summary>
    public partial class FleetUtilization
    {
        private int? _activeGameSessionCount;
        private int? _currentPlayerSessionCount;
        private string _fleetId;
        private int? _maximumPlayerSessionCount;

        /// <summary>
        /// Gets and sets the property ActiveGameSessionCount. 
        /// <para>
        /// Number of active game sessions currently being hosted on fleet game servers.
        /// </para>
        /// </summary>
        public int ActiveGameSessionCount
        {
            get { return this._activeGameSessionCount.GetValueOrDefault(); }
            set { this._activeGameSessionCount = value; }
        }

        // Check to see if ActiveGameSessionCount property is set
        internal bool IsSetActiveGameSessionCount()
        {
            return this._activeGameSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentPlayerSessionCount. 
        /// <para>
        /// Number of active player sessions currently being hosted on fleet game servers.
        /// </para>
        /// </summary>
        public int CurrentPlayerSessionCount
        {
            get { return this._currentPlayerSessionCount.GetValueOrDefault(); }
            set { this._currentPlayerSessionCount = value; }
        }

        // Check to see if CurrentPlayerSessionCount property is set
        internal bool IsSetCurrentPlayerSessionCount()
        {
            return this._currentPlayerSessionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// Maximum players allowed across all game sessions currently hosted in the fleet.
        /// </para>
        /// </summary>
        public int MaximumPlayerSessionCount
        {
            get { return this._maximumPlayerSessionCount.GetValueOrDefault(); }
            set { this._maximumPlayerSessionCount = value; }
        }

        // Check to see if MaximumPlayerSessionCount property is set
        internal bool IsSetMaximumPlayerSessionCount()
        {
            return this._maximumPlayerSessionCount.HasValue; 
        }

    }
}