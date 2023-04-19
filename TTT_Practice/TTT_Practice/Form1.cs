using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTT_Practice.Model;
using TTT_Practice.Models;

namespace TTT_Practice
{
    public partial class Form1 : Form
    {
        private TTTHomeworkContext db = new TTTHomeworkContext();
        public Form1()
        {
            InitializeComponent();
            LoadComboboxADO();
            
        }
        public void BindData()
        {
            var cmbDt = (DataGridViewComboBoxColumn)dataGridViewSwaps.Columns["DerivativeTypesName"];
            var dt = SwapsViewDAO.Instance.LoadDt();
            cmbDt.DataSource = dt;
            cmbDt.ValueMember = "ID";
            cmbDt.DisplayMember = "Name";
        }
        public void LoadComboboxADO()
        {
            var dt = SwapsViewDAO.Instance.LoadDt();
            comboBoxDt.DataSource = dt;
            comboBoxDt.ValueMember = "ID";
            comboBoxDt.DisplayMember = "Name";
            var cs = SwapsViewDAO.Instance.LoadCs();
            comboBoxCs.DataSource = cs;
            comboBoxCs.ValueMember = "ctintCustomerSetupID";
            comboBoxCs.DisplayMember = "ctstrCustomerAccount";
            var ht = SwapsViewDAO.Instance.LoadHt();
            comboBoxHt.DataSource = ht;
            comboBoxHt.ValueMember = "HtintHoldingTypeId";
            comboBoxHt.DisplayMember = "htstrDescription";
            var ins = SwapsViewDAO.Instance.LoadIns();
            comboBoxIns.DataSource = ins;
            comboBoxIns.ValueMember = "lDRV_Instrument_id";
            comboBoxIns.DisplayMember = "ContractDescription";
        }
        public void LoadComboboxEF()
        {
            var dt = db.TlkpDerivativeTypes.Distinct().ToList();
            comboBoxDt.DataSource = dt;
            comboBoxDt.ValueMember = "ID";
            comboBoxDt.DisplayMember = "Name";
            var cs = db.TblCustomerSetup.Distinct().ToList();
            comboBoxCs.DataSource = cs;
            comboBoxCs.ValueMember = "ctintCustomerSetupID";
            comboBoxCs.DisplayMember = "ctstrCustomerAccount";
            var ht = db.TblHoldingType.Distinct().ToList();
            comboBoxHt.DataSource = ht;
            comboBoxHt.ValueMember = "HtintHoldingTypeId";
            comboBoxHt.DisplayMember = "htstrDescription";
            var ins = db.TblDrvInstruments.Distinct().ToList();
            comboBoxIns.DataSource = ins;
            comboBoxIns.ValueMember = "LDrvInstrumentId";
            comboBoxIns.DisplayMember = "ContractDescription";
        }
        public void LoadData()
        {
            if (button1.Text == "ADO")
            {
                dataGridViewSwaps.DataSource = SwapsViewDAO.Instance.LoadtblSwaps();
            }
            else if (button1.Text == "EF")
            {
                dataGridViewSwaps.DataSource = db.TblSwaps.Select(x => new tblSwapsViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    AccountingNumber = x.AccountingNumber,
                    DerivativeTypesName = db.TlkpDerivativeTypes.Where(d => d.Id == x.DerivativeTypesId).Select(d => d.Name).FirstOrDefault(),
                    CustomerSetupAccount = db.TblCustomerSetup.Where(c => c.CtintCustomerSetupId == x.CustomerSetupId).Select(c => c.CtstrCustomerAccount).FirstOrDefault(),
                    CustomerSetupName = db.TblCustomerSetup.Where(c => c.CtintCustomerSetupId == x.CustomerSetupId).Select(c => c.CtstrCustomerName1).FirstOrDefault(),
                    Description = x.Description,
                    LHoldingTypeDes = db.TblHoldingType.Where(h => h.HtintHoldingTypeId == x.LHoldingTypeId).Select(h => h.HtstrDescription).FirstOrDefault(),
                    LDrvInstrumentDes = db.TblDrvInstruments.Where(h => h.LDrvInstrumentId == x.LDrvInstrumentId).Select(i => i.ContractDescription).FirstOrDefault()
                }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "ADO") 
            {
                button1.Text = "EF";
                LoadComboboxEF();
            }
            else if(button1.Text == "EF")
            {
                
                button1.Text = "ADO";
                LoadComboboxADO();
            }
        }

