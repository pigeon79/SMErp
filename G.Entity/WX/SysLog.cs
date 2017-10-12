//using System;
//using System.Data;
//using G.Data;

//namespace G.Entity
//{
	
//    [TableMap("SysLog","ID")]
//    [EntityInclude(typeof(Schdule))]
//    public abstract class SysLog : PersistenceCapable
//    {
//        #region Properties
//        [ColumnMap("GUID",DbType.String,"")]
//        public abstract string GUID{get;set;}		
		
//        [ColumnMap("UserID",DbType.String,"")]
//        public abstract string UserID{get;set;}		
		
//        [ColumnMap("ClassName",DbType.String,"")]
//        public abstract string ClassName{get;set;}		
		
//        [ColumnMap("MethodName",DbType.String,"")]
//        public abstract string MethodName{get;set;}		
		
//        [ColumnMap("CallTime",DbType.DateTime)]
//        public abstract DateTime CallTime{get;set;}		

//        #endregion
		
//        #region Implemetion of PersistenceCapable 
////		public abstract EntityData EntityData{get;set;}

//        #endregion
//    }		
				
//}