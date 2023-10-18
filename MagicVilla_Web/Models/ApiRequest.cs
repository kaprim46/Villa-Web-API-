﻿using System;
using static MagicVilla_Utitlity.SD;

namespace MagicVilla_Web.Models
{
	public class ApiRequest
	{
		public ApiType ApiType { get; set; } = ApiType.GET;
		public string Url { get; set; }
		public object Data { get; set; }
		public string Token { get; set; }
	}
}