        private void buttontblSwaps_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ADO")
            {
                dataGridViewSwaps.DataSource = SwapsViewDAO.Instance.LoadtblSwaps();
                BindData();
            }
            else if (button1.Text == "EF")
            {
                dataGridViewSwaps.DataSource = db.TblSwaps.Select(x => new tblSwapsViewModel
                {
                    Id= x.Id,
                    Name= x.Name,
                    AccountingNumber= x.AccountingNumber,
                    DerivativeTypesName = db.TlkpDerivativeTypes.Where(d=>d.Id==x.DerivativeTypesId).Select(d => d.Name).FirstOrDefault(),
                    CustomerSetupAccount = db.TblCustomerSetup.Where(c => c.CtintCustomerSetupId == x.CustomerSetupId).Select(c => c.CtstrCustomerAccount).FirstOrDefault(),
                    CustomerSetupName = db.TblCustomerSetup.Where(c => c.CtintCustomerSetupId == x.CustomerSetupId).Select(c => c.CtstrCustomerName1).FirstOrDefault(),
                    Description = x.Description,
                    LHoldingTypeDes = db.TblHoldingType.Where(h => h.HtintHoldingTypeId == x.LHoldingTypeId).Select(h => h.HtstrDescription).FirstOrDefault(),
                    LDrvInstrumentDes = db.TblDrvInstruments.Where(h => h.LDrvInstrumentId == x.LDrvInstrumentId).Select(i => i.ContractDescription).FirstOrDefault()
                }).ToList();
            }
        }

