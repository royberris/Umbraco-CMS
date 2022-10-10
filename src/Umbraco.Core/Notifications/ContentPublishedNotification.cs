// Copyright (c) Umbraco.
// See LICENSE for more details.

using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Core.Notifications;

/// <summary>
/// Called while publishing content after entities are persisted.
/// </summary>
public sealed class ContentPublishedNotification : EnumerableObjectNotification<IContent>
{
    public ContentPublishedNotification(IContent target, EventMessages messages)
        : base(target, messages)
    {
    }

    public ContentPublishedNotification(IEnumerable<IContent> target, EventMessages messages)
        : base(target, messages)
    {
    }

    /// <summary>
    /// Gets a enumeration of <see cref="IContent"/> with the published entities.
    /// </summary>
    public IEnumerable<IContent> PublishedEntities => Target;
}
