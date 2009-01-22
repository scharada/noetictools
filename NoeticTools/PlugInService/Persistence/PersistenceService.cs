#region Copyright

/*---------------------------------------------------------------------------
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations under 
 * the License.
 * 
 * The Initial Developer of the Original Code is Robert Smyth.
 * Portions created by Robert Smyth are Copyright (C) 2008.
 * 
 * All Rights Reserved.
 *---------------------------------------------------------------------------*/

#endregion //Copyright

using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System;
using NoeticTools.Windows.Forms;
using NXmlSerializer.XML;


namespace NoeticTools.PlugIns.Persistence
{
	public class PersistenceService : IPersistenceService
	{
		private readonly NXmlDocument xmlDocument = new NXmlDocument();
		private const string appFolderName = "VicFireReader";
		private const string filename = "Config.xml";
		private readonly Dictionary<string, PersistenceUpdateDelegate> scopeListeners = new Dictionary<string, PersistenceUpdateDelegate>();
		private readonly string fullPath;
		private readonly Scopes scopes = new Scopes();

		public PersistenceService(Assembly seedAssembly)
		{
			fullPath =
				Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), appFolderName);
			fullPath = Path.Combine(fullPath, filename);

			if (File.Exists(fullPath))
			{
				try
				{
					scopes = xmlDocument.Load<Scopes>(fullPath, seedAssembly, null);
				}
				catch(Exception exception)
				{
					ErrorForm form = new ErrorForm("Unable to load configuration from file.", exception);
					form.ShowDialog();
				}
			}
		}

		public void UpdateAndSave()
		{
			foreach (KeyValuePair<string, PersistenceUpdateDelegate> scopePair in scopeListeners)
			{
				object value = scopePair.Value();
				scopes.UpdateScope(scopePair.Key, value);
			}
            
			xmlDocument.Save(fullPath, scopes, null);
		}

		public T RegisterScope<T>(string scopeName, PersistenceUpdateDelegate listener, T defaultValue)
			where T : class
		{
			scopeListeners[scopeName] = listener;

			return scopes.GetScopeValue<T>(scopeName, defaultValue);
		}

		[NXmlSerializable(SerializeOption.Fields)]
		private class Scopes
		{
			private readonly Dictionary<string, object> scopes = new Dictionary<string, object>();

			public T GetScopeValue<T>(string scopeName, object defaultValue)
			{
				object scopeValue;
				if (!scopes.TryGetValue(scopeName, out scopeValue))
				{
					scopeValue = defaultValue;
				}
				return (T) scopeValue;
			}

			public void UpdateScope(string scopeName, object value)
			{
				scopes[scopeName] = value;
			}
		}
	}
}