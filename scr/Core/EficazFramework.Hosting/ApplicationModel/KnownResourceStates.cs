namespace EficazFramework.Hosting.ApplicationModel;

/// <summary>
/// The set of well known resource states.
/// </summary>
public static class KnownResourceStates
{
    /// <summary>
    /// The hidden state. Useful for hiding the resource.
    /// </summary>
    public static readonly string Hidden = nameof(Hidden);

    /// <summary>
    /// The starting state. Useful for showing the resource is starting.
    /// </summary>
    public static readonly string Starting = nameof(Starting);

    /// <summary>
    /// The running state. Useful for showing the resource is running.
    /// </summary>
    public static readonly string Running = nameof(Running);

    /// <summary>
    /// The finished state. Useful for showing the resource has failed to start successully.
    /// </summary>
    public static readonly string FailedToStart = nameof(FailedToStart);

    /// <summary>
    /// The stopping state. Useful for showing the resource is stopping.
    /// </summary>
    public static readonly string Stopping = nameof(Stopping);

    /// <summary>
    /// The exited state. Useful for showing the resource has exited.
    /// </summary>
    public static readonly string Exited = nameof(Exited);

    /// <summary>
    /// The finished state. Useful for showing the resource has finished.
    /// </summary>
    public static readonly string Finished = nameof(Finished);
}
