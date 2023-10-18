using System;
using MagicVilla_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModel
{
	public class VillaNumberUpdateVM
	{
        public VillaNumberUpdateVM()
        {
            VillaNumberUpdate = new VillaNumberUpdateDTO();
        }
        public VillaNumberUpdateDTO VillaNumberUpdate { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VillasList { get; set; }
	}
}

