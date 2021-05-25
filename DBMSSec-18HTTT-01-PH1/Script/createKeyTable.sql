declare c number:=0;
begin
select COUNT(table_name) into c
FROM
  user_tables
  where table_name='LOAIDICHVU';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.LOAIDICHVU';
    END;
END IF;
END;
/

create table admin1.LOAIDICHVU (STH VARCHAR2(8));
insert into admin1.LOAIDICHVU values ('spsecret');
