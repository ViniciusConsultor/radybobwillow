CREATE TABLE M_FUNCTIONCATALOG
(
    LANGID                         NVARCHAR2(10) NOT NULL,
    CATALOGID                      NUMBER(2,0) NOT NULL,
    CATALOGNAME                    NVARCHAR2(50),
    CATALOGIMAGE                   NVARCHAR2(50),
    CONSTRAINT T_FUNCTIONCATALOG_PK PRIMARY KEY (LANGID, CATALOGID) USING INDEX
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
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',2,'订单管理','Quotation')
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',1,'基础数据','MasterData')
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',3,'销售管理','SalesDelivery'
)
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',4,'生产计划','ManufacturePlan'
)
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',5,'生产管理','ManufactureManagement'
)
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',6,'采购管理','Purchase')
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',7,'车间管理','WorkProcess'
)
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',8,'库存管理','Inventory')
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',9,'成本管理','Cost')
/
INSERT INTO M_FUNCTIONCATALOG values('zh-CN',10,'报表中心','ReportCenter'
)
/
INSERT INTO M_FUNCTIONCATALOG values('en-US',3,'Sell Management','Sell'
)
/
INSERT INTO M_FUNCTIONCATALOG values('en-US',1,'Master Data Maintenance',
'MasterData')
/
INSERT INTO M_FUNCTIONCATALOG values('en-US',2,'Quotaion/Order','Quotation'
)
/
