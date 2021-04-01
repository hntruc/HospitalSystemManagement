    -- Xem danh sach nguoi dung trong he thong
        --SELECT * FROM dba_users; 

    -- Thong tin ve quyen cua moi user/role tren cac doi tuong du lieu
        -- user: 
        --select GRANTEE, TABLE_NAME, PRIVILEGE, TYPE from dba_tab_privs where GRANTEE ='SYSTEM'
        --role
        --select ROLE, TABLE_NAME, COLUMN_NAME, PRIVILEGE from ROLE_TAB_PRIVS WHERE ROLE = 'TEMPROLE'

alter session set "_ORACLE_SCRIPT"=true;
declare
userexist integer;
begin
  select count(*) into userexist from dba_users where username='ADMIN1';
  if (userexist = 1) then
          execute immediate 'drop user admin1 cascade'; 
  end if;
end;
/
CREATE USER admin1 IDENTIFIED BY abc;
grant dba to admin1;
grant SELECT ANY DICTIONARY to admin1;
grant create role to admin1;
grant dba to admin1;
grant drop user to admin1;
/

CREATE OR REPLACE FUNCTION checkLogin(username IN VARCHAR2)
   RETURN number
   AS
        user_name VARCHAR2(1000) := username;
        caulenh   VARCHAR2 (1000);
        check_user integer;
        check_role integer;
    BEGIN
     SELECT count(*) into check_user FROM dba_users where username =  upper(user_name);
      SELECT count(*) into check_role FROM DBA_ROLE_PRIVS WHERE GRANTEE = upper(user_name) AND GRANTED_ROLE = 'DBA';
      IF check_user = 1 and check_role = 1 THEN
        RETURN 1;
      ELSE
        RETURN 0;
     END IF;
   END;
  /
  
--declare 
--    result_ok number := 0;
--BEGIN
--    result_ok := checkLogin('phuonganh');
--    dbms_output.put_line('ook' || result_ok);
--END;

--select checkLogin('phuonganh') from dual;
--/

CREATE OR REPLACE procedure createUser(
username IN NVARCHAR2,
pass_word IN NVARCHAR2) 
AUTHID CURRENT_USER
as
user_name NVARCHAR2(1000) := username;
pwd NVARCHAR2(1000) 		:= pass_word;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE (caulenh);
    caulenh := 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pwd;
	EXECUTE IMMEDIATE ( caulenh ); 
    caulenh := 'GRANT CREATE SESSION TO ' || user_name;
	EXECUTE IMMEDIATE ( caulenh ); 
    caulenh := 'grant SELECT ANY DICTIONARY to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh ); 
    caulenh := 'grant create role to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh ); 
    caulenh := 'grant dba to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'grant drop user to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'grant alter user to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createRole TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.deleteUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createRole TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.deleteRole TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantRoleUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.revokeRoleUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantRoleUserOption TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.alterUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
END;
/

-- delete user
CREATE OR REPLACE procedure deleteUser(
username IN NVARCHAR2) 
as
user_name NVARCHAR2(1000) 		:= username;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE ( caulenh );  
    caulenh := 'drop user ' || user_name || ' cascade' ;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    CREATE OR REPLACE procedure alterUser(
username IN NVARCHAR2,
new_password IN NVARCHAR2) 
as
user_name NVARCHAR2(1000) 		:= username;
new_pwd NVARCHAR2(1000) 		:= new_password;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE ( caulenh );  
    caulenh := 'alter user ' || user_name || ' IDENTIFIED BY ' || new_pwd ;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    -- create role role_name
CREATE OR REPLACE procedure createRole(
rolename IN NVARCHAR2) 
as
role_name NVARCHAR2(1000) 		:= rolename;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE ( caulenh );  
    caulenh := 'CREATE ROLE ' || role_name ;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    -- drop role 
CREATE OR REPLACE procedure deleteRole(
rolename IN NVARCHAR2) 
as
role_name NVARCHAR2(1000) 		:= rolename;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
    EXECUTE IMMEDIATE ( caulenh );  
    caulenh := 'drop role ' || role_name;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/
    -- Cap role cho user
    CREATE OR REPLACE procedure grantRoleUser(
username IN NVARCHAR2,
rolename IN NVARCHAR2) 
authid current_user
as
user_name NVARCHAR2(1000) := username;
role_name NVARCHAR2(1000) := rolename;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'grant ' || role_name || ' to ' || user_name;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/
execute grantRoleUser('admin3','manager')

    -- Cap role cho user with grant option
CREATE OR REPLACE procedure grantRoleUserOption(
username IN NVARCHAR2,
rolename IN NVARCHAR2) 
authid current_user
as
user_name NVARCHAR2(1000) := username;
role_name NVARCHAR2(1000) := rolename;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'grant ' || role_name || ' to ' || user_name || ' with admin option';
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    --Revoke role cua user
CREATE OR REPLACE procedure revokeRoleUser(
username IN NVARCHAR2,
rolename IN NVARCHAR2) 
authid current_user
as
user_name NVARCHAR2(1000) := username;
role_name NVARCHAR2(1000) := rolename;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'revoke ' || role_name || ' from ' || user_name;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    -- Cap quyen cho user
    -- 1) grant privilege to user_name
    CREATE OR REPLACE procedure grantQuyen1(
quyen IN NVARCHAR2,
username IN NVARCHAR2) 
AUTHID CURRENT_USER
as
quyen_input NVARCHAR2(1000) := quyen;
user_name NVARCHAR2(1000) := username;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'grant ' || quyen_input || ' to ' || user_name;
	EXECUTE IMMEDIATE ( caulenh );    
