using System;

namespace LoreSoft.Shared.ComponentModel
{
    /// <summary>
    /// The base class for pipeline context data
    /// </summary>
    public abstract class PipelineContextBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether this pipeline is cancelled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this pipeline is cancelled; otherwise, <c>false</c>.
        /// </value>
        public bool IsCancelled { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this pipeline context is processed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this pipeline context is processed; otherwise, <c>false</c>.
        /// </value>
        public bool IsProcessed { get; set; }
    }
}