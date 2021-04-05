-- Tao user co quyen quan tri: 
    -- username: admin1, password: abc
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
grant drop user to admin1;
grant alter system to admin1;
/
    -- Check dang nhap
CREATE OR REPLACE FUNCTION admin1.checkLogin(username IN VARCHAR2)
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

    -- Dang xuat
 CREATE OR REPLACE procedure admin1.logOut(
username IN NVARCHAR2) 
as
type array_t is varray(30) of nvarchar2(20);
user_name NVARCHAR2(1000) 		:= username;
sid_num array_t;
sid_serial array_t;
caulenh   VARCHAR2 (1000);
BEGIN
    SELECT to_char(SID) bulk collect into sid_num from v$session where username=upper(user_name);
    SELECT to_char(SERIAL#)bulk collect into sid_serial from v$session where username=upper(user_name);
--    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
--    EXECUTE IMMEDIATE ( caulenh );  
    for i in 1..sid_num.count loop
        caulenh := 'ALTER SYSTEM KILL SESSION ''' || sid_num(i) || ',' || sid_serial(i) || '''' || ' immediate';
        EXECUTE IMMEDIATE ( caulenh );   
    end loop;
END;
/
    -- Tao user
CREATE OR REPLACE procedure admin1.createUserDBA(
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
    caulenh := 'grant alter system to ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createRole TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.createUserDBA TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.deleteUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantRoleUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.revokeRoleUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantRoleUserOption TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.alterUser TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.logOut TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantQuyenObject TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.grantQuyenObjectGO TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.revokeQuyenUserObject TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.GRANT_UPDATE TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
    caulenh := 'GRANT EXECUTE ON admin1.GRANT_UPDATE_GO TO ' || user_name;
    EXECUTE IMMEDIATE ( caulenh );
END;
/

CREATE OR REPLACE procedure admin1.createUser(
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
END;
/

    -- delete user
CREATE OR REPLACE procedure admin1.deleteUser(
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

    -- Doi password user
    CREATE OR REPLACE procedure admin1.alterUser(
username IN NVARCHAR2,
new_password IN NVARCHAR2) 
AUTHID CURRENT_USER
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

    -- Tao role
CREATE OR REPLACE procedure admin1.createRole(
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

    -- Drop role 
CREATE OR REPLACE procedure admin1.deleteRole(
rolename IN NVARCHAR2) 
as
role_name NVARCHAR2(1000) 		:= rolename;
caulenh   VARCHAR2 (1000);
BEGIN
--    caulenh := 'alter session set "_ORACLE_SCRIPT"=true';
--    EXECUTE IMMEDIATE ( caulenh );  
    caulenh := 'drop role ' || role_name;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    -- Cap role cho user
    CREATE OR REPLACE procedure admin1.grantRoleUser(
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

    -- Cap role cho user with grant option
CREATE OR REPLACE procedure admin1.grantRoleUserOption(
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
CREATE OR REPLACE procedure admin1.revokeRoleUser(
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

CREATE OR REPLACE procedure admin1.revokeQuyenUserObject(
user_name IN NVARCHAR2,
quyen_input IN NVARCHAR2,
object_name IN NVARCHAR2) 
authid current_user
as
username NVARCHAR2(1000) := user_name;
quyen NVARCHAR2(1000) := quyen_input;
object_n NVARCHAR2(1000) := object_name;
caulenh   VARCHAR2 (1000);
BEGIN
    caulenh := 'revoke ' || quyen || ' on ' || object_n || ' from ' || username;
	EXECUTE IMMEDIATE ( caulenh );                                        
END;
/

    -- Cap quyen cho user
---- 2) grant privilege on OBJECT to user_name;
CREATE OR REPLACE procedure admin1.grantQuyenObject(
username IN NVARCHAR2,
check_num IN INTEGER) 
AUTHID CURRENT_USER
as
user_name NVARCHAR2(1000) := username;
caulenh   VARCHAR2 (1000);
flag INTEGER := check_num;
BEGIN
    if flag = 1 then
        caulenh := 'grant select on admin1.BENHNHAN_NVTT_NVDPB' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );  
    elsif flag = 2 then
        caulenh := 'grant select on admin1.BENHNHAN_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 3 then
        caulenh := 'grant select on admin1.BENHNHAN_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 4 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_NVTT_DPB' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 5 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 6 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 7 then
        caulenh := 'grant select on admin1.HOSOBENHAN_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 8 then
        caulenh := 'grant select on admin1.HOSOBENHAN_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 9 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 10 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 11 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 12 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 13 then
        caulenh := 'grant select on admin1.HOSODICHVU_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 14 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 15 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 16 then
        caulenh := 'grant select on admin1.DICHVU_NVTT_DPB' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 17 then
        caulenh := 'grant select on admin1.DICHVU_NVTV' 
            || ' to ' || user_name;
    elsif flag = 18 then
        caulenh := 'grant select on admin1.DICHVU_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 19 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 20 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 21 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 22 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 23 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVQUANLYTV ' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 24 then
        caulenh := 'grant select on admin1.DONTHUOC_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 25 then
        caulenh := 'grant select on admin1.DONTHUOC_NVBT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 26 then
        caulenh := 'grant select on admin1.DONTHUOC_NVQUANLYCM ' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 27 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 28 then
        caulenh := 'grant select on admin1.THUOC_NVTT_DPB' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 29 then
        caulenh := 'grant select on admin1.THUOC_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 30 then
        caulenh := 'grant select on admin1.THUOC_NVBT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 31 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 32 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 33 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 34 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_NVBT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 35 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 36 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVBT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 37 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 38 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 39 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 40 then
        caulenh := 'grant select on admin1.BACSI_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 41 then
        caulenh := 'grant select on admin1.BACSI_NVKT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 42 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 43 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 44 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 45 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 46 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 47 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 48 then
        caulenh := 'grant select on admin1.NHANVIEN_NVTT_DPB' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 49 then
        caulenh := 'grant select on admin1.NHANVIEN_NVKT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 50 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 51 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 52 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 53 then
        caulenh := 'grant select on admin1.LICHTRUC_BACSI' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 54 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 55 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 56 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 57 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 58 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 59 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYTNNS' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 60 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVKT' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 61 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYCM' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 62 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYTV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 63 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVDV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 64 then
        caulenh := 'grant select on admin1.DICHVUG_NVDV' 
            || ' to ' || user_name;
        EXECUTE IMMEDIATE ( caulenh );
    end if;
END;
/

CREATE OR REPLACE procedure admin1.grantQuyenObjectGO(
username IN NVARCHAR2,
check_num IN INTEGER) 
AUTHID CURRENT_USER
as
user_name NVARCHAR2(1000) := username;
caulenh   VARCHAR2 (1000);
flag INTEGER := check_num;
BEGIN
    if flag = 1 then
        caulenh := 'grant select on admin1.BENHNHAN_NVTT_NVDPB' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );  
    elsif flag = 2 then
        caulenh := 'grant select on admin1.BENHNHAN_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 3 then
        caulenh := 'grant select on admin1.BENHNHAN_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 4 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_NVTT_DPB' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 5 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 6 then
        caulenh := 'grant select on admin1.TRIEUCHUNGBANDAU_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 7 then
        caulenh := 'grant select on admin1.HOSOBENHAN_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 8 then
        caulenh := 'grant select on admin1.HOSOBENHAN_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 9 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 10 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 11 then
        caulenh := 'grant select on admin1.HOADONKHAMBENH_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 12 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 13 then
        caulenh := 'grant select on admin1.HOSODICHVU_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 14 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 15 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 16 then
        caulenh := 'grant select on admin1.DICHVU_NVTT_DPB' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 17 then
        caulenh := 'grant select on admin1.DICHVU_NVTV' 
            || ' to ' || user_name || ' with grant option ';
    elsif flag = 18 then
        caulenh := 'grant select on admin1.DICHVU_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 19 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 20 then
        caulenh := 'grant select on admin1.DICHVU_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 21 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 22 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 23 then
        caulenh := 'grant select on admin1.HOADONDICHVU_NVQUANLYTV ' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 24 then
        caulenh := 'grant select on admin1.DONTHUOC_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 25 then
        caulenh := 'grant select on admin1.DONTHUOC_NVBT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 26 then
        caulenh := 'grant select on admin1.DONTHUOC_NVQUANLYCM ' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 27 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 28 then
        caulenh := 'grant select on admin1.THUOC_NVTT_DPB' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 29 then
        caulenh := 'grant select on admin1.THUOC_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 30 then
        caulenh := 'grant select on admin1.THUOC_NVBT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 31 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 32 then
        caulenh := 'grant select on admin1.THUOC_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 33 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 34 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_NVBT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 35 then
        caulenh := 'grant select on admin1.CHITIETDONTHUOC_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 36 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVBT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 37 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 38 then
        caulenh := 'grant select on admin1.HOADONTHUOC_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 39 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 40 then
        caulenh := 'grant select on admin1.BACSI_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 41 then
        caulenh := 'grant select on admin1.BACSI_NVKT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 42 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 43 then
        caulenh := 'grant select on admin1.BACSI_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 44 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 45 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 46 then
        caulenh := 'grant select on admin1.KHOA_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 47 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 48 then
        caulenh := 'grant select on admin1.NHANVIEN_NVTT_DPB' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 49 then
        caulenh := 'grant select on admin1.NHANVIEN_NVKT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 50 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 51 then
        caulenh := 'grant select on admin1.NHANVIEN_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 52 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 53 then
        caulenh := 'grant select on admin1.LICHTRUC_BACSI' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 54 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 55 then
        caulenh := 'grant select on admin1.LICHTRUC_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 56 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
     elsif flag = 57 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 58 then
        caulenh := 'grant select on admin1.LOAINHANVIEN_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 59 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYTNNS' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 60 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVKT' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 61 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYCM' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 62 then
        caulenh := 'grant select on admin1.BANGCHAMCONG_NVQUANLYTV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 63 then
        caulenh := 'grant select on admin1.HOSODICHVU_NVDV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    elsif flag = 64 then
        caulenh := 'grant select on admin1.DICHVUG_NVDV' 
            || ' to ' || user_name || ' with grant option ';
        EXECUTE IMMEDIATE ( caulenh );
    end if;
END;
/

    -- Object with no grant option
     CREATE OR REPLACE PROCEDURE admin1.GRANT_UPDATE(FLAG NUMBER, USER_ROLE VARCHAR2)
AS
    COMMAND VARCHAR2(100);
BEGIN
    IF (FLAG=1) THEN
        COMMAND := 'Grant update, select on admin1.BENHNHAN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=2) THEN
        COMMAND := 'Grant update, select on admin1.TRIEUCHUNGBANDAU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=3) THEN
        COMMAND := 'Grant update, select on admin1.HOSOBENHAN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=4) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN), select on admin1.HOADONKHAMBENH';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=5) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN),select on admin1.HOADONKHAMBENH';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=6) THEN
        COMMAND := 'GRANT UPDATE (KETLUAN),select on admin1.HOSODICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=7) THEN
        COMMAND := 'GRANT UPDATE (DONGIA), select on admin1.DICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=8) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN), select on admin1.HOADONDICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=9) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN), select on admin1.HOADONDICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=10) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.DONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=11) THEN
        COMMAND := 'GRANT UPDATE (GIATIEN), select on admin1.THUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=12) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.CHITIETDONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=13) THEN
        COMMAND := 'GRANT UPDATE on admin1.(TONGTIEN), select on admin1.HOADONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=14) THEN
        COMMAND := 'GRANT UPDATE on admin1.(TONGTIEN), select on admin1.HOADONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=15) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=16) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN), select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=17) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN), select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=18) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.KHOA TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=19) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=20) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN), select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=21) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN), select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=22) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.LICHTRUC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=23) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.LOAINHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    ELSIF (FLAG=24) THEN
        COMMAND := 'GRANT UPDATE, select on admin1.BANGCHAMCONG TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE;
    END IF;
END;
/

    -- Object with grant option
    CREATE OR REPLACE PROCEDURE admin1.GRANT_UPDATE_GO(FLAG NUMBER, USER_ROLE VARCHAR2)
AS
    COMMAND VARCHAR2(100);
BEGIN
    IF (FLAG=1) THEN
        COMMAND := 'Grant update , select on admin1.BENHNHAN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE || ' WITH GRANT OPTION';
    ELSIF (FLAG=2) THEN
        COMMAND := 'Grant update , select on admin1.TRIEUCHUNGBANDAU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=3) THEN
        COMMAND := 'Grant update , select on admin1.HOSOBENHAN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=4) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN), select on admin1.HOADONKHAMBENH TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=5) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN), select on admin1.HOADONKHAMBENH TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=6) THEN
        COMMAND := 'GRANT UPDATE (KETLUAN) , select on admin1.HOSODICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=7) THEN
        COMMAND := 'GRANT UPDATE (DONGIA) , select on admin1.DICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=8) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN) , select on admin1.HOADONDICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=9) THEN
        COMMAND := 'GRANT UPDATE (TONGTIEN) , select on admin1.HOADONDICHVU TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=10) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.DONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=11) THEN
        COMMAND := 'GRANT UPDATE (GIATIEN) , select on admin1.THUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=12) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.CHITIETDONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=13) THEN
        COMMAND := 'GRANT UPDATE on admin1.(TONGTIEN) , select on admin1.HOADONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=14) THEN
        COMMAND := 'GRANT UPDATE  on admin1.(TONGTIEN) , select on admin1.HOADONTHUOC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=15) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=16) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN) , select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=17) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN) , select on admin1.BACSI TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=18) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.KHOA TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE || ' WITH GRANT OPTION';
    ELSIF (FLAG=19) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=20) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN) , select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=21) THEN
        COMMAND := 'GRANT UPDATE (PHUCAP, LUONGCOBAN) , select on admin1.NHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=22) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.LICHTRUC TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=23) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.LOAINHANVIEN TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    ELSIF (FLAG=24) THEN
        COMMAND := 'GRANT UPDATE , select on admin1.BANGCHAMCONG TO ';
        EXECUTE IMMEDIATE COMMAND || USER_ROLE|| ' WITH GRANT OPTION';
    END IF;
END;
/