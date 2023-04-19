using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTT_Practice.Models;

namespace TTT_Practice
{
    public class SwapsViewDAO
    {
        private static SwapsViewDAO instance;
        public static SwapsViewDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SwapsViewDAO();
                }
                return instance;
            }
        }
        private SwapsViewDAO() { }
        public DataTable LoadTypeColumntblSwaps()
        {
            string query = "SELECT c.name 'Column Name', "
                                + "t.Name 'Data type', "
                                + "c.max_length 'Max Length', "
                                + "c.is_nullable 'Nullable', "
                                + "ISNULL(i.is_primary_key, 0) 'Primary Key' "
                             + "FROM sys.columns c "
                             + "INNER JOIN "
                             + "sys.types t ON c.user_type_id = t.user_type_id "
                             + "LEFT OUTER JOIN "
                             + "sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id "
                             + "LEFT OUTER JOIN "
                             + "sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id "
                             + "WHERE c.object_id = OBJECT_ID('tblSwaps') ";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable Load()
        {
            string query = "SELECT [Swap ID], [Swap Name], [ID], [Account], [Name], [Derivative Type ID], [Derivative Type], [Holding Type ID], [Holding Type], [Instrument ID], [Instrument], [Last Processed Date] FROM SwapsView";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable LoadDt()
        {
            string query = "SELECT * FROM dbo.tlkpDerivativeTypes";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable FindDtById(int id)
        {
            object[] parameter = new object[] { id };
            string query = "SELECT * FROM dbo.tlkpDerivativeTypes WHERE dbo.tlkpDerivativeTypes.ID = @ID";
            return DataProvider.Instance.excuteQuery(query, parameter);
        }
        public DataTable LoadCs()
        {
            string query = "SELECT * FROM dbo.tblCustomerSetup";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable LoadHt()
        {
            string query = "SELECT * FROM dbo.tblHoldingType";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable LoadIns()
        {
            string query = "SELECT * FROM dbo.tbl_DRV_Instruments";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable LoadtblSwaps()
        {
            string query = "SELECT dbo.tblSwaps.ID as [Id], "
                                + "dbo.tblSwaps.[Name] as [Name], "
                                + "dbo.tblSwaps.AccountingNumber as [AccountingNumber], "
                                + "dbo.tlkpDerivativeTypes.Name as [DerivativeTypesName], "
                                + "dbo.tblCustomerSetup.ctstrCustomerAccount as [CustomerSetupAccount], "
                                + "dbo.tblCustomerSetup.ctstrCustomerName1 AS [CustomerSetupName], "
                                + "dbo.tblSwaps.[Description] as [Description], "
                                + "dbo.tblHoldingType.htstrDescription as [LHoldingTypeDes], "
                                + "dbo.tbl_DRV_Instruments.ContractDescription as [LDrvInstrumentDes] "
                             + "FROM dbo.tblSwaps "
                             + "LEFT JOIN dbo.tlkpDerivativeTypes "
                             + "ON dbo.tblSwaps.DerivativeTypesID = dbo.tlkpDerivativeTypes.ID "
                             + "LEFT JOIN dbo.tblCustomerSetup "
                             + "ON dbo.tblSwaps.CustomerSetupID = dbo.tblCustomerSetup.ctintCustomerSetupID "
                             + "LEFT JOIN dbo.tblHoldingType "
                             + "ON dbo.tblSwaps.lHoldingType_id = dbo.tblHoldingType.htintHoldingTypeID " 
                             + "LEFT JOIN dbo.tbl_DRV_Instruments "
                             + "ON dbo.tblSwaps.lDrv_Instrument_id = dbo.tbl_DRV_Instruments.lDRV_Instrument_id "
                             + "ORDER BY dbo.tblSwaps.ID ASC";
            return DataProvider.Instance.excuteReader(query);
        }
        public DataTable FindSwapById(int id)
        {
            object[] parameter = new object[] { id };
            string query = "SELECT * FROM dbo.tblSwaps WHERE dbo.tblSwaps.ID = @tblSwapsId";
            return DataProvider.Instance.excuteQuery(query, parameter);
        }
        public bool DeleteSwapsById(int id)
        {
            object[] parameter = new object[] { id };
            string query = "DELETE dbo.tblSwaps WHERE dbo.tblSwaps.ID = @tblSwapsId";
            if(DataProvider.Instance.excuteNonQuery(query, parameter) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateSwaps(int id, TblSwaps swaps)
        {
            object[] parameter = new object[] {swaps.Name,swaps.AccountingNumber,swaps.DerivativeTypesId,swaps.CustomerSetupId,swaps.Description,swaps.LHoldingTypeId,swaps.LDrvInstrumentId, id};
            string query = "UPDATE dbo.tblSwaps SET [Name] = @Name , AccountingNumber = @AccountingNumber , DerivativeTypesId = @DerivativeTypesId , CustomerSetupId = @CustomerSetupId , Description = @Description ,lHoldingType_id = @LHoldingTypeId , lDRV_Instrument_id = @LDrvInstrumentId WHERE dbo.tblSwaps.ID = @tblSwapsId";
            if (DataProvider.Instance.excuteNonQuery(query, parameter) > 0) 
            {
                return true;
            }
            return false;
        }
        public bool InsertSwaps(TblSwaps swaps)
        {
            object[] parameter = new object[] { swaps.Name, swaps.AccountingNumber, swaps.DerivativeTypesId, swaps.CustomerSetupId, swaps.Description, swaps.LHoldingTypeId, swaps.LDrvInstrumentId };
            //string query = "INSERT INTO dbo.tblSwaps ( Name , AccountingNumber , DerivativeTypesId , CustomerSetupId, Description , lHoldingType_id , lDRV_Instrument_id , Trade , Effective , Settlement , Maturity , dtLastUpdate_dt ) VALUES( @Name , @AccountingNumber , @DerivativeTypesId , @CustomerSetupId , @Description , @LHoldingTypeId , @LDrvInstrumentId , @Trade , @Effective , @Settlement , @Maturity , @DtLastUpdateDt )";
            DataTable typeColumnSwaps = SwapsViewDAO.Instance.LoadTypeColumntblSwaps();
            List<string> lNameSwaps = new List<string>();
            List<string> lNameSwapsInt = new List<string>();
            List<string> lNameSwapsDate = new List<string>();
            foreach (DataRow row in typeColumnSwaps.Rows)
            {

                if ((row["Column Name"].ToString() == "AccountingNumber"
                   || row["Column Name"].ToString() == "Description"
                   || row["Nullable"].ToString() == "False") && row["Column Name"].ToString() != "ID")
                {
                    lNameSwaps.Add(row["Column Name"].ToString());
                }
                if (row["Column Name"].ToString() != "ID"
                   && row["Column Name"].ToString() != "DerivativeTypesID"
                   && row["Column Name"].ToString() != "CustomerSetupID"
                   && row["Column Name"].ToString() != "lHoldingType_id"
                   && row["Column Name"].ToString() != "lDrv_Instrument_id"
                   && (row["Data type"].ToString() == "int"
                   || row["Data type"].ToString() == "tinyint"
                   || row["Data type"].ToString() == "money"
                   || row["Data type"].ToString() == "smallint"
                   || row["Data type"].ToString() == "bit"
                   || row["Data type"].ToString() == "float" || row["Data type"].ToString() == "numeric")
                   )
                {
                    lNameSwapsInt.Add(row["Column Name"].ToString());
                }
                if (row["Data type"].ToString() == "datetime"
                   || row["Data type"].ToString() == "smalldatetime"
                   )
                {
                    lNameSwapsDate.Add(row["Column Name"].ToString());
                }
            }

            string strColName = string.Join(" , ", lNameSwaps.ToArray());
            string strColNameRe = string.Join(" , @", lNameSwaps.ToArray());
            string queryStr = $"INSERT INTO dbo.tblSwaps ( {strColName} ) VALUES( @{strColNameRe} )";
            List<string> lQuery = queryStr.Split(' ').ToList();
            StringBuilder builder = new StringBuilder(queryStr);
            foreach (var item in lQuery)
            {
                foreach (var itemLnsi in lNameSwapsInt)
                {
                    if ($"@{item}" == $"@{itemLnsi}")
                    {

                        builder.Replace($"@{item}", "'0'");

                    }
                }
            }
            foreach (var item in lQuery)
            {

                foreach (var itemLnsd in lNameSwapsDate)
                {
                    if ($"@{item}" == $"@{itemLnsd}")
                    {

                        builder.Replace($"@{item}", "'20230417 10:34:09 AM'");

                    }
                }
            }
            var query = builder.ToString();

            if (DataProvider.Instance.excuteNonQuery(query, parameter) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
