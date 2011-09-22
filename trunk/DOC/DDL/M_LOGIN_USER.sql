--------------------------------------------------------
--  $BJ87oVa!)7z(B - $B@14|0l(B-$B6e7n(B-12-2011   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table M_LOGIN_USER
--------------------------------------------------------

  CREATE TABLE "PDM"."M_LOGIN_USER" 
   (	"USERID" NVARCHAR2(20), 
	"COMPANYID" NVARCHAR2(20), 
	"PASSWORD" NVARCHAR2(50), 
	"USERNAME" NVARCHAR2(20), 
	"NAMEPINYIN" NVARCHAR2(20), 
	"USERTYPE" NVARCHAR2(1), 
	"MAPPINGID" NVARCHAR2(20), 
	"CREATEDATETIME" TIMESTAMP (6), 
	"CREATEUSERID" NVARCHAR2(20), 
	"UPDATEDATETIME" TIMESTAMP (6), 
	"UPDATEUSERID" NVARCHAR2(20), 
	"ROWUPDATEID" NVARCHAR2(36), 
	"DELETEFLAG" NVARCHAR2(1), 
	"PASSWORDUPDATEDATETIME" TIMESTAMP (6), 
	"TEMPPASSWORDFLAG" NVARCHAR2(1), 
	"LOCKFLAG" NVARCHAR2(1)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_LOGIN_USER_MS
--------------------------------------------------------

  CREATE UNIQUE INDEX "PDM"."PK_LOGIN_USER_MS" ON "PDM"."M_LOGIN_USER" ("USERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table M_LOGIN_USER
--------------------------------------------------------

  ALTER TABLE "PDM"."M_LOGIN_USER" ADD CONSTRAINT "PK_LOGIN_USER_MS" PRIMARY KEY ("USERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "PDM"."M_LOGIN_USER" MODIFY ("USERID" NOT NULL ENABLE);