CREATE TABLE M_ROLE_USER
(
    ROLEID                         NUMBER(3,0) NOT NULL,
    USERID                         VARCHAR2(20) NOT NULL,
    CREATEDATETIME                 TIMESTAMP(6),
    CREATEUSERID                   VARCHAR2(20),
    UPDATEDATETIME                 TIMESTAMP(6),
    UPDATEUSERID                   VARCHAR2(20),
    CONSTRAINT M_ROLE_USER_PK PRIMARY KEY (ROLEID, USERID) USING INDEX
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
INSERT INTO M_ROLE_USER values(1,'1',to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null)
/
INSERT INTO M_ROLE_USER values(1,'2',to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null)
/
INSERT INTO M_ROLE_USER values(1,'3',to_date('0001/01/01', 'yyyy/MM/dd'),
null,to_date('0001/01/01', 'yyyy/MM/dd'),null)
/
