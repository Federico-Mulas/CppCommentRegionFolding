using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;

namespace CppCommentRegionFolding
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(CppCommentRegionFoldingPackage.PackageGuidString)]
    public sealed class CppCommentRegionFoldingPackage : AsyncPackage
    {
        public const string PackageGuidString = "72826e46-dea2-4470-840a-46a9f95d35ed";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
    }
}
