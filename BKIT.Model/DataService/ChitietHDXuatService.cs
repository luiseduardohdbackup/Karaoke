using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using BKIT.Entities;
using BKIT.Model.IDataService;

namespace BKIT.Model.DataService
{
    public class ChitietHDXuatService : IChitietHDXuat
    {
        public int insertChitietHDXuat(BKIT.Entities.ChitietHDXuat objChitietHDXuat)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "INSERT INTO ChitietHDXuat(IDChitietHDXuat,IDHoadonXuat,IDSanpham,Gia,Soluong,Giam,Ghichu,Trangthai) " +
                "VALUES (@idchitiethdxuat,@idhoadonxuat,@idsanpham,@gia,@soluong,@giam,@ghichu,@trangthai)";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
            try
            {
                int ID = GetNextAVailableID();
                objChitietHDXuat.IDChitietHDXuat = ID;
                db.AddInParameter(dbCommand, "idchitiethdxuat", DbType.Int32, objChitietHDXuat.IDChitietHDXuat);
                db.AddInParameter(dbCommand, "idhoadonxuat", DbType.Int32, objChitietHDXuat.IDHoadonXuat);
                db.AddInParameter(dbCommand, "idsanpham", DbType.Int32, objChitietHDXuat.IDSanpham);
                db.AddInParameter(dbCommand, "gia", DbType.Int32, objChitietHDXuat.Gia);
                db.AddInParameter(dbCommand, "soluong", DbType.Int32, objChitietHDXuat.Soluong);
                db.AddInParameter(dbCommand, "giam", DbType.Int32, objChitietHDXuat.Giam);
                db.AddInParameter(dbCommand, "ghichu", DbType.String, objChitietHDXuat.Ghichu);
                db.AddInParameter(dbCommand, "trangthai", DbType.Boolean, objChitietHDXuat.Trangthai);
                db.ExecuteNonQuery(dbCommand);
                dbCommand.Connection.Close();
                return ID;
            }
            catch
            {
                dbCommand.Connection.Close();
                return -1;
            }
        }
        public bool updateChitietHDXuat(BKIT.Entities.ChitietHDXuat objChitietHDXuat)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "UPDATE ChitietHDXuat SET IDHoadonXuat = @idhoadonxuat, IDSanpham = @idsanpham, Gia = @gia, Soluong = @soluong, Giam = @giam, Ghichu = @ghichu, Trangthai = @trangthai " +
                    "WHERE IDChitietHDXuat = @idchitiethdxuat";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
            try
            {
                db.AddInParameter(dbCommand, "idhoadonxuat", DbType.Int32, objChitietHDXuat.IDHoadonXuat);
                db.AddInParameter(dbCommand, "idsanpham", DbType.Int32, objChitietHDXuat.IDSanpham);
                db.AddInParameter(dbCommand, "gia", DbType.Int32, objChitietHDXuat.Gia);
                db.AddInParameter(dbCommand, "soluong", DbType.Int32, objChitietHDXuat.Soluong);
                db.AddInParameter(dbCommand, "giam", DbType.Int32, objChitietHDXuat.Giam);
                db.AddInParameter(dbCommand, "ghichu", DbType.String, objChitietHDXuat.Ghichu);

                db.AddInParameter(dbCommand, "trangthai", DbType.Boolean, objChitietHDXuat.Trangthai);
                db.AddInParameter(dbCommand, "idchitiethdxuat", DbType.Int32, objChitietHDXuat.IDChitietHDXuat);
                db.ExecuteNonQuery(dbCommand);
                dbCommand.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteChitietHDXuat(BKIT.Entities.ChitietHDXuat objChitietHDXuat)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "DELETE FROM ChitietHDXuat WHERE IDChitietHDXuat = @idchitiethdxuat";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
            try
            {
                db.AddInParameter(dbCommand, "idchitiethdxuat", DbType.Int32, objChitietHDXuat.IDChitietHDXuat);
                db.ExecuteNonQuery(dbCommand);
                dbCommand.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteChitietHDXuatOfHDXuat(BKIT.Entities.Hoadonxuat objHDXuat)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "DELETE FROM ChitietHDXuat WHERE IDHoadonXuat = @idhdxuat";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
            try
            {
                db.AddInParameter(dbCommand, "idhdxuat", DbType.Int32, objHDXuat.IDHoadonXuat);
                db.ExecuteNonQuery(dbCommand);
                dbCommand.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public System.Data.DataSet getAllChitietHDXuat()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SELECT * FROM ChitietHDXuat";
            try
            {
                DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
                DataSet ds = db.ExecuteDataSet(dbCommand);
                dbCommand.Connection.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public System.Data.DataSet getChitietHDXuatByIDSanphamAndIDHoadon(int IDSanpham,int IDHoadon)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SELECT * FROM ChitietHDXuat WHERE IDSanpham = @idsanpham AND IDHoadonXuat = @idhoadon";
            try
            {
                DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
                db.AddInParameter(dbCommand, "idsanpham", DbType.Int32,IDSanpham);
                db.AddInParameter(dbCommand, "idhoadon", DbType.Int32, IDHoadon);
                DataSet ds = db.ExecuteDataSet(dbCommand);
                dbCommand.Connection.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        //get all detail of a receipt
        public System.Data.DataSet getChitietHDXuatByID(int ID)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SELECT ChitietHDXuat.IDChitietHDXuat AS IDChitietHDXuat, ChitietHDXuat.IDHoadonXuat AS IDHoadonXuat, ChitietHDXuat.IDSanpham AS IDSanpham, SanPham.TenSanPham AS TenSanPham, SanPham.DVT AS DVT, ChitietHDXuat.Gia AS Gia,ChitietHDXuat.Giam AS Giam, ChitietHDXuat.Soluong AS Soluong, ([Gia]*(100 - [Giam])/100)*[Soluong] AS Thanhtien, SanPham.TonKho AS TonKho, ChitietHDXuat.Ghichu AS Ghichu, SanPham.Noixuat AS Noixuat,ChitietHDXuat.Trangthai AS Trangthai,1 as [Delete] " +
                                "FROM  SanPham INNER JOIN ChitietHDXuat ON SanPham.IDSanPham = ChitietHDXuat.IDSanpham " +
                                "WHERE (((ChitietHDXuat.IDHoadonXuat)=@idhoadonxuat));";

            try
            {
                DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
                db.AddInParameter(dbCommand, "idhoadonxuat", DbType.Int32, ID);
                DataSet ds = db.ExecuteDataSet(dbCommand);
                dbCommand.Connection.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        //get all detail of a receipt with group on the same ID product to print customer receipt
        public System.Data.DataSet getSumChitietHDXuatByID(int ID)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SELECT ChitietHDXuat.IDHoadonXuat AS IDHoadonXuat, ChitietHDXuat.IDSanpham AS IDSanpham, SanPham.TenSanPham AS TenSanPham, SanPham.DVT AS DVT, ChitietHDXuat.Gia AS Gia, ChitietHDXuat.Giam AS Giam, Sum(ChitietHDXuat.Soluong) AS Soluong, ([Gia]*(100-[Giam])/100)*[Soluong] AS Thanhtien "+
                                "FROM SanPham INNER JOIN ChitietHDXuat ON SanPham.IDSanPham = ChitietHDXuat.IDSanpham "+
                                "GROUP BY ChitietHDXuat.IDHoadonXuat, ChitietHDXuat.IDSanpham, SanPham.TenSanPham, SanPham.DVT, ChitietHDXuat.Gia, ChitietHDXuat.Giam, ([Gia]*(100-[Giam])/100)*[Soluong] "+
                                "HAVING (((ChitietHDXuat.IDHoadonXuat)=@idhoadonxuat));";


            try
            {
                DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
                db.AddInParameter(dbCommand, "idhoadonxuat", DbType.Int32, ID);
                DataSet ds = db.ExecuteDataSet(dbCommand);
                dbCommand.Connection.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        #region Helpers
        internal int GetNextAVailableID()
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SELECT IDChitietHDXuat FROM ChitietHDXuat ORDER BY IDChitietHDXuat";
            DbCommand dbCommand = db.GetSqlStringCommand(sqlCommand);
            int result = 0;
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader.Read())
                {
                    if (result != (int)dataReader[0])
                    {
                        dataReader.Close();
                        dbCommand.Connection.Close();
                        return result;
                    }
                    result++;
                }
                dataReader.Close();
                dbCommand.Connection.Close();
                return result;
            }
        }
        #endregion
    }
}
