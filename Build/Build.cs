using Nuke.Common;
using Nuke.Common.Execution;
using ricaun.Nuke;
using ricaun.Nuke.Components;

class Build : NukeBuild, IPublishPack, IPrePack, ITest
{
    // string IHazMainProject.MainName => "ProjectName";
    public static int Main() => Execute<Build>(x => x.From<IPublishPack>().Build);
}
