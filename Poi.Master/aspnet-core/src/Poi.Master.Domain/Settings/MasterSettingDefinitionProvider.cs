using Volo.Abp.Settings;

namespace Poi.Master.Settings
{
    public class MasterSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MasterSettings.MySetting1));
        }
    }
}
