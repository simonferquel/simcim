using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.V2
{
    public class MsftWmiProviderCounters : GenericInfrastructureObject
    {
        public MsftWmiProviderCounters()
        {
        }

        public MsftWmiProviderCounters(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt64? ProviderOperationAccessCheck
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_AccessCheck", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_AccessCheck", value);
            }
        }

        public System.UInt64? ProviderOperationCancelQuery
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CancelQuery", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CancelQuery", value);
            }
        }

        public System.UInt64? ProviderOperationCreateClassEnumAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CreateClassEnumAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CreateClassEnumAsync", value);
            }
        }

        public System.UInt64? ProviderOperationCreateInstanceEnumAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CreateInstanceEnumAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CreateInstanceEnumAsync", value);
            }
        }

        public System.UInt64? ProviderOperationCreateRefreshableEnum
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CreateRefreshableEnum", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CreateRefreshableEnum", value);
            }
        }

        public System.UInt64? ProviderOperationCreateRefreshableObject
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CreateRefreshableObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CreateRefreshableObject", value);
            }
        }

        public System.UInt64? ProviderOperationCreateRefresher
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_CreateRefresher", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_CreateRefresher", value);
            }
        }

        public System.UInt64? ProviderOperationDeleteClassAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_DeleteClassAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_DeleteClassAsync", value);
            }
        }

        public System.UInt64? ProviderOperationDeleteInstanceAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_DeleteInstanceAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_DeleteInstanceAsync", value);
            }
        }

        public System.UInt64? ProviderOperationExecMethodAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_ExecMethodAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_ExecMethodAsync", value);
            }
        }

        public System.UInt64? ProviderOperationExecQueryAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_ExecQueryAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_ExecQueryAsync", value);
            }
        }

        public System.UInt64? ProviderOperationFindConsumer
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_FindConsumer", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_FindConsumer", value);
            }
        }

        public System.UInt64? ProviderOperationGetObjectAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_GetObjectAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_GetObjectAsync", value);
            }
        }

        public System.UInt64? ProviderOperationGetObjects
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_GetObjects", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_GetObjects", value);
            }
        }

        public System.UInt64? ProviderOperationGetProperty
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_GetProperty", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_GetProperty", value);
            }
        }

        public System.UInt64? ProviderOperationNewQuery
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_NewQuery", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_NewQuery", value);
            }
        }

        public System.UInt64? ProviderOperationProvideEvents
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_ProvideEvents", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_ProvideEvents", value);
            }
        }

        public System.UInt64? ProviderOperationPutClassAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_PutClassAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_PutClassAsync", value);
            }
        }

        public System.UInt64? ProviderOperationPutInstanceAsync
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_PutInstanceAsync", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_PutInstanceAsync", value);
            }
        }

        public System.UInt64? ProviderOperationPutProperty
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_PutProperty", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_PutProperty", value);
            }
        }

        public System.UInt64? ProviderOperationQueryInstances
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_QueryInstances", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_QueryInstances", value);
            }
        }

        public System.UInt64? ProviderOperationSetRegistrationObject
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_SetRegistrationObject", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_SetRegistrationObject", value);
            }
        }

        public System.UInt64? ProviderOperationStopRefreshing
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_StopRefreshing", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_StopRefreshing", value);
            }
        }

        public System.UInt64? ProviderOperationValidateSubscription
        {
            get
            {
                System.UInt64? result;
                this.GetProperty("ProviderOperation_ValidateSubscription", out result);
                return result;
            }

            set
            {
                this.SetProperty("ProviderOperation_ValidateSubscription", value);
            }
        }
    }
}