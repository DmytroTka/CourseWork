using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace CourseWork
{
    public partial class FormFileSaving : Form
    {
        private string directoryName = "slae_savings";
        private SLAE slae;
        internal FormFileSaving(SLAE slae)
        {
            InitializeComponent();
            this.slae = slae;
        }

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            string filename = fileNameTextBox.Text;
            string errorMessage = "";
            errorLabel.Text = errorMessage;
            if (IsDirectory(ref errorMessage))
            {
                if(CreateFileIfNotExist(filename, ref errorMessage))
                {
                    if(WriteSLAEToFile(filename, ref errorMessage))
                    {
                        resultsLabel.Text = $"СЛАР була успішно записана у файл '{filename}' катологу '{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryName)}'.";
                    }
                }
            }
            if (errorMessage != "")
            {
                errorLabel.Text = errorMessage;
            }
        }

        private bool IsDirectory(ref string errorMessage)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fullRelativePath = Path.Combine(baseDirectory, directoryName);
            if (!Directory.Exists(directoryName))
            {
                try
                {
                    Directory.CreateDirectory(fullRelativePath);
                    return true;
                }
                catch (Exception ex)
                {
                    errorMessage = "Виникла помилка при створенні папки для збереження файлів";
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private bool CreateFileIfNotExist(string filename, ref string errorMessage)
        {
            string filePath = directoryName + '/' + filename + ".txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Виникла помилка при створенні файлу.";
                return false;
            }
        }

        private bool WriteSLAEToFile(string filename, ref string errorMessage)
        {
            string filePath = directoryName + "\\" + filename + ".txt"; 
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    int n = slae.Size;
                    sw.WriteLine("------------------------------------------");
                    sw.WriteLine($"SLAE size: {n}");
                    for (int i = 0; i < n; i++)
                    {
                        string SLAEline = "";
                        for (int j = 0; j < n; j++)
                        {
                            SLAEline += $"({slae.CoefficientMatrix[i, j].Real} + i * {slae.CoefficientMatrix[i, j].Imaginary}) * x{j + 1}";
                            if (j == n - 1)
                            {
                                SLAEline += " = ";
                            }
                            else
                            {
                                SLAEline += " + ";
                            }
                        }
                        SLAEline += $"({slae.FreeMembers[i].Real} + i * {slae.FreeMembers[i].Imaginary})";

                        sw.WriteLine(SLAEline);
                    }

                    if (slae.roots != null)
                    {
                        sw.WriteLine("Корені системи:");
                        for (int i = 0; i < n; i++)
                        {
                            sw.WriteLine($"x{i + 1} = " + slae.roots[i].Real.ToString("F6") + " + i " + slae.roots[i].Imaginary.ToString("F6"));
                        }
                    }
                    else
                    {
                        sw.WriteLine("Система не має коренів");
                    }
                    return true;
                }
            }
            catch (Exception ex) 
            {
                errorMessage = "Не вдалося записати рівняння у файл.";
                return false;
            }
        }

    }
}
