using System.Collections.Generic;
using System.Threading.Tasks;
using NuGet.Packaging.Core;

namespace NuKeeper.NuGet.Api
{
    public interface IBulkPackageLookup
    {
        Task<Dictionary<string, PackageSearchMedatadataWithSource>> FindVersionUpdates(
            IEnumerable<PackageIdentity> packages,
            VersionChange allowedChange);
    }
}