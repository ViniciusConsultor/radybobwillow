CREATE TABLE M_LOGIN_USER
(
    USERID                         NVARCHAR2(20) NOT NULL,
    COMPANYID                      NVARCHAR2(20),
    PASSWORD                       NVARCHAR2(50),
    USERNAME                       NVARCHAR2(20),
    NAMEPINYIN                     NVARCHAR2(20),
    USERTYPE                       NVARCHAR2(1),
    MAPPINGID                      NVARCHAR2(20),
    CREATEDATETIME                 TIMESTAMP(6),
    CREATEUSERID                   NVARCHAR2(20),
    UPDATEDATETIME                 TIMESTAMP(6),
    UPDATEUSERID                   NVARCHAR2(20),
    ROWUPDATEID                    NVARCHAR2(36),
    DELETEFLAG                     NVARCHAR2(1),
    PASSWORDUPDATEDATETIME         TIMESTAMP(6),
    TEMPPASSWORDFLAG               NVARCHAR2(1),
    LOCKFLAG                       NVARCHAR2(1),
    CONSTRAINT PK_LOGIN_USER_MS PRIMARY KEY (USERID) USING INDEX
        PCTFREE 10
        INITRANS 2
        MAXTRANS 255
        TABLESPACE USERS
        STORAGE(INITIAL 64K MINEXTENTS 1 MAXEXTENTS 2147483645 BUFFER_POOL DEFAULT)
        LOGGING
)
PCTFREE 10
MAXTRANS 255
TABLESPACE USERS
STORAGE(INITIAL 64K MINEXTENTS 1 MAXEXTENTS 2147483645 BUFFER_POOL DEFAULT)
NOCACHE
LOGGING
/
INSERT INTO M_LOGIN_USER values('1','01','1','rad',null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,null)
/
INSERT INTO M_LOGIN_USER values('2','01','2','ybob',null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,null)
/
INSERT INTO M_LOGIN_USER values('3','01','3','willow',null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null,null,null,to_date('0001/01/01', 'yyyy/MM/dd'),
null,null)
/
