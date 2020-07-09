using Volo.Abp.Settings;

namespace Cospoi.Gopick.Settings
{
    public class GopickSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GopickSettings.MySetting1));
        }
    }
}
