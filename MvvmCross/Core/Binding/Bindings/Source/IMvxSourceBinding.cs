// IMvxSourceBinding.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace MvvmCross.Binding.Bindings.Source
{
    public interface IMvxSourceBinding : IMvxBinding
    {
        Type SourceType { get; }

        void SetValue(object value);

        event EventHandler Changed;

        object GetValue();
    }
}