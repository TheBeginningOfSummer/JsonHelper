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
        //data序列化到文件
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
        //TB_JsonText.Text反序列化到data
        private void TSB_JsonDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                //data = Json.ReadJsonFile<TypeOfTray>(Environment.CurrentDirectory + "\\JsonFile\\" + TSTB_FileName.Text)!;
                data = JsonSerializer.Deserialize<Dictionary<int, string>>(TB_JsonText.Text)!;

                //Type type = Type.GetType("Dictionary<int, string>", false, true)!;
                //data = GetType().GetMethod("JsonSerializer.Deserialize")!.MakeGenericMethod(new Type[] { type }).
                //    Invoke(this, new object[] { TB_JsonText.Text })!;
                MessageBox.Show("反序列化到了变量data", "数据反序列化");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据反序列化");
            }
        }

        private void TSB_SetData_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<int, string> givenData = new Dictionary<int, string>();
                givenData.Add(0, "这是报警信息");
                givenData.Add(1, "报警信息1");
                givenData.Add(2, "报警信息2");
                data = givenData;
                MessageBox.Show("数据设置成功", "数据设置");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据设置");
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
        //输出
         //MyClass
    }
}