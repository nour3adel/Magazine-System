--------------------------------------------------------
-- CART Table 
--------------------------------------------------------

  CREATE TABLE "CART" 
   (	"MA_ID" NUMBER, 
	"QUANTITY" NUMBER, 
	"PRICE" NUMBER(10,2), 
	"OR_ID" NUMBER, 
	"CA_ID" NUMBER
   ) ;
 

--------------------------------------------------------
--   MAGAZINE Table
--------------------------------------------------------

  CREATE TABLE "MAGAZINE" 
   (	"AUTHOR" VARCHAR2(20 BYTE), 
	"M_NO" NUMBER, 
	"CATEGORY" VARCHAR2(20 BYTE), 
	"PRICE" NUMBER, 
	"NAMEE" VARCHAR2(60 BYTE), 
	"QUANTITY" NUMBER
   ) ;

--------------------------------------------------------
--  ORDERR Table 
--------------------------------------------------------

  CREATE TABLE "ORDERR" 
   (	"O_ID" NUMBER, 
	"TOTAL" NUMBER, 
	"DATEORDER" DATE, 
	"U_ID" NUMBER
   ) ;
 
--------------------------------------------------------
--   USERR Table
--------------------------------------------------------


  CREATE TABLE "USERR" 
   (	"U_ID" NUMBER, 
	"FNAME" VARCHAR2(20 BYTE), 
	"LNAME" VARCHAR2(20 BYTE), 
	"ADDRESS" VARCHAR2(40 BYTE), 
	"USERNAME" VARCHAR2(20 BYTE), 
	"PASS" VARCHAR2(20 BYTE), 
	"ADMIN" VARCHAR2(1 BYTE), 
	"EMAIL" VARCHAR2(50 BYTE), 
	"GENDER" VARCHAR2(20 BYTE), 
	"BIO" VARCHAR2(70 BYTE)	
   );
 

---------------------------------------------------
--   DATA FOR MAGAZINE TABLE 
---------------------------------------------------

Insert into MAGAZINE (AUTHOR,M_NO,CATEGORY,PRICE,NAMEE,QUANTITY) values ('Nour',0,'Action',60,'Killing Murders',5);
Insert into MAGAZINE (AUTHOR,M_NO,CATEGORY,PRICE,NAMEE,QUANTITY) values ('Rabiee',1,'Comedy',20,'Funny',10);
Insert into MAGAZINE (AUTHOR,M_NO,CATEGORY,PRICE,NAMEE,QUANTITY) values ('Osama',2,'Action',30,'In The hell',9);
Insert into MAGAZINE (AUTHOR,M_NO,CATEGORY,PRICE,NAMEE,QUANTITY) values ('Radwa',3,'Comedy',20,'Laughing',7);
Insert into MAGAZINE (AUTHOR,M_NO,CATEGORY,PRICE,NAMEE,QUANTITY) values ('Sondos',4,'Romance',50,'in love',5);

---------------------------------------------------
--   END DATA FOR MAGAZINE TABLE 
---------------------------------------------------



---------------------------------------------------
--   DATA FOR USERR TABLE 
---------------------------------------------------

Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (0,'Nour','Adel','Obour City','nour3del','1234','y','nour3del145@gmail.com','Male','     Iam Software Engineer');
Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (1,'Ahmed','Rabiee','Cairo','rabiee','1234','n','ahmedrabiee@gmail.com','Male','    Iam Computer Science Student');
Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (2,'Ahmed','Osama','Cairo','osos','1234','n','ahmedosama@gmail.com','Male','    Iam Data Analysis');
Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (3,'Radwa','Mansour','Alex','radwa','1234','n','radwamansour@gmail.com','Female','    Iam Data Engineerin');
Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (4,'Sondos','Mohamed','Alex','sondos','1234','n','sondosmohamed@gmail.com','Female','    Iam Front End Developer');
Insert into USERR (U_ID,FNAME,LNAME,ADDRESS,USERNAME,PASS,ADMIN,EMAIL,GENDER,BIO) values (5,'admin','admin','Alex','admin','admin','y','admin@gmail.com','Male','    Iam Back End Developer');

---------------------------------------------------
--   END DATA FOR USERR TABLE 
---------------------------------------------------



