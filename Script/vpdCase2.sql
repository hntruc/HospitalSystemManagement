declare 
    c int;
    v_object_schema         VARCHAR2(30) := 'ADMIN1';
    v_object_name           VARCHAR2(30) := 'HOSOBENHAN';
    v_policy_name           VARCHAR2(30) := 'BACSI_BENHAN';
begin
    select count(*) into c from ALL_POLICIES where POLICY_NAME = 'BACSI_BENHAN' and OBJECT_NAME = upper('HOSOBENHAN');
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

CREATE OR REPLACE FUNCTION BACSI_BENHAN_FUNC(p_schema varchar2, p_obj varchar2)
return varchar2
as 
    CUR_USER VARCHAR2(100);
    CHECK_USER VARCHAR2(100);
    RETURN_VAL VARCHAR2(1000);
begin
    CUR_USER:= sys_context('userenv','session_user');
    CHECK_USER:= SUBSTR(CUR_USER,1,2);
    if (CHECK_USER = 'BS') then
        return '''' || sys_context('userenv','session_user') || ''' = mabs';
    elsIF (CUR_USER = 'ADMIN1') THEN 
        return '1=1';
    end if;
end;
/

BEGIN
    dbms_rls.add_policy (
    object_schema => 'admin1',
    object_name => 'HOSOBENHAN',
    policy_name => 'BACSI_BENHAN',
    policy_function => 'BACSI_BENHAN_FUNC',
    statement_types => 'SELECT, UPDATE',
    update_check => TRUE);
END;
/



    
