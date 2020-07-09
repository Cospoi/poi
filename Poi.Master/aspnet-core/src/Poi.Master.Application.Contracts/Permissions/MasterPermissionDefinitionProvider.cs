using Poi.Master.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Poi.Master.Permissions
{
    public class MasterPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MasterPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MasterPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MasterResource>(name);
        }
    }
}