---------------------------------------------------
--   DATA FOR ORDERR TABLE 
---------------------------------------------------

Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (0,180,to_timestamp('07-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),0);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (1,20,to_timestamp('06-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),0);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (2,20,to_timestamp('06-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (3,40,to_timestamp('06-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (4,200,to_timestamp('06-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (5,150,to_timestamp('07-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (6,190,to_timestamp('07-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3);
Insert into ORDERR (O_ID,TOTAL,DATEORDER,U_ID) values (7,50,to_timestamp('07-JUN-21 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3);

---------------------------------------------------
--   END DATA FOR ORDERR TABLE 
---------------------------------------------------


---------------------------------------------------
--   DATA FOR CART TABLE 
---------------------------------------------------

Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (4,3,180,8,14);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (0,1,20,0,0);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (3,2,40,1,1);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (0,1,20,2,2);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (2,3,150,3,3);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (2,1,50,3,4);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (0,2,40,4,5);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (2,1,50,4,6);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (1,2,60,4,7);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (1,3,90,5,8);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (2,2,100,5,9);
Insert into CART (MA_ID,QUANTITY,PRICE,OR_ID,CA_ID) values (2,1,50,6,10);

---------------------------------------------------
--   END DATA FOR CART TABLE 
---------------------------------------------------

--------------------------------------------------------
--  CART_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "CART_PK" ON "CART" ("CA_ID") 
  ;
--------------------------------------------------------
--   MAGAZINE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MAGAZINE_PK" ON "MAGAZINE" ("M_NO") 
  ;
--------------------------------------------------------
--    ORDERR_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ORDERR_PK" ON "ORDERR" ("O_ID") 
  ;

--------------------------------------------------------
--  Constraints for CART Table 
--------------------------------------------------------

  ALTER TABLE "CART" ADD CONSTRAINT "CART_PK" PRIMARY KEY ("CA_ID") ENABLE;
 
  ALTER TABLE "CART" MODIFY ("CA_ID" NOT NULL ENABLE);
  
--------------------------------------------------------
--  Constraints for MAGAZINE Table 
--------------------------------------------------------

  ALTER TABLE "MAGAZINE" ADD CONSTRAINT "MAGAZINE_CHK1" CHECK (
(QUANTITY >= 0)
) ENABLE;
 
  ALTER TABLE "MAGAZINE" ADD CONSTRAINT "MAGAZINE_PK" PRIMARY KEY ("M_NO") ENABLE;
 
  ALTER TABLE "MAGAZINE" MODIFY ("M_NO" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for ORDERR Table 
--------------------------------------------------------

  ALTER TABLE "ORDERR" ADD CONSTRAINT "ORDERR_PK" PRIMARY KEY ("O_ID") ENABLE;
 
  ALTER TABLE "ORDERR" MODIFY ("O_ID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for USERR Table 
--------------------------------------------------------

  ALTER TABLE "USERR" ADD CONSTRAINT "CUSTOMER_PK" PRIMARY KEY ("U_ID") ENABLE;
 
  ALTER TABLE "USERR" MODIFY ("U_ID" NOT NULL ENABLE);

--------------------------------------------------------
--  Ref Constraints for CART Table 
--------------------------------------------------------

  ALTER TABLE "CART" ADD CONSTRAINT "CART_MAGAZINE_FK1" FOREIGN KEY ("MA_ID")
	  REFERENCES "MAGAZINE" ("M_NO") ENABLE;
 
--------------------------------------------------------
--  Ref Constraints for ORDERR Table 
--------------------------------------------------------

  ALTER TABLE "ORDERR" ADD CONSTRAINT "ORDERR_USERR_FK1" FOREIGN KEY ("U_ID")
	  REFERENCES "USERR" ("U_ID") ENABLE;

--------------------------------------------------------
-- GETCRTID Procedure 
--------------------------------------------------------
CREATE OR REPLACE PROCEDURE "GETCRTID" 
(RID out number)
as
begin
select max(CA_ID)
into RID
from CART;
end;

/

--------------------------------------------------------
--  GETORDERID Procedure 
--------------------------------------------------------


  CREATE OR REPLACE PROCEDURE "GETORDERID" 
(RID out number)
as
begin
select max(O_ID)
into RID
from orderr;
end;

/


--------------------------------------------------------
--  GETP Procedure 
--------------------------------------------------------

  CREATE OR REPLACE PROCEDURE "GETP" 
(n in CHAR,m out number,p out number,q out number)
as
begin
select m_no, price , quantity
into m, p , q
from magazine
where namee= n;
end;

/

--------------------------------------------------------
--  MAGAZIN_LIST Procedure 
--------------------------------------------------------

  CREATE OR REPLACE PROCEDURE "MAGAZIN_LIST" 
(CID out sys_refcursor)
as
begin
open  CID  for select  m.namee
from   magazine m
where m.quantity > 0 ;
end;


/

--------------------------------------------------------
--  ORDER_LIST Procedure 
--------------------------------------------------------

  CREATE OR REPLACE PROCEDURE "ORDER_LIST" 
(userid in NUMBER, CID out sys_refcursor)
as
begin
open  CID  for select OO.O_ID
from    orderr OO
where OO.U_ID  = userid  ;
end;

/

--------------------------------------------------------