        private void buttonViewSwap_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ADO")
            {
                dataGridViewSwaps.DataSource = SwapsViewDAO.Instance.Load();
                
            }
            else if (button1.Text == "EF")
            {
                dataGridViewSwaps.DataSource = db.SwapsView.ToList();
            }
        }

        private void dataGridViewSwaps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (button1.Text == "EF")
            {
                var id = dataGridViewSwaps.Rows[e.RowIndex].Cells[0].Value;
                var swaps = db.TblSwaps.Find(id);
                txtId.Text = swaps.Id.ToString();
                txtName.Text = swaps.Name;
                txtAn.Text = swaps.AccountingNumber;
                txtDes.Text = swaps.Description;
                comboBoxDt.SelectedItem = db.TlkpDerivativeTypes.Find(swaps.DerivativeTypesId);
                comboBoxCs.SelectedItem = db.TblCustomerSetup.Find(swaps.CustomerSetupId);
                comboBoxHt.SelectedItem = db.TblHoldingType.Where(x => x.HtintHoldingTypeId == swaps.LHoldingTypeId).FirstOrDefault();
                comboBoxIns.SelectedItem = db.TblDrvInstruments.Where(x => x.LDrvInstrumentId == swaps.LDrvInstrumentId).FirstOrDefault();
            }
            if (button1.Text == "ADO")
            {
                var id = (int)dataGridViewSwaps.Rows[e.RowIndex].Cells[0].Value;
                var swaps = SwapsViewDAO.Instance.FindSwapById(id);
                if (swaps.Rows.Count > 0)
                {
                    txtId.Text = swaps.Rows[0]["Id"].ToString();
                    txtName.Text = swaps.Rows[0]["Name"].ToString();
                    txtAn.Text = swaps.Rows[0]["AccountingNumber"].ToString();
                    txtDes.Text = swaps.Rows[0]["Description"].ToString();
                    int dtId = int.Parse(swaps.Rows[0]["DerivativeTypesId"].ToString());
                    comboBoxDt.SelectedValue = swaps.Rows[0]["DerivativeTypesId"].ToString();
                    comboBoxCs.SelectedValue = swaps.Rows[0]["CustomerSetupID"].ToString();
                    comboBoxHt.SelectedValue = swaps.Rows[0]["lHoldingType_id"].ToString();
                    comboBoxIns.SelectedValue = swaps.Rows[0]["lDrv_Instrument_id"].ToString();
                }


            }
        }

        public void ClearFields() // Clear the fields after Insert or Update or Delete operation
        {
            txtName.Text = "";
            txtAn.Text = "";
            txtDes.Text = "";
            comboBoxDt.SelectedIndex = 0;
            comboBoxCs.SelectedIndex = 0;
            comboBoxHt.SelectedIndex = 0;
            comboBoxIns.SelectedIndex= 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(button1.Text == "EF")
            {
                var swap = new TblSwaps()
                {
                    //Id = int.Parse(txtId.Text), 
                    Name = txtName.Text,
                    AccountingNumber = txtAn.Text,
                    Description = txtDes.Text,
                    DerivativeTypesId = int.Parse(comboBoxDt.SelectedValue.ToString()),
                    CustomerSetupId = int.Parse(comboBoxCs.SelectedValue.ToString()),
                    LHoldingTypeId = int.Parse(comboBoxHt.SelectedValue.ToString()),
                    LDrvInstrumentId = short.Parse(comboBoxIns.SelectedValue.ToString()),
                    Trade = DateTime.Now,
                    Effective = DateTime.Now,
                    Settlement = DateTime.Now,
                    Maturity = DateTime.Now,
                    DtLastUpdateDt = DateTime.Now,
                };
                db.TblSwaps.Add(swap);
                db.SaveChanges();
                ClearFields();
                LoadData();
            }
            if (button1.Text == "ADO")
            {
                
                var swap = new TblSwaps()
                {

                    Name = txtName.Text,
                    AccountingNumber = txtAn.Text,
                    Description = txtDes.Text,
                    DerivativeTypesId = int.Parse(comboBoxDt.SelectedValue.ToString()),
                    CustomerSetupId = int.Parse(comboBoxCs.SelectedValue.ToString()),
                    LHoldingTypeId = int.Parse(comboBoxHt.SelectedValue.ToString()),
                    LDrvInstrumentId = short.Parse(comboBoxIns.SelectedValue.ToString())

                };
                var swapResult = SwapsViewDAO.Instance.InsertSwaps(swap);
                if (swapResult)
                {
                    MessageBox.Show("Done");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                ClearFields();
                LoadData();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (button1.Text == "EF")
            {
                var id = int.Parse(txtId.Text);
                var swap = db.TblSwaps.Find(id);
                swap.Name = txtName.Text;
                swap.AccountingNumber = txtAn.Text;
                swap.Description = txtDes.Text;
                swap.DerivativeTypesId = int.Parse(comboBoxDt.SelectedValue.ToString());
                swap.CustomerSetupId = int.Parse(comboBoxCs.SelectedValue.ToString());
                swap.LHoldingTypeId = int.Parse(comboBoxHt.SelectedValue.ToString());
                swap.LDrvInstrumentId = short.Parse(comboBoxIns.SelectedValue.ToString());
                db.TblSwaps.Update(swap);
                db.SaveChanges();
                ClearFields();
                LoadData();
            }
            if (button1.Text == "ADO")
            {
                var id = int.Parse(txtId.Text);
                var Name = txtName.Text;
                var AccountingNumber = txtAn.Text;
                var Description = txtDes.Text;
                var DerivativeTypesId = int.Parse(comboBoxDt.SelectedValue.ToString());
                var CustomerSetupId = int.Parse(comboBoxCs.SelectedValue.ToString());
                var LHoldingTypeId = int.Parse(comboBoxHt.SelectedValue.ToString());
                var LDrvInstrumentId = short.Parse(comboBoxIns.SelectedValue.ToString());
                var swap = new TblSwaps()
                {
                    Name= Name,
                    AccountingNumber = AccountingNumber,
                    Description = Description,
                    DerivativeTypesId = DerivativeTypesId,
                    CustomerSetupId = CustomerSetupId,
                    LHoldingTypeId=LHoldingTypeId,
                    LDrvInstrumentId= LDrvInstrumentId
                };
                var swapResult = SwapsViewDAO.Instance.UpdateSwaps(id,swap);
                if (swapResult)
                {
                    MessageBox.Show("Done");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                ClearFields();
                LoadData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (button1.Text == "EF")
            {
                var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var id = int.Parse(txtId.Text);
                    var swap = db.TblSwaps.Find(id);
                    db.TblSwaps.Remove(swap);
                    db.SaveChanges();
                    MessageBox.Show("Done");
                    LoadData();
                }
            }
            if (button1.Text == "ADO")
            {
                var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var id = int.Parse(txtId.Text);
                    var swapResult = SwapsViewDAO.Instance.DeleteSwapsById(id);
                    if (swapResult)
                    {
                        MessageBox.Show("Done");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                    
                }
            }
        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
