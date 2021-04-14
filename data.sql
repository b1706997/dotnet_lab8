insert into lop(MA_LOP,TEN_LOP) values('K4401','CNPM 01');
insert into SINHVIEN(MSSV,TEN_SV,MA_LOP) values ('B18015','Hồ Việt Hưng','K44-03')
insert into monhoc(MA_MON,TEN_MON) values ('CT101','Lập trình căn bản');
insert into monhoc(ma_mon,ten_mon) values ('CT103','Cấu trúc dữ liệu');
insert into monhoc(ma_mon,ten_mon) values ('CT251','Phát triển ứng dụng trên Windows');
insert into canbo(MA_CB,TEN_CB,MK_CB) values ('001','Nguyễn Văn Cường','123');
insert into canbo(MA_CB,TEN_CB,MK_CB) values ('002','Huỳnh Minh Phương','123');
insert into canbo(MA_CB,TEN_CB,MK_CB) values ('003','Thái Cẩm Nhung','123');
select * from monhoc;
select * from sinhvien;
select * from MONHOCCUALOP;

insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('001','K44-01','CT101');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('001','K44-02','CT101');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('001','K44-01','CT103');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('001','K44-03','CT103');

insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('002','K44-03','CT101');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('002','K44-03','CT103');

insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('003','K44-01','CT251');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('003','K44-02','CT251');
insert into MONHOCCUALOP(MA_CB,MA_LOP,MA_MON) values('003','K44-03','CT251');

select * from lop;
select * from MONHOCCUALOP;

