// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{

    /// <summary>
    /// Defines values for TokenAccessLevel.
    /// </summary>
    public static class TokenAccessLevel
    {
        /// <summary>
        /// Indicates that the generated EmbedToken should grant only Viewing
        /// permissions
        /// </summary>
        public const string View = "View";
        /// <summary>
        /// Indicates that the generated EmbedToken should grant Viewing and
        /// Editing permissions, only applies when generating EmbedToken for
        /// report embedding
        /// </summary>
        public const string Edit = "Edit";
        /// <summary>
        /// Indicates that the generated EmbedToken should grant Creation
        /// permissions, only applies when generating EmbedToken for report
        /// creation
        /// </summary>
        public const string Create = "Create";
    }
}
