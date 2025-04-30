using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
namespace Json_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string json = File.ReadAllText(filePath).Trim();

                try
                {
                    // Si no empieza con '[' ni termina con ']'
                    if (!json.StartsWith("[") && !json.EndsWith("]"))
                    {
                        // Envolver manualmente y corregir comas faltantes si fuera necesario
                        string fixedJson = "[" + Regex.Replace(json, @"}\s*{", "},{") + "]";
                        json = fixedJson;
                    }

                    // Deserializar como lista de objetos Student
                    List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json)!;

                    // Mostrar directamente en el DataGridView
                    dataGridView1.DataSource = students;
                    lbldireccion.Text = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar JSON:\n" + ex.Message);
                }
            }
        }
    }
}
