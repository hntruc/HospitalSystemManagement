--DROP CONSTRAINT
-- TRIEUCHUNGBANDAU  FK
declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.TRIEUCHUNGBANDAU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.TRIEUCHUNGBANDAU  DROP CONSTRAINT FK_TRIEUCHUNGBANDAU_BENHNHAN';
    END;
END IF;
END;
/


--HOSOBENHAN FK
declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.HOSOBENHAN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSOBENHAN DROP CONSTRAINT FK_HOSOBENHAN_BACSI';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSOBENHAN DROP CONSTRAINT FK_HOSOBENHAN_BENHNHAN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.BANGCHAMCONG';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'alter table admin1.BANGCHAMCONG drop CONSTRAINT FK_CHAMCONG_NHANVIEN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.CHITIETDONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.CHITIETDONTHUOC DROP CONSTRAINT FK_CHITIETDONTHUOC_THUOC';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.CHITIETDONTHUOC DROP CONSTRAINT FK_CHITIETDONTHUOC_DONTHUOC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.NHANVIEN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.NHANVIEN drop CONSTRAINT FK_NHANVIEN_LOAI';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.LICHTRUC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.LICHTRUC drop CONSTRAINT FK_LICHTRUC_BACSI';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.BACSI';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER admin1.TABLE BACSI drop CONSTRAINT FK_BACSI_KHOA';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.HOADONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONTHUOC drop CONSTRAINT FK_HOADONTHUOC_NHANVIEN';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONTHUOC drop CONSTRAINT FK_HOADONTHUOC_DONTHUOC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.DONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.DONTHUOC drop CONSTRAINT FK_DONTHUOC_BENHNHAN';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.DONTHUOC DROP CONSTRAINT FK_DONTHUOC_BACSI';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.HOADONDICHVU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONDICHVU drop CONSTRAINT FK_HOADONDICHVU_BENHNHAN';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONDICHVU drop CONSTRAINT FK_HOADONDICHVU_NHANVIEN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.HOSODICHVU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSODICHVU drop CONSTRAINT FK_HOSODICHVU_NHANVIEN';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSODICHVU drop CONSTRAINT FK_HOSODICHVU_DICHVU';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSODICHVU drop CONSTRAINT FK_HOSODICHVU_HOADONDICHVU';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='R' AND TABLE_NAME='admin1.HOADONKHAMBENH';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONKHAMBENH drop CONSTRAINT FK_HOADONKHAMBENH_BENHNHAN';
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONKHAMBENH drop CONSTRAINT FK_HOADONKHAMBENH_NHANVIEN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.NHANVIEN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.NHANVIEN drop CONSTRAINT PK_NHANVIEN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.CHITIETDONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.CHITIETDONTHUOC DROP CONSTRAINT PK_CHITIETDONTHUOC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.LICHTRUC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.LICHTRUC drop CONSTRAINT PK_LICHTRUC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.BACSI';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.BACSI drop CONSTRAINT PK_BACSI';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.HOADONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONTHUOC drop CONSTRAINT PK_HOADONTHUOC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.DONTHUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.DONTHUOC DROP CONSTRAINT PK_DONTHUOC';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.HOADONDICHVU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONDICHVU drop CONSTRAINT PK_HOADONDV';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.HOSODICHVU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSODICHVU drop CONSTRAINT PK_HOSODV';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.HOADONKHAMBENH';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOADONKHAMBENH drop CONSTRAINT PK_HOADONKB';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.KHOA';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.KHOA drop CONSTRAINT PK_KHOA';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.BENHNHAN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.BENHNHAN drop CONSTRAINT PK_BN';
    END;
END IF;
END;
/


declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.THUOC';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.THUOC DROP CONSTRAINT PK_THUOC';
    END;
END IF;
END;
/


declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.BANGCHAMCONG';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'alter table admin1.BANGCHAMCONG drop CONSTRAINT PK_BANGCHAMCONG';
    END;
END IF;
END;
/


declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.TRIEUCHUNGBANDAU';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.TRIEUCHUNGBANDAU  DROP CONSTRAINT PK_TRIEUCHUNG';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.HOSOBENHAN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.HOSOBENHAN DROP CONSTRAINT PK_HOSOBN';
    END;
END IF;
END;
/

declare c number;
begin
SELECT COUNT(CONSTRAINT_NAME) INTO C FROM USER_CONSTRAINTS WHERE CONSTRAINT_TYPE ='P' AND TABLE_NAME='admin1.LOAINHANVIEN';
  if c>0 THEN 
    BEGIN
        EXECUTE IMMEDIATE 'ALTER TABLE admin1.LOAINHANVIEN drop CONSTRAINT PK_LOAINV';
    END;
END IF;
END;
/


