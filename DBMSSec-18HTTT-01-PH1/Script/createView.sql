CREATE OR REPLACE VIEW ADMIN1.BENHNHAN_NVTT_NVDPB AS
SELECT MAKB,TEN,namsinh,diachi,SDT
FROM ADMIN1.BENHNHAN;

CREATE OR REPLACE VIEW ADMIN1.BENHNHAN_NVQUANLYCM AS
SELECT MAKB,TEN,namsinh,diachi,SDT
FROM ADMIN1.BENHNHAN;

--CREATE OR REPLACE VIEW ADMIN1.BENHNHAN_NVQUANLYTV AS
--SELECT MAKB,TEN,namsinh,diachi,SDT
--FROM ADMIN1.BENHNHAN;

CREATE OR REPLACE VIEW ADMIN1.BENHNHAN_BACSI AS
SELECT MAKB,TEN,NAMSINH,DIACHI,SDT
FROM ADMIN1.BENHNHAN
WHERE MAKB IN (SELECT MAKB FROM ADMIN1.HOSOBENHAN WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER'));

CREATE OR REPLACE VIEW ADMIN1.TRIEUCHUNGBANDAU_NVTT_DPB AS
SELECT MAKB,TRIEUCHUNGBENH,NGAYGIO
FROM ADMIN1.TRIEUCHUNGBANDAU;

CREATE OR REPLACE VIEW ADMIN1.TRIEUCHUNGBANDAU_BACSI AS
SELECT MAKB,trieuchungbenh,ngaygio
FROM ADMIN1.TRIEUCHUNGBANDAU
WHERE MAKB IN (SELECT MAKB FROM ADMIN1.HOSOBENHAN WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER'));

CREATE OR REPLACE VIEW ADMIN1.TRIEUCHUNGBANDAU_NVQUANLYCM AS
SELECT *
FROM ADMIN1.TRIEUCHUNGBANDAU;

CREATE OR REPLACE VIEW ADMIN1.HOSOBENHAN_BACSI AS
SELECT MAKB,MABS,NGAY,TRIEUCHUNG,KETLUAN
FROM ADMIN1.HOSOBENHAN
WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.HOSOBENHAN_NVQUANLYCM AS
SELECT *
FROM ADMIN1.HOSOBENHAN;

CREATE OR REPLACE VIEW ADMIN1.HOADONKHAMBENH_NVTV AS
SELECT *
FROM ADMIN1.HOADONKHAMBENH
WHERE MANV = SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.HOADONKHAMBENH_NVQUANLYCM AS
SELECT *
FROM ADMIN1.HOADONKHAMBENH;

CREATE OR REPLACE VIEW ADMIN1.HOADONKHAMBENH_NVQUANLYTV AS
SELECT *
FROM ADMIN1.HOADONKHAMBENH;

CREATE OR REPLACE VIEW ADMIN1.HOSODICHVU_NVTV AS
SELECT MAHDDV,MADV,NGAYGIO,MANV
FROM ADMIN1.HOSODICHVU;

CREATE OR REPLACE VIEW ADMIN1.HOSODICHVU_BACSI AS
SELECT MADV,NGAYGIO,MANV,KETLUAN
FROM ADMIN1.HOSODICHVU
WHERE MAHDDV IN (SELECT MAHDDV FROM hoadondichvu WHERE MAKB IN (SELECT MAKB FROM HOSOBENHAN WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER')));

CREATE OR REPLACE VIEW ADMIN1.HOSODICHVU_NVQUANLYCM AS
SELECT *
FROM ADMIN1.HOSODICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_NVTT_DPB AS
SELECT MADV,TENDV
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_NVTV AS
SELECT *
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_BACSI AS
SELECT MADV,TENDV
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_NVQUANLYCM AS
SELECT *
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.DICHVU_NVQUANLYTV AS
SELECT *
FROM ADMIN1.DICHVU;

CREATE OR REPLACE VIEW ADMIN1.HOADONDICHVU_NVTV AS
SELECT *
FROM ADMIN1.HOADONDICHVU
WHERE MANV = SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.HOADONDICHVU_NVQUANLYCM AS
SELECT *
FROM ADMIN1.HOADONDICHVU;

CREATE OR REPLACE VIEW ADMIN1.HOADONDICHVU_NVQUANLYTV AS
SELECT *
FROM ADMIN1.HOADONDICHVU;

CREATE OR REPLACE VIEW ADMIN1.DONTHUOC_BACSI AS
SELECT *
FROM ADMIN1.DONTHUOC
WHERE MAKB IN (SELECT MAKB FROM ADMIN1.HOSOBENHAN WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER'));

CREATE OR REPLACE VIEW ADMIN1.DONTHUOC_NVBT AS
SELECT *
FROM ADMIN1.DONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.DONTHUOC_NVQUANLYCM AS
SELECT *
FROM ADMIN1.DONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_NVTT_DPB AS
SELECT MATHUOC,TENTHUOC,LOAITHUOC
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_BACSI AS
SELECT TENTHUOC,LOAITHUOC,DONVI,GIATIEN
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_NVBT AS
SELECT *
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_NVQUANLYCM AS
SELECT *
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.THUOC_NVQUANLYTV AS
SELECT *
FROM ADMIN1.THUOC;

CREATE OR REPLACE VIEW ADMIN1.CHITIETDONTHUOC_BACSI AS
SELECT *
FROM ADMIN1.CHITIETDONTHUOC
WHERE MADT IN (SELECT MADT FROM ADMIN1.DONTHUOC WHERE MABS =SYS_CONTEXT('USERENV','SESSION_USER'));

CREATE OR REPLACE VIEW ADMIN1.CHITIETDONTHUOC_NVBT AS
SELECT *
FROM ADMIN1.CHITIETDONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.CHITIETDONTHUOC_NVQUANLYCM AS
SELECT *
FROM ADMIN1.CHITIETDONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.HOADONTHUOC_NVBT AS
SELECT *
FROM ADMIN1.HOADONTHUOC
WHERE MANV = SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.HOADONTHUOC_NVQUANLYCM AS
SELECT *
FROM ADMIN1.HOADONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.HOADONTHUOC_NVQUANLYTV AS
SELECT *
FROM ADMIN1.HOADONTHUOC;

CREATE OR REPLACE VIEW ADMIN1.BACSI_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.BACSI;

CREATE OR REPLACE VIEW ADMIN1.BACSI_BACSI AS
SELECT MABS,TENBS,MACK
FROM ADMIN1.BACSI
WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.BACSI_NVKT AS
SELECT MABS,PHUCAP,LUONGCOBAN
FROM ADMIN1.BACSI;

CREATE OR REPLACE VIEW ADMIN1.BACSI_NVQUANLYCM AS
SELECT *
FROM ADMIN1.BACSI;

CREATE OR REPLACE VIEW ADMIN1.BACSI_NVQUANLYTV AS
SELECT *
FROM ADMIN1.BACSI;

CREATE OR REPLACE VIEW ADMIN1.KHOA_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.KHOA;

CREATE OR REPLACE VIEW ADMIN1.KHOA_NVQUANLYCM AS
SELECT *
FROM ADMIN1.KHOA;

CREATE OR REPLACE VIEW ADMIN1.KHOA_NVQUANLYTV AS
SELECT *
FROM ADMIN1.KHOA;

CREATE OR REPLACE VIEW ADMIN1.NHANVIEN_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.NHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.NHANVIEN_NVTT_DPB AS
SELECT MANV,TENNVM,MALOAI
FROM ADMIN1.NHANVIEN
WHERE MANV=SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.NHANVIEN_NVKT AS
SELECT MANV,PHUCAP,LUONGCOBAN
FROM ADMIN1.NHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.NHANVIEN_NVQUANLCM AS
SELECT *
FROM ADMIN1.NHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.NHANVIEN_NVQUANLYTV AS
SELECT *
FROM ADMIN1.NHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.LICHTRUC_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.LICHTRUC;

CREATE OR REPLACE VIEW ADMIN1.LICHTRUC_BACSI AS
SELECT *
FROM ADMIN1.LICHTRUC
WHERE MABS=SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.LICHTRUC_NVQUANLYCM AS
SELECT *
FROM ADMIN1.LICHTRUC;

CREATE OR REPLACE VIEW ADMIN1.LICHTRUC_NVQUANLYTV AS
SELECT *
FROM ADMIN1.LICHTRUC;

CREATE OR REPLACE VIEW ADMIN1.LOAINHANVIEN_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.LOAINHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.LOAINHANVIEN_NVQUANLYCM AS
SELECT *
FROM ADMIN1.LOAINHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.LOAINHANVIEN_NVQUANLYTV AS
SELECT *
FROM ADMIN1.LOAINHANVIEN;

CREATE OR REPLACE VIEW ADMIN1.BANGCHAMCONG_NVQUANLYTNNS AS
SELECT *
FROM ADMIN1.BANGCHAMCONG;

CREATE OR REPLACE VIEW ADMIN1.BANGCHAMCONG_NVKT AS
SELECT *
FROM ADMIN1.BANGCHAMCONG;

CREATE OR REPLACE VIEW ADMIN1.BANGCHAMCONG_NVQUANLYCM AS
SELECT *
FROM ADMIN1.BANGCHAMCONG;

CREATE OR REPLACE VIEW ADMIN1.BANGCHAMCONG_NVQUANLYTV AS
SELECT *
FROM ADMIN1.BANGCHAMCONG;

CREATE OR REPLACE VIEW ADMIN1.HOSODICHVU_NVDV AS
SELECT *
FROM ADMIN1.HOSODICHVU
WHERE MANV = SYS_CONTEXT('USERENV','SESSION_USER');

CREATE OR REPLACE VIEW ADMIN1.DICHVUG_NVDV AS
SELECT *
FROM ADMIN1.DICHVU;


