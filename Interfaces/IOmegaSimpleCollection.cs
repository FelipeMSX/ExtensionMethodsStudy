﻿
namespace ExtensionMethodsPart01.Interfaces
{
    public interface IOmegaSimpleCollection<T> : IOmegaEnumerable<T>, IOmegaDisposable
    {
        int Count { get; }
        void Clear();
        void CopyTo(T[] array, int startIndex);
    }
}