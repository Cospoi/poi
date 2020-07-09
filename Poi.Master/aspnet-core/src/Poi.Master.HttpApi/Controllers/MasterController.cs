using Poi.Master.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Poi.Master.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MasterController : AbpController
    {
        protected MasterController()
        {
            LocalizationResource = typeof(MasterResource);
        }
    }
}