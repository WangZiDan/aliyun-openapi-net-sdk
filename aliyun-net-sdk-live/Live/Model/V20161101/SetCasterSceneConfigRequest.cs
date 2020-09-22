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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetCasterSceneConfigRequest : RpcAcsRequest<SetCasterSceneConfigResponse>
    {
        public SetCasterSceneConfigRequest()
            : base("live", "2016-11-01", "SetCasterSceneConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string layoutId;

		private List<string> componentIds = new List<string>(){ };

		private string casterId;

		private long? ownerId;

		private string sceneId;

		public string LayoutId
		{
			get
			{
				return layoutId;
			}
			set	
			{
				layoutId = value;
				DictionaryUtil.Add(QueryParameters, "LayoutId", value);
			}
		}

		public List<string> ComponentIds
		{
			get
			{
				return componentIds;
			}

			set
			{
				componentIds = value;
				for (int i = 0; i < componentIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ComponentId." + (i + 1) , componentIds[i]);
				}
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(QueryParameters, "SceneId", value);
			}
		}

        public override SetCasterSceneConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCasterSceneConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
