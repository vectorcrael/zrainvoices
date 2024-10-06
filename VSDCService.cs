using System;
using DataLayer.Models2;
using DataLayer.Services;

namespace VSDCAPI
{
	public class VSDCService
	{
        private readonly IFiscalInfoService _fiscalInfoService;

        public VSDCService(IFiscalInfoService fiscalInfoService)
        {
            _fiscalInfoService = fiscalInfoService;
        }

        public async Task<List<ZraInvoice>> GetInvoices()
        {
            return await _fiscalInfoService.GetZraInvoicesAsync();
        }

    }
}

