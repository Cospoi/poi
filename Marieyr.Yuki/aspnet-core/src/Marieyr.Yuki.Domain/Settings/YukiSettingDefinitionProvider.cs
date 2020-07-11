using Volo.Abp.Settings;

namespace Marieyr.Yuki.Settings
{
    public class YukiSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(YukiSettings.MySetting1));
        }
    }
}
