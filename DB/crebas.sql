/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     4/7/2021 7:50:54 AM                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('CANBO')
            and   type = 'U')
   drop table CANBO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DIEM')
            and   name  = 'THUOCMONHOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index DIEM.THUOCMONHOC_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DIEM')
            and   name  = 'CODIEM_FK'
            and   indid > 0
            and   indid < 255)
   drop index DIEM.CODIEM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DIEM')
            and   type = 'U')
   drop table DIEM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP')
            and   type = 'U')
   drop table LOP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MONHOC')
            and   type = 'U')
   drop table MONHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MONHOCCUALOP')
            and   name  = 'DAY_FK'
            and   indid > 0
            and   indid < 255)
   drop index MONHOCCUALOP.DAY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MONHOCCUALOP')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index MONHOCCUALOP.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MONHOCCUALOP')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MONHOCCUALOP.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MONHOCCUALOP')
            and   type = 'U')
   drop table MONHOCCUALOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'HOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.HOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINHVIEN')
            and   type = 'U')
   drop table SINHVIEN
go

/*==============================================================*/
/* Table: CANBO                                                 */
/*==============================================================*/
create table CANBO (
   MA_CB                nvarchar(10)         not null,
   TEN_CB               varchar(50)          not null,
   MK_CB                varchar(50)          not null,
   constraint PK_CANBO primary key nonclustered (MA_CB)
)
go

/*==============================================================*/
/* Table: DIEM                                                  */
/*==============================================================*/
create table DIEM (
   MA_MON               nvarchar(10)         not null,
   MA_SV                int                  not null,
   DIEM                 int                  not null,
   constraint PK_DIEM primary key nonclustered (MA_MON, MA_SV)
)
go

/*==============================================================*/
/* Index: CODIEM_FK                                             */
/*==============================================================*/
create index CODIEM_FK on DIEM (
MA_SV ASC
)
go

/*==============================================================*/
/* Index: THUOCMONHOC_FK                                        */
/*==============================================================*/
create index THUOCMONHOC_FK on DIEM (
MA_MON ASC
)
go

/*==============================================================*/
/* Table: LOP                                                   */
/*==============================================================*/
create table LOP (
   MA_LOP               nvarchar(10)         not null,
   TEN_LOP              varchar(20)          not null,
   constraint PK_LOP primary key nonclustered (MA_LOP)
)
go

/*==============================================================*/
/* Table: MONHOC                                                */
/*==============================================================*/
create table MONHOC (
   MA_MON               nvarchar(10)         not null,
   TEN_MON              varchar(50)          not null,
   constraint PK_MONHOC primary key nonclustered (MA_MON)
)
go

/*==============================================================*/
/* Table: MONHOCCUALOP                                          */
/*==============================================================*/
create table MONHOCCUALOP (
   MA_CB                nvarchar(10)         not null,
   MA_MON               nvarchar(10)         not null,
   MA_LOP               nvarchar(10)         not null,
   constraint PK_MONHOCCUALOP primary key nonclustered (MA_CB, MA_MON, MA_LOP)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on MONHOCCUALOP (
MA_LOP ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on MONHOCCUALOP (
MA_MON ASC
)
go

/*==============================================================*/
/* Index: DAY_FK                                                */
/*==============================================================*/
create index DAY_FK on MONHOCCUALOP (
MA_CB ASC
)
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN (
   MA_SV                int                  identity,
   MA_LOP               nvarchar(10)         not null,
   MSSV                 varchar(10)          not null,
   TEN_SV               varchar(50)          not null,
   constraint PK_SINHVIEN primary key nonclustered (MA_SV)
)
go

/*==============================================================*/
/* Index: HOC_FK                                                */
/*==============================================================*/
create index HOC_FK on SINHVIEN (
MA_LOP ASC
)
go

