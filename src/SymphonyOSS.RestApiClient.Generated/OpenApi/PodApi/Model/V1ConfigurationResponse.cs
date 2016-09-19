﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// Configuration for each integration type.
    /// </summary>
    [DataContract]
    public partial class V1ConfigurationResponse :  IEquatable<V1ConfigurationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ConfigurationResponse" /> class.
        /// </summary>
        /// <param name="ConfigurationId">ConfigurationId.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Active">Active.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Visible">Visible.</param>
        public V1ConfigurationResponse(string ConfigurationId = null, string Type = null, bool? Active = null, string Name = null, string Description = null, bool? Enabled = null, bool? Visible = null)
        {
            
            
                        this.ConfigurationId = ConfigurationId;
            
                        this.Type = Type;
            
                        this.Active = Active;
            
                        this.Name = Name;
            
                        this.Description = Description;
            
                        this.Enabled = Enabled;
            
                        this.Visible = Visible;
            
        }
        
        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name="configurationId", EmitDefaultValue=false)]
        public string ConfigurationId { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ConfigurationResponse {\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
sb.Append("  Type: ").Append(Type).Append("\n");
sb.Append("  Active: ").Append(Active).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  Enabled: ").Append(Enabled).Append("\n");
sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1ConfigurationResponse);
        }

        /// <summary>
        /// Returns true if V1ConfigurationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ConfigurationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigurationId == other.ConfigurationId ||
                    this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(other.ConfigurationId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ConfigurationId != null)
                    hash = hash * 59 + this.ConfigurationId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                return hash;
            }
        }
    }

}
