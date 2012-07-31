CREATE TABLE M_FUNCTION
(
    LANGID                         NVARCHAR2(10) NOT NULL,
    FUNCTIONID                     NUMBER(3,0) NOT NULL,
    FUNCTIONNAME                   NVARCHAR2(100),
    FUNCTIONPATH                   NVARCHAR2(100),
    CATALOGID                      NUMBER(2,0) NOT NULL,
    FUNCTIONINDEX                  NUMBER(4,0),
    FUNCTIONIMAGE                  NVARCHAR2(50),
    CONSTRAINT M_FUNCTION_PK PRIMARY KEY (LANGID, FUNCTIONID) USING INDEX
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
INSERT INTO M_FUNCTION values('zh-CN',22,'报价单查询','FQuotationInquiry',
2,2,'QuotationInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',23,'订单输入','FOrderEntry',2,3,'OrderEntry'
)
/
INSERT INTO M_FUNCTION values('zh-CN',24,'订单查询','FOrderInquiry',2,4,
'OrderInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',1,'系统参数设置','FSystemParameter',
1,1,'SystemParameter')
/
INSERT INTO M_FUNCTION values('zh-CN',2,'日历设置','FCalendar',1,2,'Calendar'
)
/
INSERT INTO M_FUNCTION values('zh-CN',3,'企业数据维护','FCompany',1,3,'CompanyData'
)
/
INSERT INTO M_FUNCTION values('zh-CN',5,'客户管理','FCustomer',1,5,'Customer'
)
/
INSERT INTO M_FUNCTION values('zh-CN',6,'物料管理','FMaterial',1,6,'Material'
)
/
INSERT INTO M_FUNCTION values('zh-CN',7,'产品构成设置','FComposition',1,
7,'Composition')
/
INSERT INTO M_FUNCTION values('zh-CN',8,'物料清单','FBom',1,8,'Bom')
/
INSERT INTO M_FUNCTION values('zh-CN',9,'物料单价','FMaterialPrice',1,9,
'MaterialPrice')
/
INSERT INTO M_FUNCTION values('zh-CN',19,'用户管理','FUser',1,19,'User'
)
/
INSERT INTO M_FUNCTION values('zh-CN',10,'单位管理','FUnit',1,10,'Unit'
)
/
INSERT INTO M_FUNCTION values('zh-CN',20,'用户角色管理','FRole',1,20,'Role'
)
/
INSERT INTO M_FUNCTION values('zh-CN',4,'工厂管理','FFactory',1,4,'Factory'
)
/
INSERT INTO M_FUNCTION values('zh-CN',15,'货币管理','FCurrency',1,15,'Currency'
)
/
INSERT INTO M_FUNCTION values('zh-CN',16,'汇率管理','FExchangeRate',1,16,
'ExchangeRate')
/
INSERT INTO M_FUNCTION values('zh-CN',11,'物料客户代码设置','FCustomerMaterial',
1,11,'CustomerMaterial')
/
INSERT INTO M_FUNCTION values('zh-CN',12,'仓库/工序设置','FWarehouseProcess',
1,12,'WarehouseProcess')
/
INSERT INTO M_FUNCTION values('zh-CN',13,'工序设备设置','FProcessEquipment',
1,13,'ProcessEquipment')
/
INSERT INTO M_FUNCTION values('zh-CN',14,'部门管理','FDepartment',1,14,
'Department')
/
INSERT INTO M_FUNCTION values('zh-CN',17,'会计科目设置','FAccountItem',
1,17,'AccountItem')
/
INSERT INTO M_FUNCTION values('zh-CN',18,'产品构成检查','FCompositionCheck',
1,18,'CompositionCheck')
/
INSERT INTO M_FUNCTION values('zh-CN',21,'报价单输入','FQuotationEntry',
2,1,'QuotationEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',25,'出货输入','FDeliveryEntry',3,
1,'DeliveryEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',26,'退货输入','FReturnEntry',3,2,
'ReturnEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',27,'销售实绩输入','FSalesResultEntry',
3,3,'SalesResultEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',28,'出货实绩输入','FDeliveryResultInquiry',
3,4,'DeliveryResultInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',29,'出货单打印','FDeliveryReceiptPrint',
3,5,'DeliveryReceiptPrint')
/
INSERT INTO M_FUNCTION values('zh-CN',30,'生产计划输入','FManufacturePlanEntry',
4,1,'ManufacturePlanEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',31,'制造批次输入','FManufactureBatchEntry',
4,2,'ManufactureBatchEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',32,'生产计划查询','FManufacturePlanInquiry',
4,3,'ManufacturePlanInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',33,'前景生产计划输入','FProspectManufacturePlanEntry',
4,4,'ProspectManufacturePlanEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',34,'采购补货查询','FProcurementReplenishmentInquiry',
5,1,'PurchaseReplenishmentInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',35,'生产指示输入','FManufactureInstructionEntry',
5,2,'ManufactureInstructionEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',36,'生产指示剩余查询','FManufactureInstructionRemainInquiry',
5,3,'ManufactureInstructionRemainInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',37,'制造批次生产指示输入','FManufactureBatchInstructionEntry',
5,4,'ManufactureBatchInstructionEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',38,'制造批次指示查询','FManufactureBatchInstructionInquiry',
5,5,'ManufactureBatchInstructionInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',39,'制造批次生产过程告警查询','FManufactureBatchProcessAlertInquiry',
5,6,'ManufactureBatchProcessAlertInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',40,'需求量计算','FDemandCompute',
5,7,'DemandCompute')
/
INSERT INTO M_FUNCTION values('zh-CN',41,'生产指示实行','FManufactureInstructionExecute',
5,8,'ManufactureInstructionExecute')
/
INSERT INTO M_FUNCTION values('zh-CN',42,'前景需求量计算','FProspectDemandCompute',
5,9,'ProspectDemandCompute')
/
INSERT INTO M_FUNCTION values('zh-CN',44,'库存移动输入','FInventoryMove',
6,1,'InventoryMove')
/
INSERT INTO M_FUNCTION values('zh-CN',45,'生产指示配货输入','FManufactureInstructionPickingEntry',
6,2,'ManufactureInstructionPickingEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',46,'入库输入','FReceiptEntry',6,3,
'ReceiptEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',47,'入库品检输入','FReceiptQualityInspectionEntry',
6,4,'ReceiptQualityInspectionEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',48,'计划外入库输入','FUnplanedStorageEntry',
6,5,'UnplanedReceiptEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',49,'入库实绩查询','FReceiptResultInquiry',
6,6,'ReceiptResultInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',50,'采购单','FProcurementOrder',6,
7,'PurchaseOrder')
/
INSERT INTO M_FUNCTION values('zh-CN',51,'配货预计/配货清单','FPickingEstimatePickingList',
6,8,'PickingEstimatePickingList')
/
INSERT INTO M_FUNCTION values('zh-CN',52,'配货详细','FPickingDetails',6,
9,'PickingDetails')
/
INSERT INTO M_FUNCTION values('zh-CN',53,'入库品检报告','FReceiptQualityInspectionReport',
6,10,'ReceiptQualityInspectionReport')
/
INSERT INTO M_FUNCTION values('zh-CN',54,'生产实绩输入','FManufactureResultEntry',
7,1,'ManufactureResultEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',55,'生产工作票','FManufactureOrder',
7,2,'ManufactureOrder')
/
INSERT INTO M_FUNCTION values('zh-CN',56,'物料库存查询','FMaterialInventoryInquiry',
8,1,'MaterialInventoryInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',57,'预计库存查询','FEstimateInventoryInquiry',
8,2,'EstimateInventoryInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',58,'库存调整输入','FInventoryAdjustmentEntry',
8,3,'InventoryAdjustmentEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',59,'入出库查询','FReceiptPickingInquiry',
8,4,'ReceiptPickingInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',60,'盘点设置','FInventoryCheckSetting',
8,5,'InventoryCheckSetting')
/
INSERT INTO M_FUNCTION values('zh-CN',61,'盘点输入','FInventoryCheckEntry',
8,6,'InventoryCheckEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',62,'批次跟踪查询','FLotTraceInquiry',
8,7,'LotTraceInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',63,'盘点指示表','FInventoryInstructionReport',
8,8,'InventoryInstructionReport')
/
INSERT INTO M_FUNCTION values('zh-CN',64,'盘点过剩表','FInventoryExcessReport',
8,9,'InventoryExcessReport')
/
INSERT INTO M_FUNCTION values('zh-CN',65,'盘点资产表','FInventoryAssetsReprot',
8,10,'InventoryAssetsReprot')
/
INSERT INTO M_FUNCTION values('en-US',1,'Company Data','FCompany',1,1,'CompanyData'
)
/
INSERT INTO M_FUNCTION values('en-US',2,'Calandar','FCalendar',1,2,'Calendar'
)
/
INSERT INTO M_FUNCTION values('en-US',3,'Quote Input','FQuotationEntry',
2,1,'QuotationEntry')
/
INSERT INTO M_FUNCTION values('en-US',4,'Quote Search','FQuotationInquiry',
2,2,'QuotationSearch')
/
INSERT INTO M_FUNCTION values('en-US',5,'Material','FMaterial',1,3,'Material'
)
/
INSERT INTO M_FUNCTION values('zh-CN',66,'盘点差异表','FInventoryDifferenceReport',
8,11,'InventoryDifferenceReport')
/
INSERT INTO M_FUNCTION values('zh-CN',67,'库存月度结转','FInventoryMonthlyCarryOver',
8,12,'InventoryMonthlyCarryOver')
/
INSERT INTO M_FUNCTION values('zh-CN',68,'盘点信息表','FInventoryInformation',
8,13,'InventoryInformation')
/
INSERT INTO M_FUNCTION values('zh-CN',69,'盘点更新','FInventoryUpdate',
8,14,'InventoryUpdate')
/
INSERT INTO M_FUNCTION values('zh-CN',70,'业绩预算输入','FAchievementBudgetEntry',
9,1,'AchievementBudgetEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',71,'制造批次成本查询','FManufactureBatchCostInquiry',
9,2,'ManufactureBatchCostInquiry')
/
INSERT INTO M_FUNCTION values('zh-CN',74,'工作票输入','FWorkSheetEntry',
9,3,'WorkSheetEntry')
/
INSERT INTO M_FUNCTION values('zh-CN',75,'工作票查询','FWorksheetInquiry',
9,4,'WorkSheetInquiry')
/
