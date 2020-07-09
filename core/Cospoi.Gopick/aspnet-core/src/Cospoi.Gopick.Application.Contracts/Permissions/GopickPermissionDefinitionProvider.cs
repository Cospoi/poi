using Cospoi.Gopick.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cospoi.Gopick.Permissions
{
    public class GopickPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GopickPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(GopickPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GopickResource>(name);
        }
    }
}
