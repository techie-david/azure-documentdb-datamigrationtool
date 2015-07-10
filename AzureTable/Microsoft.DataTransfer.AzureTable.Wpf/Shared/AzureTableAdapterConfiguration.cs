﻿using Microsoft.DataTransfer.AzureTable.Shared;
using Microsoft.DataTransfer.Basics.Extensions;
using Microsoft.DataTransfer.WpfHost.Basics;

namespace Microsoft.DataTransfer.AzureTable.Wpf.Shared
{
    abstract class AzureTableAdapterConfiguration : ValidatableBindableBase, IAzureTableAdapterConfiguration
    {
        public static readonly string ConnectionStringPropertyName =
            ObjectExtensions.MemberName<IAzureTableAdapterConfiguration>(c => c.ConnectionString);

        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { SetProperty(ref connectionString, value, ValidateNonEmptyString); }
        }
    }
}
