using Marieyr.Yuki.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Marieyr.Yuki.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class YukiController : AbpController
    {
        protected YukiController()
        {
            LocalizationResource = typeof(YukiResource);
        }
    }
}