using Marieyr.Yuki.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Marieyr.Yuki.Permissions
{
    public class YukiPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(YukiPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(YukiPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<YukiResource>(name);
        }
    }
}