--DROP TABLE
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
  user_tables
  where table_name='admin1.BENHNHAN';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.BENHNHAN';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
  user_tables
  where table_name='admin1.TRIEUCHUNGBANDAU';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.TRIEUCHUNGBANDAU';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
  user_tables
  where table_name='admin1.HOSOBENHAN';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.HOSOBENHAN';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.HOADONKHAMBENH';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.HOADONKHAMBENH';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.HOSODICHVU';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.HOSODICHVU';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.DICHVU';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.DICHVU';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.HOADONDICHVU';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.HOADONDICHVU';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.DONTHUOC';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.DONTHUOC';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.THUOC';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.THUOC';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.HOADONTHUOC';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.HOADONTHUOC ';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.BACSI';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.BACSI';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.KHOA';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.KHOA';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.NHANVIEN';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.NHANVIEN';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.LICHTRUC';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.LICHTRUC';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.LOAINHANVIEN';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.LOAINHANVIEN';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.BANGCHAMCONG';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.BANGCHAMCONG';
    END;
END IF;
END;
/
declare c number:=0;
begin
select COUNT(table_name) into c
FROM
   user_tables
  where table_name='admin1.CHITIETDONTHUOC';
  if c>0 THEN 
    BEGIN
        execute immediate 'drop table admin1.CHITIETDONTHUOC';
    END;
END IF;
END;
/

--------------------------
create table admin1.BENHNHAN
(
    makb char(10),
    ten nvarchar2(50),
    namsinh date,
    diachi nvarchar2(50),
    SDT int,
    constraint pk_BN primary key(MAKB)
);
create table admin1.TRIEUCHUNGBANDAU
(
    maKB char(10),
	STT SMALLINT,
    trieuchungbenh nvarchar2(100),
    ngaygio date,
    constraint pk_trieuchung primary key(maKB,STT)
);
create table admin1.HOSOBENHAN
(
    MAKB char(10),
	STT SMALLINT,
    ngay date,
    MABS char(10),
    TRIEUCHUNG nvarchar2(50),
    ketluan varchar(50),
    constraint pk_hosoBN primary key(MAKB,STT)
);
create table admin1.HOADONKHAMBENH
(
    MaHDKB char(10),
    MaKB char(10),
    manv char(10),
	tongtien int,
    constraint pk_hoadonKB primary key(MaHDKB)
);
create table admin1.HOSODICHVU
(
    MAHDDV char(10),
	MADV CHAR(10),
    ngaygio date,
    manv char(10),
    ketluan nvarchar2(50),
    constraint pk_hosoDV primary key(MAHDDV, madv)
);
create table admin1.DICHVU
(
    madv char(10),
    tendv nvarchar2(50),
    dongia int,
    constraint pk_DV primary key(madv)
);
create table admin1.HOADONDICHVU
(
    MaHDDV char(10),
    MAKB char(10),
    --madv char(10),
    tongtien int,
    manv char(10),
    ngaygio date,
    constraint pk_hoadonDV primary key(MaHDDV)
);
create table admin1.DONTHUOC
(
    MADT char(10),
    MAKB char(10),
    MABS char(10),
    dando nvarchar2(50),
    ngaygio date,
    constraint pk_donthuoc primary key(MADT)
);
create table admin1.THUOC
(
    mathuoc char(10),
    tenthuoc nvarchar2(50),
    loaithuoc char(10),
    donvi nvarchar2(20),
    giatien int,
    soluongton int,
    constraint pk_thuoc primary key(mathuoc)
);

CREATE TABLE admin1.CHITIETDONTHUOC
(
    MADT CHAR(10),
	MATHUOC CHAR(10),
	SOLUONG INT,
	DONVI NVARCHAR2(20),
	DANDO NVARCHAR2(50),
    constraint pk_CHITIETDONTHUOC primary key(MADT, MATHUOC)
);

create table admin1.HOADONTHUOC
(
    MaHDT char(10),
    ngaygio date,
    manv char(10),
    tongtien int,
	MADT CHAR(10),
    constraint pk_hoadonthuoc primary key(MaHDT)
);
create table admin1.BACSI
(
    MABS char(10),
    tenbs nvarchar2(50),
    phucap int,
    MACK char(10),
    luongcoban int,
    constraint pk_bacsi primary key(maBS)
);
create table admin1.KHOA 
(
    makhoa char(10),
    tenkhoa nvarchar2(50),
    constraint pk_khoa primary key(makhoa)
);
create table admin1.NHANVIEN
(
    manv char(10),
    tennvm nvarchar2(50),
    maloai char(10),
    phucap int,
    luongcoban int,
    constraint pk_nhanvien primary key(manv)
);
create table admin1.LICHTRUC
(
   MABS char(10),
   thoigian date,
   phongtruc char(10),
   constraint pk_lichtruc primary key(MABS,THOIGIAN,PHONGTRUC)
);
create table admin1.LOAINHANVIEN
(
    maloai char(10),
    tenloai nvarchar2(50),
    constraint pk_loainv primary key(maloai)
);
create table admin1.BANGCHAMCONG
(
    manv char(10),
    ngaycong DATE,
    constraint pk_bangchamcong primary key(manv,NGAYCONG)
);

