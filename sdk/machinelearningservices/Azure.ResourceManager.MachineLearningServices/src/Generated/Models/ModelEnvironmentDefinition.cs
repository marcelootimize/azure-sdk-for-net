// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The ModelEnvironmentDefinition. </summary>
    public partial class ModelEnvironmentDefinition
    {
        /// <summary> Initializes a new instance of ModelEnvironmentDefinition. </summary>
        public ModelEnvironmentDefinition()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The name of the environment. </summary>
        public string Name { get; set; }
        /// <summary> The environment version. </summary>
        public string Version { get; set; }
        /// <summary> Settings for a Python environment. </summary>
        public ModelEnvironmentDefinitionPython Python { get; set; }
        /// <summary> Definition of environment variables to be defined in the environment. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        /// <summary> The definition of a Docker container. </summary>
        public ModelEnvironmentDefinitionDocker Docker { get; set; }
        /// <summary> The configuration for a Spark environment. </summary>
        public ModelEnvironmentDefinitionSpark Spark { get; set; }
        /// <summary> Settings for a R environment. </summary>
        public ModelEnvironmentDefinitionR R { get; set; }
        /// <summary> The inferencing stack version added to the image. To avoid adding an inferencing stack, do not set this value. Valid values: &quot;latest&quot;. </summary>
        public string InferencingStackVersion { get; set; }
    }
}
