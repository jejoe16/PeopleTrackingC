/* 
 * TrackServer
 *
 * Server for People Tracking System
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse2001
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001 :  IEquatable<InlineResponse2001>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2001() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001" /> class.
        /// </summary>
        /// <param name="Latitude">Latitude (required).</param>
        /// <param name="Longitude">Longitude (required).</param>
        /// <param name="Name">Name (required).</param>
        public InlineResponse2001(List<int?> Latitude = null, List<int?> Longitude = null, List<string> Name = null)
        {
            // to ensure "Latitude" is required (not null)
            if (Latitude == null)
            {
                throw new InvalidDataException("Latitude is a required property for InlineResponse2001 and cannot be null");
            }
            else
            {
                this.Latitude = Latitude;
            }
            // to ensure "Longitude" is required (not null)
            if (Longitude == null)
            {
                throw new InvalidDataException("Longitude is a required property for InlineResponse2001 and cannot be null");
            }
            else
            {
                this.Longitude = Longitude;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for InlineResponse2001 and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public List<int?> Latitude { get; set; }
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public List<int?> Longitude { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public List<string> Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001 {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as InlineResponse2001);
        }

        /// <summary>
        /// Returns true if InlineResponse2001 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.SequenceEqual(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.SequenceEqual(other.Longitude)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(other.Name)
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
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
