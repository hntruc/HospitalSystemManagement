Create or replace function ban_tieptan_dieuphoi(p_schema varchar2, 
p_obj varchar2)
Return varchar2
As 
user VARCHAR2(100);
temp char(10);
nv char(10);
Begin 
    nv:= SYS_CONTEXT('userenv', 'SESSION_USER');
    IF (nv = 'ADMIN1') THEN return '1=1';
    end if;
    select nhanvien.maloai into temp from nhanvien where nv=manv;
    IF (temp='NVL05') THEN return'1=-1';
    end if;
    return user;
End;
/

declare 
    c int;
    v_object_schema         VARCHAR2(30) := 'ADMIN1';
    v_object_name           VARCHAR2(30) := 'DICHVU';
    v_policy_name           VARCHAR2(30) := 'tieptan_dieuphoi';
begin
    select count(*) into c from ALL_POLICIES where POLICY_NAME = upper('tieptan_dieuphoi') and OBJECT_NAME = upper('DICHVU');
    if c > 0 then
    BEGIN
        DBMS_RLS.DROP_POLICY(
            v_object_schema,
            v_object_name,
            v_policy_name
        );
    END;
    END IF;
end;
/

--policy khong cho tieptan dieu phoi xem gia dich vu
begin
DBMS_RLS.add_policy
(
object_schema => 'admin1',
object_name => 'DICHVU',
policy_name => 'tieptan_dieuphoi',
policy_function => 'ban_tieptan_dieuphoi',
sec_relevant_cols => 'DONGIA',
sec_relevant_cols_opt => dbms_rls.ALL_ROWS
);
end;
/

--add data nv tiep tan
--tao acc nv tiep tan
alter session set "_ORACLE_SCRIPT"=true;
create role tieptan_dieuphoi;
grant execute on admin1.DichVu_TT to tieptan_dieuphoi;

create user NV06 identified by abc;
grant tieptan_dieuphoi to NV06;
grant CREATE SESSION to NV06;

conn NV04/abc;

--select admin1.DichVu_TT from dual;
select * from admin1.DICHVU;
Select * from admin1.LOAINHANVIEN;
