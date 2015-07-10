﻿using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.DataTransfer.ServiceModel.Statistics
{
    /// <summary>
    /// Provides data transfer statistics.
    /// </summary>
    public interface ITransferStatisticsFactory
    {
        /// <summary>
        /// Creates a new instance of data transfer statistics.
        /// </summary>
        /// <param name="configuration">Configuration for the data transfer statistics.</param>
        /// <param name="cancellation">Cancellation token.</param>
        /// <returns>Task that represents asynchronous create operation.</returns>
        Task<ITransferStatistics> Create(ITransferStatisticsConfiguration configuration, CancellationToken cancellation);
    }
}
