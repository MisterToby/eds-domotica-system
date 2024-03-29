﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Edge.DB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseModelContainer object using the connection string found in the 'DatabaseModelContainer' section of the application configuration file.
        /// </summary>
        public DatabaseModelContainer() : base("name=DatabaseModelContainer", "DatabaseModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseModelContainer object.
        /// </summary>
        public DatabaseModelContainer(string connectionString) : base(connectionString, "DatabaseModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseModelContainer object.
        /// </summary>
        public DatabaseModelContainer(EntityConnection connection) : base(connection, "DatabaseModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<IPCamera> IPCameras
        {
            get
            {
                if ((_IPCameras == null))
                {
                    _IPCameras = base.CreateObjectSet<IPCamera>("IPCameras");
                }
                return _IPCameras;
            }
        }
        private ObjectSet<IPCamera> _IPCameras;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the IPCameras EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToIPCameras(IPCamera iPCamera)
        {
            base.AddObject("IPCameras", iPCamera);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="IPCamera")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class IPCamera : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new IPCamera object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="vendor">Initial value of the Vendor property.</param>
        /// <param name="host">Initial value of the Host property.</param>
        /// <param name="port">Initial value of the Port property.</param>
        /// <param name="useSSL">Initial value of the UseSSL property.</param>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        public static IPCamera CreateIPCamera(global::System.Int32 id, global::System.String description, global::System.Int32 vendor, global::System.String host, global::System.Int32 port, global::System.Boolean useSSL, global::System.String username, global::System.String password)
        {
            IPCamera iPCamera = new IPCamera();
            iPCamera.Id = id;
            iPCamera.Description = description;
            iPCamera.Vendor = vendor;
            iPCamera.Host = host;
            iPCamera.Port = port;
            iPCamera.UseSSL = useSSL;
            iPCamera.Username = username;
            iPCamera.Password = password;
            return iPCamera;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Vendor
        {
            get
            {
                return _Vendor;
            }
            set
            {
                OnVendorChanging(value);
                ReportPropertyChanging("Vendor");
                _Vendor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Vendor");
                OnVendorChanged();
            }
        }
        private global::System.Int32 _Vendor;
        partial void OnVendorChanging(global::System.Int32 value);
        partial void OnVendorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Host
        {
            get
            {
                return _Host;
            }
            set
            {
                OnHostChanging(value);
                ReportPropertyChanging("Host");
                _Host = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Host");
                OnHostChanged();
            }
        }
        private global::System.String _Host;
        partial void OnHostChanging(global::System.String value);
        partial void OnHostChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Port
        {
            get
            {
                return _Port;
            }
            set
            {
                OnPortChanging(value);
                ReportPropertyChanging("Port");
                _Port = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Port");
                OnPortChanged();
            }
        }
        private global::System.Int32 _Port;
        partial void OnPortChanging(global::System.Int32 value);
        partial void OnPortChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean UseSSL
        {
            get
            {
                return _UseSSL;
            }
            set
            {
                OnUseSSLChanging(value);
                ReportPropertyChanging("UseSSL");
                _UseSSL = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UseSSL");
                OnUseSSLChanged();
            }
        }
        private global::System.Boolean _UseSSL;
        partial void OnUseSSLChanging(global::System.Boolean value);
        partial void OnUseSSLChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                OnUsernameChanging(value);
                ReportPropertyChanging("Username");
                _Username = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Username");
                OnUsernameChanged();
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();

        #endregion

    
    }

    #endregion

    
}