--CREATE CONSTRAINT
alter table admin1.BANGCHAMCONG ADD CONSTRAINT FK_CHAMCONG_NHANVIEN FOREIGN KEY(manv)references admin1.NHANVIEN(manv);

ALTER TABLE admin1.NHANVIEN ADD CONSTRAINT FK_NHANVIEN_LOAI FOREIGN KEY(maloai) references admin1.LOAINHANVIEN(maloai);

ALTER TABLE admin1.LICHTRUC ADD CONSTRAINT FK_LICHTRUC_BACSI FOREIGN KEY(MABS) REFERENCES admin1.BACSI(MABS);

ALTER TABLE admin1.BACSI ADD CONSTRAINT FK_BACSI_KHOA FOREIGN KEY(MACK) REFERENCES admin1.KHOA(makhoa);

ALTER TABLE admin1.HOADONTHUOC ADD CONSTRAINT FK_HOADONTHUOC_DONTHUOC FOREIGN KEY(madt) REFERENCES admin1.DONTHUOC(madt);

ALTER TABLE admin1.HOADONTHUOC ADD CONSTRAINT FK_HOADONTHUOC_NHANVIEN FOREIGN KEY(manv) REFERENCES admin1.NHANVIEN(manv);

ALTER TABLE admin1.CHITIETDONTHUOC ADD CONSTRAINT FK_CHITIETDONTHUOC_THUOC FOREIGN KEY(mathuoc) REFERENCES admin1.THUOC(mathuoc);

ALTER TABLE admin1.CHITIETDONTHUOC ADD CONSTRAINT FK_CHITIETDONTHUOC_DONTHUOC FOREIGN KEY(MADT) REFERENCES admin1.DONTHUOC(MADT);

ALTER TABLE admin1.DONTHUOC ADD CONSTRAINT FK_DONTHUOC_BACSI FOREIGN KEY(mabs) references admin1.BACSI(mabs);

ALTER TABLE admin1.DONTHUOC ADD CONSTRAINT FK_DONTHUOC_BENHNHAN FOREIGN KEY(makb) REFERENCES admin1.BENHNHAN(makb);

ALTER TABLE admin1.HOADONDICHVU ADD CONSTRAINT FK_HOADONDICHVU_BENHNHAN FOREIGN KEY(makb) REFERENCES admin1.BENHNHAN(makb);

ALTER TABLE admin1.HOADONDICHVU ADD CONSTRAINT FK_HOADONDICHVU_NHANVIEN FOREIGN KEY(manv) REFERENCES admin1.NHANVIEN(manv);

ALTER TABLE admin1.HOSODICHVU ADD CONSTRAINT FK_HOSODICHVU_NHANVIEN FOREIGN KEY(manv) REFERENCES admin1.NHANVIEN(manv);

ALTER TABLE admin1.HOSODICHVU ADD CONSTRAINT FK_HOSODICHVU_DICHVU FOREIGN KEY(madv) REFERENCES admin1.DICHVU(madv);

ALTER TABLE admin1.HOSODICHVU ADD CONSTRAINT FK_HOSODICHVU_HOADONDICHVU FOREIGN KEY(mahddv) REFERENCES admin1.HOADONDICHVU(mahddv);

ALTER TABLE admin1.HOADONKHAMBENH ADD CONSTRAINT FK_HOADONKHAMBENH_BENHNHAN FOREIGN KEY(makb) references admin1.BENHNHAN(makb);

ALTER TABLE admin1.HOADONKHAMBENH ADD CONSTRAINT FK_HOADONKHAMBENH_NHANVIEN  FOREIGN KEY(manv) REFERENCES admin1.NHANVIEN(manv);

ALTER TABLE admin1.HOSOBENHAN ADD CONSTRAINT FK_HOSOBENHAN_BACSI  FOREIGN KEY(maBS) REFERENCES admin1.BACSI(maBS);

ALTER TABLE admin1.HOSOBENHAN ADD CONSTRAINT FK_HOSOBENHAN_BENHNHAN  FOREIGN KEY(maKB) REFERENCES admin1.BENHNHAN(maKB);

ALTER TABLE admin1.TRIEUCHUNGBANDAU  ADD CONSTRAINT FK_TRIEUCHUNGBANDAU_BENHNHAN   FOREIGN KEY(maKB) REFERENCES admin1.BENHNHAN(maKB);
/
