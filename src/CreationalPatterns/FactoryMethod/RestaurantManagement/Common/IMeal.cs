namespace RestaurantManagement.Common;

/// <summary>
/// The Product declares the interface, which is common to all objects that
/// can be produced by the creator <see cref="Restaurant"/> and its subclasses.
/// 一顿饭
/// </summary>
public interface IMeal
{
    void ShowDescription();
}
