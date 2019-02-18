// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI clone tile request
    /// </summary>
    public partial class CloneTileRequest
    {
        /// <summary>
        /// Initializes a new instance of the CloneTileRequest class.
        /// </summary>
        public CloneTileRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloneTileRequest class.
        /// </summary>
        /// <param name="targetDashboardId">The target dashboard id</param>
        /// <param name="targetWorkspaceId">Optional parameter for specifying
        /// the target workspace id. Empty Guid
        /// (00000000-0000-0000-0000-000000000000) indicates 'My Workspace'.
        /// &lt;br/&gt;If not provided, tile will be cloned within the same
        /// workspace as the source tile.</param>
        /// <param name="targetReportId">Optional parameter &lt;br/&gt;When
        /// cloning a tile linked to a report, pass the target report id to
        /// rebind the new tile to a different report.</param>
        /// <param name="targetModelId">Optional parameter &lt;br/&gt;When
        /// cloning a tile linked to a dataset, pass the target model id to
        /// rebind the new tile to a different dataset.</param>
        /// <param name="positionConflictAction">Optional parameter for
        /// specifying the action in case of position conflict. &lt;br/&gt;If
        /// not provided, 'Tail' is used. &lt;br/&gt;If there is no conflict,
        /// clone tile to same position as in source. Possible values include:
        /// 'Tail', 'Abort'</param>
        public CloneTileRequest(string targetDashboardId = default(string), string targetWorkspaceId = default(string), string targetReportId = default(string), string targetModelId = default(string), string positionConflictAction = default(string))
        {
            TargetDashboardId = targetDashboardId;
            TargetWorkspaceId = targetWorkspaceId;
            TargetReportId = targetReportId;
            TargetModelId = targetModelId;
            PositionConflictAction = positionConflictAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target dashboard id
        /// </summary>
        [JsonProperty(PropertyName = "targetDashboardId")]
        public string TargetDashboardId { get; set; }

        /// <summary>
        /// Gets or sets optional parameter for specifying the target workspace
        /// id. Empty Guid (00000000-0000-0000-0000-000000000000) indicates 'My
        /// Workspace'. &amp;lt;br/&amp;gt;If not provided, tile will be cloned
        /// within the same workspace as the source tile.
        /// </summary>
        [JsonProperty(PropertyName = "targetWorkspaceId")]
        public string TargetWorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets optional parameter &amp;lt;br/&amp;gt;When cloning a
        /// tile linked to a report, pass the target report id to rebind the
        /// new tile to a different report.
        /// </summary>
        [JsonProperty(PropertyName = "targetReportId")]
        public string TargetReportId { get; set; }

        /// <summary>
        /// Gets or sets optional parameter &amp;lt;br/&amp;gt;When cloning a
        /// tile linked to a dataset, pass the target model id to rebind the
        /// new tile to a different dataset.
        /// </summary>
        [JsonProperty(PropertyName = "targetModelId")]
        public string TargetModelId { get; set; }

        /// <summary>
        /// Gets or sets optional parameter for specifying the action in case
        /// of position conflict. &amp;lt;br/&amp;gt;If not provided, 'Tail' is
        /// used. &amp;lt;br/&amp;gt;If there is no conflict, clone tile to
        /// same position as in source. Possible values include: 'Tail',
        /// 'Abort'
        /// </summary>
        [JsonProperty(PropertyName = "positionConflictAction")]
        public string PositionConflictAction { get; set; }

    }
}