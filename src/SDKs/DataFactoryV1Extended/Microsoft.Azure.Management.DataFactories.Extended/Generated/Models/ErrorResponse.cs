// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactories.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactories;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The object that defines the structure of an Azure Data Factory
    /// response.
    /// </summary>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="target">Property name/path in request associated with
        /// error.</param>
        /// <param name="details">Array with additional error details.</param>
        /// <param name="error">Nested error information.</param>
        public ErrorResponse(string code, string message, string target = default(string), IList<ErrorResponse> details = default(IList<ErrorResponse>), ErrorResponse error = default(ErrorResponse))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets property name/path in request associated with error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets array with additional error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorResponse> Details { get; set; }

        /// <summary>
        /// Gets or sets nested error information.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}