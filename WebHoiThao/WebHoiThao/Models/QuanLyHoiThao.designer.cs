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

namespace WebHoiThao.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_HOITHAO")]
	public partial class QuanLyHoiThaoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertPaper(Paper instance);
    partial void UpdatePaper(Paper instance);
    partial void DeletePaper(Paper instance);
    partial void InsertReview(Review instance);
    partial void UpdateReview(Review instance);
    partial void DeleteReview(Review instance);
    #endregion
		
		public QuanLyHoiThaoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_HOITHAOConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoiThaoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoiThaoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoiThaoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyHoiThaoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Paper> Papers
		{
			get
			{
				return this.GetTable<Paper>();
			}
		}
		
		public System.Data.Linq.Table<Review> Reviews
		{
			get
			{
				return this.GetTable<Review>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Authors")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _author_id;
		
		private string _name;
		
		private string _email;
		
		private string _affiliation;
		
		private EntitySet<Paper> _Papers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onauthor_idChanging(string value);
    partial void Onauthor_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnaffiliationChanging(string value);
    partial void OnaffiliationChanged();
    #endregion
		
		public Author()
		{
			this._Papers = new EntitySet<Paper>(new Action<Paper>(this.attach_Papers), new Action<Paper>(this.detach_Papers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_id", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string author_id
		{
			get
			{
				return this._author_id;
			}
			set
			{
				if ((this._author_id != value))
				{
					this.Onauthor_idChanging(value);
					this.SendPropertyChanging();
					this._author_id = value;
					this.SendPropertyChanged("author_id");
					this.Onauthor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_affiliation", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string affiliation
		{
			get
			{
				return this._affiliation;
			}
			set
			{
				if ((this._affiliation != value))
				{
					this.OnaffiliationChanging(value);
					this.SendPropertyChanging();
					this._affiliation = value;
					this.SendPropertyChanged("affiliation");
					this.OnaffiliationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Paper", Storage="_Papers", ThisKey="author_id", OtherKey="author_id")]
		public EntitySet<Paper> Papers
		{
			get
			{
				return this._Papers;
			}
			set
			{
				this._Papers.Assign(value);
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
		
		private void attach_Papers(Paper entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_Papers(Paper entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user_id;
		
		private string _username;
		
		private string _password;
		
		private string _salt;
		
		private string _email;
		
		private string _full_name;
		
		private string _affiliation;
		
		private string _country;
		
		private string _role;
		
		private EntitySet<Review> _Reviews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(string value);
    partial void Onuser_idChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnsaltChanging(string value);
    partial void OnsaltChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onfull_nameChanging(string value);
    partial void Onfull_nameChanged();
    partial void OnaffiliationChanging(string value);
    partial void OnaffiliationChanged();
    partial void OncountryChanging(string value);
    partial void OncountryChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    #endregion
		
		public User()
		{
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salt", DbType="VarChar(200)")]
		public string salt
		{
			get
			{
				return this._salt;
			}
			set
			{
				if ((this._salt != value))
				{
					this.OnsaltChanging(value);
					this.SendPropertyChanging();
					this._salt = value;
					this.SendPropertyChanged("salt");
					this.OnsaltChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_full_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string full_name
		{
			get
			{
				return this._full_name;
			}
			set
			{
				if ((this._full_name != value))
				{
					this.Onfull_nameChanging(value);
					this.SendPropertyChanging();
					this._full_name = value;
					this.SendPropertyChanged("full_name");
					this.Onfull_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_affiliation", DbType="VarChar(100)")]
		public string affiliation
		{
			get
			{
				return this._affiliation;
			}
			set
			{
				if ((this._affiliation != value))
				{
					this.OnaffiliationChanging(value);
					this.SendPropertyChanging();
					this._affiliation = value;
					this.SendPropertyChanged("affiliation");
					this.OnaffiliationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string country
		{
			get
			{
				return this._country;
			}
			set
			{
				if ((this._country != value))
				{
					this.OncountryChanging(value);
					this.SendPropertyChanging();
					this._country = value;
					this.SendPropertyChanged("country");
					this.OncountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="VarChar(50)")]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Review", Storage="_Reviews", ThisKey="user_id", OtherKey="reviewer_id")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
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
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paper")]
	public partial class Paper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _paper_id;
		
		private string _title;
		
		private string _abstract;
		
		private string _author_id;
		
		private string _status;
		
		private EntitySet<Review> _Reviews;
		
		private EntityRef<Author> _Author;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpaper_idChanging(string value);
    partial void Onpaper_idChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnabstractChanging(string value);
    partial void OnabstractChanged();
    partial void Onauthor_idChanging(string value);
    partial void Onauthor_idChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public Paper()
		{
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			this._Author = default(EntityRef<Author>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paper_id", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string paper_id
		{
			get
			{
				return this._paper_id;
			}
			set
			{
				if ((this._paper_id != value))
				{
					this.Onpaper_idChanging(value);
					this.SendPropertyChanging();
					this._paper_id = value;
					this.SendPropertyChanged("paper_id");
					this.Onpaper_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="abstract", Storage="_abstract", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string @abstract
		{
			get
			{
				return this._abstract;
			}
			set
			{
				if ((this._abstract != value))
				{
					this.OnabstractChanging(value);
					this.SendPropertyChanging();
					this._abstract = value;
					this.SendPropertyChanged("@abstract");
					this.OnabstractChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_id", DbType="VarChar(30)")]
		public string author_id
		{
			get
			{
				return this._author_id;
			}
			set
			{
				if ((this._author_id != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onauthor_idChanging(value);
					this.SendPropertyChanging();
					this._author_id = value;
					this.SendPropertyChanged("author_id");
					this.Onauthor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paper_Review", Storage="_Reviews", ThisKey="paper_id", OtherKey="paper_id")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Paper", Storage="_Author", ThisKey="author_id", OtherKey="author_id", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.Papers.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.Papers.Add(this);
						this._author_id = value.author_id;
					}
					else
					{
						this._author_id = default(string);
					}
					this.SendPropertyChanged("Author");
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
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Paper = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Paper = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Review")]
	public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _review_id;
		
		private string _paper_id;
		
		private string _reviewer_id;
		
		private System.Nullable<int> _rating;
		
		private System.Nullable<int> _review_confident;
		
		private string _comments;
		
		private string _status;
		
		private EntityRef<Paper> _Paper;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onreview_idChanging(string value);
    partial void Onreview_idChanged();
    partial void Onpaper_idChanging(string value);
    partial void Onpaper_idChanged();
    partial void Onreviewer_idChanging(string value);
    partial void Onreviewer_idChanged();
    partial void OnratingChanging(System.Nullable<int> value);
    partial void OnratingChanged();
    partial void Onreview_confidentChanging(System.Nullable<int> value);
    partial void Onreview_confidentChanged();
    partial void OncommentsChanging(string value);
    partial void OncommentsChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public Review()
		{
			this._Paper = default(EntityRef<Paper>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_review_id", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string review_id
		{
			get
			{
				return this._review_id;
			}
			set
			{
				if ((this._review_id != value))
				{
					this.Onreview_idChanging(value);
					this.SendPropertyChanging();
					this._review_id = value;
					this.SendPropertyChanged("review_id");
					this.Onreview_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paper_id", DbType="VarChar(30)")]
		public string paper_id
		{
			get
			{
				return this._paper_id;
			}
			set
			{
				if ((this._paper_id != value))
				{
					if (this._Paper.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onpaper_idChanging(value);
					this.SendPropertyChanging();
					this._paper_id = value;
					this.SendPropertyChanged("paper_id");
					this.Onpaper_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reviewer_id", DbType="VarChar(30)")]
		public string reviewer_id
		{
			get
			{
				return this._reviewer_id;
			}
			set
			{
				if ((this._reviewer_id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onreviewer_idChanging(value);
					this.SendPropertyChanging();
					this._reviewer_id = value;
					this.SendPropertyChanged("reviewer_id");
					this.Onreviewer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rating", DbType="Int")]
		public System.Nullable<int> rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				if ((this._rating != value))
				{
					this.OnratingChanging(value);
					this.SendPropertyChanging();
					this._rating = value;
					this.SendPropertyChanged("rating");
					this.OnratingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_review_confident", DbType="Int")]
		public System.Nullable<int> review_confident
		{
			get
			{
				return this._review_confident;
			}
			set
			{
				if ((this._review_confident != value))
				{
					this.Onreview_confidentChanging(value);
					this.SendPropertyChanging();
					this._review_confident = value;
					this.SendPropertyChanged("review_confident");
					this.Onreview_confidentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comments", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				if ((this._comments != value))
				{
					this.OncommentsChanging(value);
					this.SendPropertyChanging();
					this._comments = value;
					this.SendPropertyChanged("comments");
					this.OncommentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paper_Review", Storage="_Paper", ThisKey="paper_id", OtherKey="paper_id", IsForeignKey=true)]
		public Paper Paper
		{
			get
			{
				return this._Paper.Entity;
			}
			set
			{
				Paper previousValue = this._Paper.Entity;
				if (((previousValue != value) 
							|| (this._Paper.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Paper.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._Paper.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._paper_id = value.paper_id;
					}
					else
					{
						this._paper_id = default(string);
					}
					this.SendPropertyChanged("Paper");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Review", Storage="_User", ThisKey="reviewer_id", OtherKey="user_id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._reviewer_id = value.user_id;
					}
					else
					{
						this._reviewer_id = default(string);
					}
					this.SendPropertyChanged("User");
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
