using Greeter.Types.Common;

namespace Greeter.Types;

/// <summary>
/// Instantiation is triggered by the first reference to the static member of the nested class,
/// which only occurs in Instance property. This means the implementation is fully lazy.
/// 对嵌套类静态成员的首次引用（仅在 Instance 属性中出现）会触发实例化。这意味着该实现是完全懒惰的。
/// </summary>
public class LocklessFullyLazyGreeter : BaseGreeter
{
    private LocklessFullyLazyGreeter()
    {
    }

    public static LocklessFullyLazyGreeter Instance => Nested.Instance;

    private class Nested
    {
		/// <summary>
		/// Although nested classes have access to the enclosing class's private members,
		/// the reverse is not true, hence the need for instance to be internal here.
		///  虽然嵌套类可以访问外层类的私有成员，但反之则不行，因此这里需要将实例置于内部。
		/// </summary>
		internal static readonly LocklessFullyLazyGreeter Instance = new();

        // Explicit static constructor to tell C# compiler not to mark as BeforeFieldInit.
        // http://csharpindepth.com/Articles/General/Singleton.aspx
        static Nested()
        {
        }
    }
}