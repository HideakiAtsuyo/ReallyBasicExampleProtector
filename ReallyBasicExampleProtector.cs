using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crayon;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using MaterialSkin;
using MaterialSkin.Controls;
using ReallyBasicExampleProtector.Core.Protections;

namespace ReallyBasicExampleProtector
{
    public partial class ReallyBasicExampleProtector : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private void ReallyBasicExampleProtector_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ReallyBasicExampleProtector_DragDrop(object sender, DragEventArgs e)
        {
            string[] HelloWorld = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Stuff.verifyIfAllowed(HelloWorld[0]))
                FileToProtectHATB.Text = HelloWorld[0];
        }
        private void ReallyBasicExampleProtector_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeStuff.ReleaseCapture();
                NativeStuff.SendMessage(Handle, NativeStuff.WM_NCLBUTTONDOWN, NativeStuff.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                //if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
#if !DEBUG
        private void ReallyBasicExampleProtector_Activated(object sender, EventArgs e)
        {
            Program.ReallyBasicExampleProtector.Shown += (x, y) => {
                Thread z = new Thread(() => {
                    MessageBox.Show("Browse or Drag & Drop the file to the Form", Settings.MBHATitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
                z.Priority = ThreadPriority.Highest;
                z.Start();
                z.Join();
            };
        }
#endif
        public ReallyBasicExampleProtector()
        {
            InitializeComponent();
            /* Initialize MaterialSkinManager */
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //Dark Theme >>>>>>>>>>>>>> Light Theme..
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.BLACK); //Looks better like this for me :)
            /* Initialize MaterialSkinManager */
            this.DragDrop += ReallyBasicExampleProtector_DragDrop;
            this.DragEnter += ReallyBasicExampleProtector_DragEnter;
#if !DEBUG
            this.Activated += ReallyBasicExampleProtector_Activated;
#endif
            this.MouseDown += ReallyBasicExampleProtector_MouseDown;
        }

        private void BrowserFileHABTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog HAOFD = new OpenFileDialog())
            {
                HAOFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                HAOFD.RestoreDirectory = true;
                HAOFD.Title = "Select The File To Protect";
                HAOFD.Filter = "EXE Files (*.exe)|*.exe|DLL Files (*.dll)|*.dll";
                HAOFD.CheckPathExists = true;
                HAOFD.CheckFileExists = true;
                DialogResult res = HAOFD.ShowDialog();
                if (res == DialogResult.OK)
                {
                    FileToProtectHATB.Text = HAOFD.FileName;
                }

            }
        }
        private void ProtectFileHABTN_Click(object sender, EventArgs e)
        {
            string filePath = FileToProtectHATB.Text;
            if(filePath == null)
            {
                MessageBox.Show("The File Path Is Empty..");
                return;
            }
            
            string fileName = Stuff.getFileName(filePath);
            string output = filePath.Replace(fileName, fileName.Replace(".exe", "-fucked.exe").Replace(".dll", "-fucked.dll"));

            if (!Stuff.verifyIfExist(filePath) || !Stuff.verifyIfAllowed(filePath))
                return;
            
            var Module = ModuleDefMD.Load(filePath);
            NativeStuff.ShowWindow(NativeStuff.consoleHandle, 5);
            /* Stuff */
            Logger.Info("Some protections are not made for DLLs so they'll not be applied !");

            if (ProxyStringsHACB.Checked)
                ProxyStrings.Execute(Module);

            if (ProxyINTHACB.Checked)
                ProxyINT.Execute(Module);

            if (ROTStringsHACB.Checked)
                ROTStrings.Execute(Module);


            if (AntiDebugHACB.Checked)
                AntiDebug.Execute(Module);

            if (AntiDumpHACB.Checked)
                AntiDump.Execute(Module);

            if (CalliINTHACB.Checked)
                Calli.Execute(Module);

            if (HideMethodsHACB.Checked)
                HideMethods.Execute(Module);

            if (RenamerHACB.Checked)
            {
                MessageBox.Show("Broken Renamer");
                DialogResult result = MessageBox.Show("Random names ?", "ReallyBasicExampleProtector", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Settings.randomRenaming = true;
                else if(result == DialogResult.No)
                    Settings.randomRenaming = false;

                DialogResult result2 = MessageBox.Show("Encode the names (Base64)?", "ReallyBasicExampleProtector", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                    Settings.b64Names = true;
                else if (result2 == DialogResult.No)
                    Settings.b64Names = false;

                Renamer.Execute(Module);
            }
            
            try
            {
                Module.Write(output);
                Logger.Info(String.Format("File {0} protected with success !", Output.Green(Stuff.getFileName(fileName))));
            }
            catch (Exception ex)
            {
                Logger.Info(String.Format("Failed to protect {0} !\nError: {1}", Output.Green(Stuff.getFileName(fileName)), Output.Red(ex.Message)));
                Console.ReadLine();
                Environment.Exit(-1);
            }
            /* Stuff */

            Console.ReadLine();
            NativeStuff.ShowWindow(NativeStuff.consoleHandle, 0);
            Console.Clear();
        }
    }
}
