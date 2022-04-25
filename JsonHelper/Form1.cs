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
            OFD_JsonDoc.Filter = "json�ļ�|*.json|�ı��ļ�|*.txt";
            if (OFD_JsonDoc.ShowDialog() == DialogResult.OK)
            {
                TB_JsonText.Text = File.ReadAllText(Path.GetFullPath(OFD_JsonDoc.FileName));//��ȡ�ļ�
            }
        }

        private void TSB_JsonSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                Json.SaveJsonFile(Environment.CurrentDirectory + "\\JsonFile\\", TSTB_FileName.Text, data);
                MessageBox.Show("�浵�ɹ�", "�������л�");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "�������л�");
            }
        }

        private void TSB_JsonDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                data = JsonSerializer.Deserialize<Dictionary<string, TypeOfTray>>(TB_JsonText.Text)!;
                //data = Json.ReadJsonFile<TypeOfTray>(Environment.CurrentDirectory + "\\JsonFile\\" + TSTB_FileName.Text)!;
                MessageBox.Show("�����л��ɹ�", "���ݷ����л�");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "���ݷ����л�");
            }
        }
    }
}