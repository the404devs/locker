using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Locker
{
    public partial class FolderPicker : Form
    {
        public FolderPicker()
        {
            InitializeComponent();
        }

        /*Method to open/close nodes*/
        private void toggle(TreeNode node)
        {
            if (node == null) return;//failsafe
            if (node.IsExpanded)//Expand it if it's collapses and vice versa
            {
                node.Collapse();
            }
            else
            {
                node.Expand();
            }
        }

        /*Method to create the directory tree*/
        private TreeNode traverseDir(string path)
        {
            //This is identical to the one in the main window, except here we don't bother looking at files
            TreeNode result = new TreeNode(path);
            foreach (var subdir in Directory.GetDirectories(path))
            {
                TreeNode node = traverseDir(subdir);
                node.Text = new DirectoryInfo(subdir).Name;
                node.Tag = subdir;
                node.NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                result.Nodes.Add(node);
            }
            result.Text = "Locker";
            result.Name = "Locker";
            result.Tag = path;
            result.NodeFont = new Font(treeView1.Font, FontStyle.Bold);
            return result;
        }

        /*Action when the form loads*/
        private void FolderPicker_Load(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata
            this.treeView1.Nodes.Add(traverseDir(appData + "\\.locker"));//begin creating directory tree
            this.treeView1.Nodes[0].Expand();//expand the top-level node
        }

        /*When a node is clicked*/
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeView1.SelectedNode = e.Node;//Select that node
        }

        /*When a key is pressed*/
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            if (node == null) return;
            if (e.KeyCode==Keys.Enter)//Enter
            {
                if (node.Nodes.Count==0)//If its a dir with no subdirs
                {
                    btnDone.PerformClick();//We assume this is the directory they want
                }
                else
                {
                    toggle(node);//Otherwise just toggle it
                }
            }
        }
    }
}
