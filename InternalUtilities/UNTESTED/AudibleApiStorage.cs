﻿using System;
using System.IO;
using System.Linq;
using AudibleApi;
using FileManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InternalUtilities
{
	public static class AudibleApiStorage
	{
		public static string AccountsSettingsFileLegacy30 => Path.Combine(Configuration.Instance.LibationFiles, "IdentityTokens.json");

		public static string AccountsSettingsFile => Path.Combine(Configuration.Instance.LibationFiles, "AccountsSettings.json");

		public static string GetJsonPath(
			//string username
			////, string locale
			)
		{
			return null;


			//var usernameSanitized = JsonConvert.ToString(username);

			////var localeSanitized = JsonConvert.ToString(locale);
			////return $"$.AccountsSettings[?(@.Username == '{usernameSanitized}' && @.IdentityTokens.Locale == '{localeSanitized}')].IdentityTokens";

			//return $"$.AccountsSettings[?(@.Username == '{usernameSanitized}')].IdentityTokens";
		}
	}
}