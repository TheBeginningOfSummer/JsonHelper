using System.Text.Json;

namespace JsonHelper
{
    public partial class Form1 : Form
    {
        object data = new DefaultData();

        public Form1()
        {
            InitializeComponent();
        }

        private void TSB_OpenFile_Click(object sender, EventArgs e)
        {
            OFD_JsonDoc.Filter = "json文件|*.json|文本文件|*.txt";
            if (OFD_JsonDoc.ShowDialog() == DialogResult.OK)
            {
                TB_JsonText.Text = File.ReadAllText(Path.GetFullPath(OFD_JsonDoc.FileName));//读取文件
            }
        }

        private void TSB_JsonSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                Json.SaveJsonFile(Environment.CurrentDirectory + "\\JsonFile\\", TSTB_FileName.Text, data);
                MessageBox.Show("存档成功", "数据序列化");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据序列化");
            }
        }

        private void TSB_JsonDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                data = JsonSerializer.Deserialize<Dictionary<string, TypeOfTray>>(TB_JsonText.Text)!;
                //data = Json.ReadJsonFile<TypeOfTray>(Environment.CurrentDirectory + "\\JsonFile\\" + TSTB_FileName.Text)!;
                MessageBox.Show("反序列化成功", "数据反序列化");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据反序列化");
            }
        }
    }
}