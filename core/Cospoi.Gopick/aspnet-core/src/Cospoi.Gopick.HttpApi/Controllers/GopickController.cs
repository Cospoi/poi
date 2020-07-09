using Cospoi.Gopick.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cospoi.Gopick.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GopickController : AbpController
    {
        protected GopickController()
        {
            LocalizationResource = typeof(GopickResource);
        }
    }
}