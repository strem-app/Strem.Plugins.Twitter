using Cake.Frosting;
using Strem.Build.Tasks;

namespace Strem.Build.Orchestration;

[TaskName("publish")]
[IsDependentOn(typeof(PackageTwitterPluginTask))]
[IsDependentOn(typeof(PackageLibsTask))]
public class PublishTask : FrostingTask<BuildContext>
{
    
}