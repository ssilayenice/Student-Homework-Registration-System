using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataProcessing;
using DevExpress.XtraTreeList;

namespace School
{
    public partial class MainForm : Form
    {
        private PopUpForm _popUpForm = new PopUpForm();
        private List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnTeacherOk_Click methodu OK butonu ile tetiklenir, kullanıcının girdiği verilere göre treelisti doldurur ve ödev bilgilerinin txt dosyasına yazılması için ilgili methodu tetikler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTeacherOk_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtStudentName.Text;
                string studentAge = txtStudentAge.Text;
                string studentGrade = txtStudentGrade.Text;
                string hwTopic = txtTopic.Text;
                string hwUnit = txtUnit.Text;
                string hwcompositionTime = dateCompositionTime.Text;

                if (studentName.IsNullOrEmpty() == true && studentAge.IsNullOrEmpty() == true && studentGrade.IsNullOrEmpty() == true && hwTopic.IsNullOrEmpty() == true
                && hwcompositionTime.IsNullOrEmpty() == true)
                {
                    Student student = new Student();
                    student.Homework = new Homework();

                    student.IsSelected = false;
                    student.Name = studentName;
                    student.Age = Convert.ToInt32(studentAge);
                    student.Grade = Convert.ToInt32(studentGrade);

                    student.Homework.Topic = hwTopic;
                    if (hwUnit.IsNullOrEmpty() == true)
                        student.Homework.Unit = Convert.ToInt32(hwUnit);
                    student.Homework.CompletionTime = dateCompositionTime.DateTime;
                    student.Homework.CreateTime = DateTime.Now;

                    students.Add(student);
                    UpdateTListandHwCount();

                    string date = student.Homework.CreateTime.ToString("yyyyMMddHHmmss");
                    string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filename = student.Name + student.Homework.Topic + date + "Hw.txt";
                    string text = "Topic:" + student.Homework.Topic + Environment.NewLine + "Unit:" + student.Homework.Unit + Environment.NewLine + "Completion Time:" + student.Homework.CompletionTime;
                 
                    await WriteTxtAsync(filepath, filename, text);
                }
                else
                    MessageBox.Show("Please give the Empty Information.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("There is an Error: " + ex.Message);
            }
        }

        /// <summary>
        /// WriteTxtAsync methodu ödev bilgilerinin txt dosyasına asenkron bir biçimde yazılmasını sağlar.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        static async Task WriteTxtAsync(string filepath, string filename, string text)
        {
            try
            {
                using (StreamWriter outputfile = new StreamWriter(Path.Combine(filepath, filename)))
                {
                    await outputfile.WriteAsync(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while writing Homework information to txt.Error:" + ex.Message);
            }
        }

        /// <summary>
        /// UpdateTListandHwCount methodu UpdateTreeList ve WriteHwCount methodlarını tetikler.
        /// </summary>
        private void UpdateTListandHwCount()
        {
            try
            {
                UpdateTreeList();
                WriteHwCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while Treelist updateing and Hw Count writing. Error:" + ex.Message);
            }
        }

        /// <summary>
        /// UpdateTreeList methodu Treelistlerin güncellenmesini sağlar.
        /// </summary>
        private void UpdateTreeList()
        {
            try
            {
                treeListStudent.DataSource = null;
                treeListTeacher.DataSource = null;
               
                treeListStudent.DataSource = students;
                treeListTeacher.DataSource = students;
                string file = "D:/Talepler/Planet/deneme.xml";
                treeListStudent.ExportToXml(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while Treelist updating.Error:" + ex.Message);
            }

        }

        /// <summary>
        /// WriteHwCount mthodu ilgili labellara hangi durumda kaç adet ödev oladuğunu yazar.
        /// </summary>
        private void WriteHwCount()
        {
            try
            {
                var newhwCount = students.Count(i => i.Homework.HwSituationType.Equals(EHwSituationType.New));
                var continuehwCount = students.Count(i => i.Homework.HwSituationType.Equals(EHwSituationType.Continue));
                var completedhwCount = students.Count(i => i.Homework.HwSituationType.Equals(EHwSituationType.Completed));

                lblHwStudent.Text = "New Homework:" + newhwCount + Environment.NewLine + "Continue Homework:" +
                                    continuehwCount + Environment.NewLine + "Completed Homework:" + completedhwCount;
                lblHwTeacher.Text = lblHwStudent.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while Hw Situation count writing.Error:" + ex.Message);
            }
        }

        /// <summary>
        /// SelectedCheckEdit_CheckedChanged methodu seçilen satırdaki ödev durumunu değiştiren methodu tetiklemek için SubFormu açar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                treeListStudent.PostEditor();
                var selectedRow = (students.Select(i => i.IsSelected.Equals(true))).Count();
                if (selectedRow != 0)
                {
                    DialogResult result = _popUpForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ChangeHwSituation();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while row selecting.Error:" + ex.Message);
            }
        }

        /// <summary>
        /// ChangeHwSituation methodu ödev durumlarının değiştirilmesini, treelist ve ilgili labellarda güncellenmesini sağlar.
        /// </summary>
        private void ChangeHwSituation()
        {
            try
            {
                var selectedRow = students.Where(i => i.IsSelected.Equals(true));
                if (_popUpForm.rbtnStart.Checked == true)
                    selectedRow.ForEach(i => i.Homework.HwSituationType = EHwSituationType.Continue);
                else if (_popUpForm.rbtnFinish.Checked == true)
                    selectedRow.ForEach(i => i.Homework.HwSituationType = EHwSituationType.Completed);
                else
                    MessageBox.Show("Please make a choice.");
                UpdateTListandHwCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while Hw situation changing.Error:" + ex.Message);
            }
        }

        /// <summary>
        /// txtUnit_KeyPress, txtStudentAge_KeyPress ve txtStudentGrade_KeyPress methodları ilgili textboxlara sadece int değer girilmesini sağlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStudentAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStudentGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
