/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class CreateDeployConfigRequest : RpcAcsRequest<CreateDeployConfigResponse>
    {
        public CreateDeployConfigRequest()
            : base("retailcloud", "2018-03-13", "CreateDeployConfig", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string codePath;

		private List<string> configMapLists = new List<string>(){ };

		private long? appId;

		private string configMap;

		private string statefulSet;

		private string envType;

		private string name;

		private List<string> secretLists = new List<string>(){ };

		private string deployment;

		public string CodePath
		{
			get
			{
				return codePath;
			}
			set	
			{
				codePath = value;
				DictionaryUtil.Add(QueryParameters, "CodePath", value);
			}
		}

		public List<string> ConfigMapLists
		{
			get
			{
				return configMapLists;
			}

			set
			{
				configMapLists = value;
				for (int i = 0; i < configMapLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ConfigMapList." + (i + 1) , configMapLists[i]);
				}
			}
		}

		public long? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
			}
		}

		public string ConfigMap
		{
			get
			{
				return configMap;
			}
			set	
			{
				configMap = value;
				DictionaryUtil.Add(QueryParameters, "ConfigMap", value);
			}
		}

		public string StatefulSet
		{
			get
			{
				return statefulSet;
			}
			set	
			{
				statefulSet = value;
				DictionaryUtil.Add(QueryParameters, "StatefulSet", value);
			}
		}

		public string EnvType
		{
			get
			{
				return envType;
			}
			set	
			{
				envType = value;
				DictionaryUtil.Add(QueryParameters, "EnvType", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public List<string> SecretLists
		{
			get
			{
				return secretLists;
			}

			set
			{
				secretLists = value;
				for (int i = 0; i < secretLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecretList." + (i + 1) , secretLists[i]);
				}
			}
		}

		public string Deployment
		{
			get
			{
				return deployment;
			}
			set	
			{
				deployment = value;
				DictionaryUtil.Add(QueryParameters, "Deployment", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDeployConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDeployConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
