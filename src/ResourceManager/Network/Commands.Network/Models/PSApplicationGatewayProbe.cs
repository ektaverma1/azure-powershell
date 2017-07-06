﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSApplicationGatewayProbe : PSChildResource
    {
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public uint Interval { get; set; }
        public uint Timeout { get; set; }
        public uint UnhealthyThreshold { get; set; }
        public bool? PickHostNameFromBackendHttpSettings { get; set; }
        public uint? MinServers { get; set; }
        public PSApplicationGatewayProbeHealthResponseMatch Match { get; set; }
        public string ProvisioningState { get; set; }
        public string Type { get; set; }

        [JsonIgnore]
        public string MatchText
        {
            get { return JsonConvert.SerializeObject(Match, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }
    }
}
