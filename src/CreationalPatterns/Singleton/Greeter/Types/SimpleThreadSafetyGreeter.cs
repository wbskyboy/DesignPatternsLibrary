﻿using Greeter.Types.Common;

namespace Greeter.Types;

/// <summary>
/// This implementation is thread-safe.
/// The thread takes out a lock on a shared object, and then checks whether
/// or not the instance has been created before retrieving the instance.
/// Unfortunately, performance suffers as a lock is acquired every time the instance is requested.
/// 线程安全的懒汉式
/// </summary>
public class SimpleThreadSafetyGreeter : BaseGreeter
{
    private static readonly object Padlock = new();

    private static SimpleThreadSafetyGreeter? _instance;

    private SimpleThreadSafetyGreeter()
    {
    }

    public static SimpleThreadSafetyGreeter Instance
    {
        get
        {
            lock (Padlock)
            {
                if (_instance == null)
                {
                    _instance = new SimpleThreadSafetyGreeter();
                }

                return _instance;
            }
        }
    }
}