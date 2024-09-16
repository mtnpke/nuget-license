﻿// Licensed to the projects contributors.
// The license conditions are provided in the LICENSE file located in the project root

using NuGetUtility.Wrapper.NuGetWrapper.Frameworks;

namespace NuGetUtility.Wrapper.NuGetWrapper.ProjectModel
{
    public interface ILockFileTarget
    {
        INuGetFramework TargetFramework { get; }
        IEnumerable<ILockFileLibrary> Libraries { get; }
    }
}
