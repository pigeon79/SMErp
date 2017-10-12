//using System;
//using System.Data;
//using G.DataCore.Base;
	
//namespace G.Entity
//{
//    [TableMap("Schdule","GUID")]	
//    [EntityInclude(typeof(Schdule))]
//    public abstract class Schdule : PersistenceCapable
//    {
//        [ColumnMap("GUID",DbType.String,"")]
//        public abstract string GUID{get;set;}		
		
//        [ColumnMap("UserID",DbType.String,"")]
//        public abstract string UserID{get;set;}		
		
//        [ColumnMap("StartTime",DbType.DateTime)]
//        public abstract DateTime StartTime{get;set;}		
		
//        [ColumnMap("EndTime",DbType.DateTime)]
//        public abstract DateTime EndTime{get;set;}		
		
//        [ColumnMap("Title",DbType.String,"")]
//        public abstract string Title{get;set;}		
		
//        [ColumnMap("Description",DbType.String,"")]
//        public abstract string Description{get;set;}		
		
//        [ColumnMap("RemidTime",DbType.DateTime)]
//        public abstract DateTime RemidTime{get;set;}		
		
//        [ColumnMap("AddTime",DbType.DateTime)]
//        public abstract DateTime AddTime{get;set;}		
		
//        [ColumnMap("Status",DbType.Int16,0)]
//        public abstract short Status{get;set;}		
//    }		
				
//}




