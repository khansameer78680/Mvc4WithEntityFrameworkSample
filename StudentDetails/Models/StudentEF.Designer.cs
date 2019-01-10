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
namespace StudentDetails.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class StudentDBContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new StudentDBContext object using the connection string found in the 'StudentDBContext' section of the application configuration file.
        /// </summary>
        public StudentDBContext() : base("name=StudentDBContext", "StudentDBContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentDBContext object.
        /// </summary>
        public StudentDBContext(string connectionString) : base(connectionString, "StudentDBContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentDBContext object.
        /// </summary>
        public StudentDBContext(EntityConnection connection) : base(connection, "StudentDBContext")
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
        public ObjectSet<StudentDetail> StudentDetails
        {
            get
            {
                if ((_StudentDetails == null))
                {
                    _StudentDetails = base.CreateObjectSet<StudentDetail>("StudentDetails");
                }
                return _StudentDetails;
            }
        }
        private ObjectSet<StudentDetail> _StudentDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the StudentDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudentDetails(StudentDetail studentDetail)
        {
            base.AddObject("StudentDetails", studentDetail);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Models", Name="StudentDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class StudentDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new StudentDetail object.
        /// </summary>
        /// <param name="studentId">Initial value of the StudentId property.</param>
        /// <param name="studentName">Initial value of the StudentName property.</param>
        /// <param name="english">Initial value of the English property.</param>
        /// <param name="science">Initial value of the Science property.</param>
        /// <param name="computer">Initial value of the Computer property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        public static StudentDetail CreateStudentDetail(global::System.Int32 studentId, global::System.String studentName, global::System.Int32 english, global::System.Int32 science, global::System.Int32 computer, global::System.Int32 year)
        {
            StudentDetail studentDetail = new StudentDetail();
            studentDetail.StudentId = studentId;
            studentDetail.StudentName = studentName;
            studentDetail.English = english;
            studentDetail.Science = science;
            studentDetail.Computer = computer;
            studentDetail.Year = year;
            return studentDetail;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                if (_StudentId != value)
                {
                    OnStudentIdChanging(value);
                    ReportPropertyChanging("StudentId");
                    _StudentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("StudentId");
                    OnStudentIdChanged();
                }
            }
        }
        private global::System.Int32 _StudentId;
        partial void OnStudentIdChanging(global::System.Int32 value);
        partial void OnStudentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 English
        {
            get
            {
                return _English;
            }
            set
            {
                OnEnglishChanging(value);
                ReportPropertyChanging("English");
                _English = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("English");
                OnEnglishChanged();
            }
        }
        private global::System.Int32 _English;
        partial void OnEnglishChanging(global::System.Int32 value);
        partial void OnEnglishChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Science
        {
            get
            {
                return _Science;
            }
            set
            {
                OnScienceChanging(value);
                ReportPropertyChanging("Science");
                _Science = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Science");
                OnScienceChanged();
            }
        }
        private global::System.Int32 _Science;
        partial void OnScienceChanging(global::System.Int32 value);
        partial void OnScienceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Computer
        {
            get
            {
                return _Computer;
            }
            set
            {
                OnComputerChanging(value);
                ReportPropertyChanging("Computer");
                _Computer = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Computer");
                OnComputerChanged();
            }
        }
        private global::System.Int32 _Computer;
        partial void OnComputerChanging(global::System.Int32 value);
        partial void OnComputerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        #endregion

    
    }

    #endregion

    
}