END;

--conn truc/abc
--grant create table to hann
--select * from SYSTEM.SACH;
--/
--
---- 1.1) grant privilege to user_name  WITH GRANT OPTION;
--CREATE OR REPLACE procedure SYSTEM.grantQuyen1GO(
--quyen IN NVARCHAR2,
--username IN NVARCHAR2) 
--AUTHID CURRENT_USER
--as
--quyen_input NVARCHAR2(1000) := quyen;
--user_name NVARCHAR2(1000) := username;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'grant ' || quyen_input || ' to ' || user_name ||' WITH ADMIN OPTION';
--	EXECUTE IMMEDIATE ( caulenh );    
--END;
--/
--exec grantQuyenGO('create table','truc')
--conn truc/abc
--grant create table to hann
--
---- 2) grant privilege on OBJECT to user_name;
--CREATE OR REPLACE procedure grantQuyenObject(
--quyen IN NVARCHAR2,
--username IN NVARCHAR2,
--tablename IN NVARCHAR2) 
--AUTHID CURRENT_USER
--as
--quyen_input NVARCHAR2(1000) := quyen;
--user_name NVARCHAR2(1000) := username;
--table_name NVARCHAR2(1000) := tablename;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'grant ' || quyen_input || ' on SYSTEM.' || table_name || ' to ' || user_name;
--    --caulenh := 'grant ' || quyen_input || ' (' || col_name || ') ' || ' on SYSTEM.' || table_name || ' to ' || user_name;
--	EXECUTE IMMEDIATE ( caulenh );    
--END;
--/
--exec grantQuyenObject('select','truc','SACH')
--conn truc/abc
----grant select on SYSTEM.sach to hann
--
--conn hann/HANN;
--select * from SYSTEM.SACH;
--/
--
---- 2.1) grant privilege object to user_name  WITH GRANT OPTION;
--CREATE OR REPLACE procedure grantQuyenObjectGO(
--quyen IN NVARCHAR2,
--username IN NVARCHAR2,
--tablename IN NVARCHAR2) 
--AUTHID CURRENT_USER
--as
--quyen_input NVARCHAR2(1000) := quyen;
--user_name NVARCHAR2(1000) := username;
--table_name NVARCHAR2(1000) := tablename;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'grant ' || quyen_input || ' on SYSTEM.' || table_name || ' to ' || user_name ||' WITH GRANT OPTION';
--	EXECUTE IMMEDIATE ( caulenh );    
--END;
--/
--exec grantQuyenObjectGO('select','truc','SACH')
--
--    -- Cap quyen cho role
--    -- GRANT SELECT ON applog TO logreader; 
--    -- table:applog, logreader: role
--     CREATE OR REPLACE procedure grantRole(
--quyen IN NVARCHAR2,
--rolename IN NVARCHAR2) 
--AUTHID CURRENT_USER
--as
--quyen_input NVARCHAR2(1000) := quyen;
--role_name NVARCHAR2(1000) := rolename;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'grant ' || quyen_input || ' to ' || role_name;
--	EXECUTE IMMEDIATE ( caulenh );                                        
--END;
--/

--
---- Quyen select, update thi cho phep phan quyen tinh den muc cot
---- Quyen insert, delete thi khong
--
---- Cho phép thu hoi quyen user/role
--    -- 1) khong co ON object
--     --REVOKE account_admin FROM scott,debby;
--    --Revoke the account_admin role from scott and debby
--
--    --REVOKE create user, drop user FROM dba_assist;
--    --Revoke the CREATE USER and DROP USER privileges from the dba_assist role
--    CREATE OR REPLACE procedure revokeQuyenUser(
--username IN NVARCHAR2,
--quyen IN NVARCHAR2) 
--as
--user_name NVARCHAR2(1000) := username;
--quyen_input NVARCHAR2(1000) := quyen;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'revoke' || quyen_input || ' from ' || user_name;
--	EXECUTE IMMEDIATE ( caulenh );                                        
--END;
--/
--
--    -- co OBJECT on
--    --REVOKE privileges ON object FROM user; quyen tren bang, view
--     CREATE OR REPLACE procedure revokeQuyenUserObject(
--username IN NVARCHAR2,
--quyen IN NVARCHAR2,
--objectn IN NVARCHAR2) 
--as
--user_name NVARCHAR2(1000) := username;
--quyen_input NVARCHAR2(1000) := quyen;
--object_name NVARCHAR2(1000) := objectn;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'revoke' || quyen_input || ' on ' || object_name || ' from ' || user_name;
--	EXECUTE IMMEDIATE ( caulenh );                                        
--END;
--/
--   



-- Q1 FIND ALL PRIVILEGE OF SPECIFIC PERSON
--CREATE OR REPLACE procedure GET_PRIV(
--username IN NVARCHAR2) 
--authid current_user
--as
--user_name NVARCHAR2(1000) := username;
--caulenh   VARCHAR2 (1000);
--BEGIN
--    caulenh := 'SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE= '''||user_name||'''';
--	EXECUTE IMMEDIATE ( caulenh );                                        
--END;
--/
--execute GET_PRIV('admin1');
--SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'ADMIN1'

  