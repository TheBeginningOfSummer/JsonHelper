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
        //data���л����ļ�
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
        //TB_JsonText.Text�����л���data
        private void TSB_JsonDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                //data = Json.ReadJsonFile<TypeOfTray>(Environment.CurrentDirectory + "\\JsonFile\\" + TSTB_FileName.Text)!;
                data = JsonSerializer.Deserialize<Dictionary<int, string>>(TB_JsonText.Text)!;

                //Type type = Type.GetType("Dictionary<int, string>", false, true)!;
                //data = GetType().GetMethod("JsonSerializer.Deserialize")!.MakeGenericMethod(new Type[] { type }).
                //    Invoke(this, new object[] { TB_JsonText.Text })!;
                MessageBox.Show("�����л����˱���data", "���ݷ����л�");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "���ݷ����л�");
            }
        }

        private void TSB_SetData_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, string> givenData = new Dictionary<int, string>();
                givenData.Add(0, "���Ǳ�����Ϣ");
                givenData.Add(1, "������Ϣ1");
                givenData.Add(2, "������Ϣ2");
                data = givenData;
                MessageBox.Show("�������óɹ�", "��������");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "��������");
            }
        }

        //public static object CreateGeneric(Type generic, Type innerType, params object[] args)
        //{
        //    Type specificType = generic.MakeGenericType(new System.Type[] { innerType });
        //    return Activator.CreateInstance(specificType, args);
        //}
        //object genericList = CreateGeneric(typeof(List<>), typeof(EC));

        //public class MyClass
        //{
        //}
        //Type t = typeof(List<MyClass>).GetGenericArguments()[0];
        //Console.WriteLine(t.Name);
        //���
         //MyClass
    }
}