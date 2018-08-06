using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using System.Windows.Forms;


namespace Mp3Player
{
    public partial class Mp3Player : Form
    {
        public Mp3Player()
        {
            InitializeComponent();
        }

        private void Mp3Player_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ファイル選択ダイアログボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDialog_Click(object sender, EventArgs e)
        {
            //ダイアログボックスを表示
            DialogResult dialog = openFileDialog1.ShowDialog();
            //ダイアログボックスでOKが選択された場合、ダイアログボックスに選択された名前を表示
            if(dialog == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.FileName;
            }
        }



        class ShowID3Tags
        {
            static void Tags()
            {
                ShellClass shell = new ShellClass();

                string dir = @"C:\mp3"; // MP3ファイルのあるディレクトリ
                string file = "";

                Folder f = shell.NameSpace(dir);
                FolderItem item = f.ParseName(file);
            }
        }

    }
}
