﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JagratBharatNewsAdmin
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="JagratBharat")]
	public partial class DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertScroller(Scroller instance);
    partial void UpdateScroller(Scroller instance);
    partial void DeleteScroller(Scroller instance);
    partial void InsertParagraph(Paragraph instance);
    partial void UpdateParagraph(Paragraph instance);
    partial void DeleteParagraph(Paragraph instance);
    partial void InsertHoroscope(Horoscope instance);
    partial void UpdateHoroscope(Horoscope instance);
    partial void DeleteHoroscope(Horoscope instance);
    partial void InsertZodiac(Zodiac instance);
    partial void UpdateZodiac(Zodiac instance);
    partial void DeleteZodiac(Zodiac instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    #endregion
		
		public DataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["JagratBharatConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<Scroller> Scrollers
		{
			get
			{
				return this.GetTable<Scroller>();
			}
		}
		
		public System.Data.Linq.Table<Paragraph> Paragraphs
		{
			get
			{
				return this.GetTable<Paragraph>();
			}
		}
		
		public System.Data.Linq.Table<Horoscope> Horoscopes
		{
			get
			{
				return this.GetTable<Horoscope>();
			}
		}
		
		public System.Data.Linq.Table<Zodiac> Zodiacs
		{
			get
			{
				return this.GetTable<Zodiac>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<int> _Role;
		
		private string _Mobile;
		
		private string _Email;
		
		private string _LastPassword;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<int> _CreatedBy;
		
		private string _LastIP;
		
		private System.Nullable<System.DateTime> _LastSeen;
		
		private System.Nullable<bool> _Active;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(System.Nullable<int> value);
    partial void OnRoleChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnLastPasswordChanging(string value);
    partial void OnLastPasswordChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnCreatedByChanging(System.Nullable<int> value);
    partial void OnCreatedByChanged();
    partial void OnLastIPChanging(string value);
    partial void OnLastIPChanged();
    partial void OnLastSeenChanging(System.Nullable<System.DateTime> value);
    partial void OnLastSeenChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(100)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="Int")]
		public System.Nullable<int> Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="VarChar(13)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastPassword", DbType="VarChar(100)")]
		public string LastPassword
		{
			get
			{
				return this._LastPassword;
			}
			set
			{
				if ((this._LastPassword != value))
				{
					this.OnLastPasswordChanging(value);
					this.SendPropertyChanging();
					this._LastPassword = value;
					this.SendPropertyChanged("LastPassword");
					this.OnLastPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="Int")]
		public System.Nullable<int> CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastIP", DbType="VarChar(20)")]
		public string LastIP
		{
			get
			{
				return this._LastIP;
			}
			set
			{
				if ((this._LastIP != value))
				{
					this.OnLastIPChanging(value);
					this.SendPropertyChanging();
					this._LastIP = value;
					this.SendPropertyChanged("LastIP");
					this.OnLastIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastSeen", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastSeen
		{
			get
			{
				return this._LastSeen;
			}
			set
			{
				if ((this._LastSeen != value))
				{
					this.OnLastSeenChanging(value);
					this.SendPropertyChanging();
					this._LastSeen = value;
					this.SendPropertyChanged("LastSeen");
					this.OnLastSeenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<bool> _IsAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIsAdminChanging(System.Nullable<bool> value);
    partial void OnIsAdminChanged();
    #endregion
		
		public Role()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this.OnIsAdminChanging(value);
					this.SendPropertyChanging();
					this._IsAdmin = value;
					this.SendPropertyChanged("IsAdmin");
					this.OnIsAdminChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Scrollers")]
	public partial class Scroller : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _ScrollerText;
		
		private System.Nullable<System.DateTime> _PostedOn;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<int> _PostedBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnScrollerTextChanging(string value);
    partial void OnScrollerTextChanged();
    partial void OnPostedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnPostedOnChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnPostedByChanging(System.Nullable<int> value);
    partial void OnPostedByChanged();
    #endregion
		
		public Scroller()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScrollerText", DbType="VarChar(MAX)")]
		public string ScrollerText
		{
			get
			{
				return this._ScrollerText;
			}
			set
			{
				if ((this._ScrollerText != value))
				{
					this.OnScrollerTextChanging(value);
					this.SendPropertyChanging();
					this._ScrollerText = value;
					this.SendPropertyChanged("ScrollerText");
					this.OnScrollerTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> PostedOn
		{
			get
			{
				return this._PostedOn;
			}
			set
			{
				if ((this._PostedOn != value))
				{
					this.OnPostedOnChanging(value);
					this.SendPropertyChanging();
					this._PostedOn = value;
					this.SendPropertyChanged("PostedOn");
					this.OnPostedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedBy", DbType="Int")]
		public System.Nullable<int> PostedBy
		{
			get
			{
				return this._PostedBy;
			}
			set
			{
				if ((this._PostedBy != value))
				{
					this.OnPostedByChanging(value);
					this.SendPropertyChanging();
					this._PostedBy = value;
					this.SendPropertyChanged("PostedBy");
					this.OnPostedByChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paragraphs")]
	public partial class Paragraph : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _PostID;
		
		private string _Paragraphs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPostIDChanging(System.Nullable<int> value);
    partial void OnPostIDChanged();
    partial void OnParagraphsChanging(string value);
    partial void OnParagraphsChanged();
    #endregion
		
		public Paragraph()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", DbType="Int")]
		public System.Nullable<int> PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paragraphs", DbType="NVarChar(MAX)")]
		public string Paragraphs
		{
			get
			{
				return this._Paragraphs;
			}
			set
			{
				if ((this._Paragraphs != value))
				{
					this.OnParagraphsChanging(value);
					this.SendPropertyChanging();
					this._Paragraphs = value;
					this.SendPropertyChanged("Paragraphs");
					this.OnParagraphsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Horoscope")]
	public partial class Horoscope : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Zodiac_ID;
		
		private System.Nullable<System.DateTime> _Date;
		
		private string _Horoscope_Odia;
		
		private string _Horoscope_English;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnZodiac_IDChanging(System.Nullable<int> value);
    partial void OnZodiac_IDChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnHoroscope_OdiaChanging(string value);
    partial void OnHoroscope_OdiaChanged();
    partial void OnHoroscope_EnglishChanging(string value);
    partial void OnHoroscope_EnglishChanged();
    #endregion
		
		public Horoscope()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zodiac_ID", DbType="Int")]
		public System.Nullable<int> Zodiac_ID
		{
			get
			{
				return this._Zodiac_ID;
			}
			set
			{
				if ((this._Zodiac_ID != value))
				{
					this.OnZodiac_IDChanging(value);
					this.SendPropertyChanging();
					this._Zodiac_ID = value;
					this.SendPropertyChanged("Zodiac_ID");
					this.OnZodiac_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horoscope_Odia", DbType="NVarChar(MAX)")]
		public string Horoscope_Odia
		{
			get
			{
				return this._Horoscope_Odia;
			}
			set
			{
				if ((this._Horoscope_Odia != value))
				{
					this.OnHoroscope_OdiaChanging(value);
					this.SendPropertyChanging();
					this._Horoscope_Odia = value;
					this.SendPropertyChanged("Horoscope_Odia");
					this.OnHoroscope_OdiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horoscope_English", DbType="NVarChar(MAX)")]
		public string Horoscope_English
		{
			get
			{
				return this._Horoscope_English;
			}
			set
			{
				if ((this._Horoscope_English != value))
				{
					this.OnHoroscope_EnglishChanging(value);
					this.SendPropertyChanging();
					this._Horoscope_English = value;
					this.SendPropertyChanged("Horoscope_English");
					this.OnHoroscope_EnglishChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Zodiacs")]
	public partial class Zodiac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Zodiac_Odia;
		
		private string _Zodiac_English;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnZodiac_OdiaChanging(string value);
    partial void OnZodiac_OdiaChanged();
    partial void OnZodiac_EnglishChanging(string value);
    partial void OnZodiac_EnglishChanged();
    #endregion
		
		public Zodiac()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zodiac_Odia", DbType="NVarChar(100)")]
		public string Zodiac_Odia
		{
			get
			{
				return this._Zodiac_Odia;
			}
			set
			{
				if ((this._Zodiac_Odia != value))
				{
					this.OnZodiac_OdiaChanging(value);
					this.SendPropertyChanging();
					this._Zodiac_Odia = value;
					this.SendPropertyChanged("Zodiac_Odia");
					this.OnZodiac_OdiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zodiac_English", DbType="VarChar(100)")]
		public string Zodiac_English
		{
			get
			{
				return this._Zodiac_English;
			}
			set
			{
				if ((this._Zodiac_English != value))
				{
					this.OnZodiac_EnglishChanging(value);
					this.SendPropertyChanging();
					this._Zodiac_English = value;
					this.SendPropertyChanged("Zodiac_English");
					this.OnZodiac_EnglishChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posts")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _HeadLine;
		
		private System.Nullable<int> _Category;
		
		private System.Nullable<System.DateTime> _NewsDate;
		
		private System.Data.Linq.Binary _Image;
		
		private string _VideoPath;
		
		private System.Nullable<System.DateTime> _PostedOn;
		
		private System.Nullable<int> _PostedBy;
		
		private System.Nullable<bool> _Submitted;
		
		private System.Nullable<bool> _SelectedScroller;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnHeadLineChanging(string value);
    partial void OnHeadLineChanged();
    partial void OnCategoryChanging(System.Nullable<int> value);
    partial void OnCategoryChanged();
    partial void OnNewsDateChanging(System.Nullable<System.DateTime> value);
    partial void OnNewsDateChanged();
    partial void OnImageChanging(System.Data.Linq.Binary value);
    partial void OnImageChanged();
    partial void OnVideoPathChanging(string value);
    partial void OnVideoPathChanged();
    partial void OnPostedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnPostedOnChanged();
    partial void OnPostedByChanging(System.Nullable<int> value);
    partial void OnPostedByChanged();
    partial void OnSubmittedChanging(System.Nullable<bool> value);
    partial void OnSubmittedChanged();
    partial void OnSelectedScrollerChanging(System.Nullable<bool> value);
    partial void OnSelectedScrollerChanged();
    #endregion
		
		public Post()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeadLine", DbType="NVarChar(200)")]
		public string HeadLine
		{
			get
			{
				return this._HeadLine;
			}
			set
			{
				if ((this._HeadLine != value))
				{
					this.OnHeadLineChanging(value);
					this.SendPropertyChanging();
					this._HeadLine = value;
					this.SendPropertyChanged("HeadLine");
					this.OnHeadLineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="Int")]
		public System.Nullable<int> Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewsDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> NewsDate
		{
			get
			{
				return this._NewsDate;
			}
			set
			{
				if ((this._NewsDate != value))
				{
					this.OnNewsDateChanging(value);
					this.SendPropertyChanging();
					this._NewsDate = value;
					this.SendPropertyChanged("NewsDate");
					this.OnNewsDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VideoPath", DbType="VarChar(300)")]
		public string VideoPath
		{
			get
			{
				return this._VideoPath;
			}
			set
			{
				if ((this._VideoPath != value))
				{
					this.OnVideoPathChanging(value);
					this.SendPropertyChanging();
					this._VideoPath = value;
					this.SendPropertyChanged("VideoPath");
					this.OnVideoPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> PostedOn
		{
			get
			{
				return this._PostedOn;
			}
			set
			{
				if ((this._PostedOn != value))
				{
					this.OnPostedOnChanging(value);
					this.SendPropertyChanging();
					this._PostedOn = value;
					this.SendPropertyChanged("PostedOn");
					this.OnPostedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostedBy", DbType="Int")]
		public System.Nullable<int> PostedBy
		{
			get
			{
				return this._PostedBy;
			}
			set
			{
				if ((this._PostedBy != value))
				{
					this.OnPostedByChanging(value);
					this.SendPropertyChanging();
					this._PostedBy = value;
					this.SendPropertyChanged("PostedBy");
					this.OnPostedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Submitted", DbType="Bit")]
		public System.Nullable<bool> Submitted
		{
			get
			{
				return this._Submitted;
			}
			set
			{
				if ((this._Submitted != value))
				{
					this.OnSubmittedChanging(value);
					this.SendPropertyChanging();
					this._Submitted = value;
					this.SendPropertyChanged("Submitted");
					this.OnSubmittedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectedScroller", DbType="Bit")]
		public System.Nullable<bool> SelectedScroller
		{
			get
			{
				return this._SelectedScroller;
			}
			set
			{
				if ((this._SelectedScroller != value))
				{
					this.OnSelectedScrollerChanging(value);
					this.SendPropertyChanging();
					this._SelectedScroller = value;
					this.SendPropertyChanged("SelectedScroller");
					this.OnSelectedScrollerChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
