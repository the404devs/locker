using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Locker
{
    public partial class LockerView : Form
    {
        public LockerView()
        {
            InitializeComponent();
        }

        /*Method to expand/collapse a node*/
        private void toggle(TreeNode node)
        {
            if (node == null) return;//In case the function is called without a node selected
            if (node.IsExpanded)
            {
                node.Collapse();//if it's expanded we collapse it
            }
            else
            {
                node.Expand();//if its collapsed we expand it
            }
        }

        private void refreshTree()
        {
            this.treeView1.Nodes.Clear();
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            this.treeView1.Nodes.Add(traverseDir(appData + "\\.locker"));
            this.treeView1.Nodes.Remove(this.treeView1.Nodes.Find(appData + "\\.locker\\pass.txt", true)[0]);
            this.treeView1.Nodes[0].Expand();
        }

        /*Method to create a listing of the Locker recursively*/
        private TreeNode traverseDir(string path)
        {
            TreeNode result = new TreeNode(path);//Create the first node (.locker folder)
            //Get each file in the current directory
            foreach (var file in Directory.GetFiles(path))
            {
                TreeNode node = new TreeNode(file);//Create a node for the file
                node.Name = file;//Node's name is the file's path (C:\file.txt)
                node.Text = Path.GetFileName(file);//Node's text is the file's name (file.txt)
                result.Nodes.Add(node);//Add it as a child to the parent
            }
            //Get each subdirectory in the current directory
            foreach (var subdir in Directory.GetDirectories(path))
            {
                TreeNode node = traverseDir(subdir);//Create a node for the subdir
                //This calls the function recursively, getting the subdir's files and subdirs
                node.Text = new DirectoryInfo(subdir).Name;//Node's text is the directory's name (Documents)
                node.Tag = subdir;//Node's tag is the directory's path (C:\Documents)
                node.NodeFont = new Font(treeView1.Font, FontStyle.Bold);//We make the directory nodes bold to make them stand out     
                result.Nodes.Add(node);//Add the node as a child to the parent
            }
            result.Text = "Locker";//Top node's text and name is "Locker"
            result.Name = "Locker";//This makes it easily identifiable 
            result.Tag = path;//Top node's tag is the actual path to the .locker folder
            result.NodeFont = new Font(treeView1.Font, FontStyle.Bold);//Make it bold as well
            return result;//return our completed directory tree
        }

        /*Load event of the form*/
        private void LockerView_Load(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//Path to user's appdata dir
            this.treeView1.Nodes.Add(traverseDir(appData+"\\.locker"));//create the directory tree of the .locker folder
            this.treeView1.Nodes.Remove(this.treeView1.Nodes.Find(appData+"\\.locker\\pass.txt", true)[0]);//remove the node of the pass.txt file, they don't need to know it's there
            this.treeView1.Nodes[0].Expand();//Expand the top-level node (.locker)
        }

        /*Double-click event of the treeView*/
        private void treeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;//Get the clicked node
            if (node == null) return;//Failsafe in case this method gets called when no node is selected
            if (node.Nodes.Count == 0 && node.Tag == null)//Check if it's a file node
            {
                string filePath = node.Name;//Get the path to the file
                System.Diagnostics.Process.Start(filePath);//Open it
            }
            //We don't need any code for if it's a folder node, because all we'd do is expand the node. 
            //TreeView contorls natively do that on double-clicks, so we're good.
            //We also don't need to worry about file nodes being expanded, because they never have any children
        }

        /*Various key press actions*/
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)//F2 (rename)
            {
                btnRename_Click(sender, e);//Click the reanme button, starting the rename process
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)//Delete or Backspace
            {
                btnDelete_Click(sender, e);//Click the delete button, starting the delete process
            }
            else if (e.KeyCode == Keys.Enter)//Enter
            {
                btnOpen_Click(sender, e);//Click the open button. Will then either open the file or toggle the node
            }
            else if (e.KeyCode == Keys.F5)//F5
            {
                refreshTree();//refresh the directory tree. Secret option, i guess.
            }
            else if (e.KeyCode == Keys.Add)//Plus
            {
                this.treeView1.ExpandAll();//expand everything
            }
            else if (e.KeyCode == Keys.OemMinus)//Minus
            {
                this.treeView1.CollapseAll();//Collapse everything
            }
        }

        /*Click event of the open button*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//Get the selected node
            if (node == null) return;//failsafe
            if (node.Nodes.Count == 0 && node.Tag == null)//If file node
            {
                string filePath = node.Name;//Get path to file
                System.Diagnostics.Process.Start(filePath);//open file
            }
            else//else folder node
            {
                toggle(node);//expand/collapse node
            }
        }

        /*Click event for the rename button*/
        private void btnRename_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//Get selected node
            if (node == null) return;//Failsafe
            if (node != this.treeView1.Nodes[0])//Make sure its not the .locker node
            {
                if (node.Nodes.Count == 0 && node.Tag == null)//Check if its a file
                {
                    Rename ren = new Rename();//Instance of Rename form
                    if (ren.ShowDialog(this) == DialogResult.OK)//Action once rename form closes
                    {
                        string newName = ren.txtName.Text;//Get the name they typed
                        if (newName == "Locker")//Check if they tried to call it "Locker"
                        {
                            MessageBox.Show("Name cannot be \"Locker\"!");
                        }
                        else if (newName != "")//Make sure name isn't empty
                        {
                            if (newName.LastIndexOf(".") == -1)//If there's no dot (they didn't give a file extension)
                            {
                                string ext = node.Name.Substring(node.Name.LastIndexOf("."));//Figure out the extension on the old name, we'll keep it
                                string oldName = node.Name;//Store the old name
                                node.Text = newName + ext;//Create the new name from their provided name plus the old extension
                                node.Name = node.Name.Substring(0, node.Name.LastIndexOf("\\")) + "\\" + newName + ext;//Create the new path to the file
                                try
                                { 
                                    File.Move(oldName, node.Name);//"Move" the file from it's old location to the new. This will rename it
                                }
                                catch (Exception ex)//If something goes wrong...
                                {
                                    MessageBox.Show("Couldn't rename file.\nReason: " + ex.Message);
                                }                                
                            }
                            else//Rename with a new file extension
                            {
                                string oldName = node.Name;//Store the old name
                                node.Text = newName;//Give the node the new name
                                node.Name = node.Name.Substring(0, node.Name.LastIndexOf("\\")) + "\\" + newName;//Create the new path
                                try
                                {
                                    File.Move(oldName, node.Name);//"Move" it in order to rename it
                                }
                                catch (Exception ex)//If they meet with a terrible fate...
                                {
                                    MessageBox.Show("Couldn't rename file.\nReason: " + ex.Message);
                                }
                            }
                        }
                        else//The provided name was blank
                        {
                            MessageBox.Show("File name cannot be blank!");
                        }
                    }
                }
                else if (node.Tag != null)//Check if it's a folder
                {
                    Rename ren = new Rename();//New instance of the rename form
                    if (ren.ShowDialog(this) == DialogResult.OK)//Action once rename form closes
                    {
                        string newName = ren.txtName.Text;//Get the name they gave us
                        if (newName != "")//If it's not blank
                        { 
                            string oldPath = node.Tag.ToString();//Store the old path
                            node.Text = newName;//Give the node the new name
                            node.Tag = node.Tag.ToString().Substring(0, node.Tag.ToString().LastIndexOf("\\")) + "\\" + newName;  //Change the node's path to reflect the new name                          
                            try
                            {
                                Directory.Move(oldPath, node.Tag.ToString());//Actually rename the directory
                            }
                            catch (Exception ex)//If Thanos snaps his fingers
                            {
                                MessageBox.Show("Couldn't rename folder.\nReason: " + ex.Message);
                            }
                        }
                        else//They gave us a blank name, didn't they?
                        {
                            MessageBox.Show("Folder name cannot be blank!");
                        }
                    }
                }
            }
            else//They tried to rename the .locker node. We can't let them do that!
            {
                MessageBox.Show("You can't do that!");
            }                
        }

        /*Click event for the delete button*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//Get the selected node
            if (node == null) return;//failsafe
            if (node != this.treeView1.Nodes[0])//Make sure they're not trying to delete the .locker node
            {
                DialogResult dr = MessageBox.Show("Are you sure about this?", "Delete File", MessageBoxButtons.YesNo);//Make sure they're willing to commit to this
                if (dr == DialogResult.Yes)//They said yes, so lets do it
                {
                    if (node.Nodes.Count == 0 && node.Tag == null)//If it's a file
                    {
                        try
                        {
                            File.Delete(node.Name);//Delete the file
                            node.Remove();//Remove it's corresponding node
                        }
                        catch (Exception ex)//If everything isn't going according to plan
                        {
                            MessageBox.Show("Couldn't delete file.\nReason: " + ex.Message);
                        }    
                    }
                    else if (node.Tag != null)//If it's a folder
                    {
                        try
                        {
                            Directory.Delete(node.Tag.ToString(), true);//Delete the folder. true means delete stuff inside too
                            node.Remove();//Remove it's node
                        }
                        catch (Exception ex)//If the stars are alligned against us
                        {
                            MessageBox.Show("Couldn't delete folder.\nReason: " + ex.Message);
                        }                  
                    }
                }
            }
            else//They tried to delete the entire locker folder. I went through the trouble of creating a button specifically for that, so there's no way it's gonna happen here.
            {
                MessageBox.Show("You can't do that!");
            }
        }

        /*Action when the form is closed*/
        private void LockerView_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Application.Exit();//Kill the entire applicaton, since this isn't the main form
        }

        /*Action when the add file button is clicked*/
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//Show a dialog allowing them to pick a file. Proceed once they make up their mind
            {
                string fileName = openFileDialog1.FileName;//Get the name (path, actually) of the file they want to add
                TreeNode node = this.treeView1.SelectedNode;//Get the currently selected node. This determines where we put the file
                if (node == null) return;//Failsafe
                if (node.Nodes.Count == 0 && node.Tag == null)//check if file is selected
                {
                    node = node.Parent;//If it's a file we assume they want to put the new file in the same folder as the one that is selected, so we switch to the file's parent node
                    string newName = node.Tag.ToString() + "\\" + fileName.Substring(fileName.LastIndexOf("\\")+1);//Get the path to the destination folder
                    try
                    {
                        File.Copy(fileName, newName);//Copy the chosen file to the destination
                    }
                    catch (Exception ex)//If our efforts are in vain
                    {
                        MessageBox.Show("Couldn't add file.\nReason: " + ex.Message);
                    }
                }
                else if (node.Tag != null)//check if folder is selected
                {
                    string newName = node.Tag.ToString() + "\\" + fileName.Substring(fileName.LastIndexOf("\\")+1);//Get the path of the file's destination
                    try
                    {
                        File.Copy(fileName, newName);//Create a clone of the file and put it into its new home against it's will
                    }
                    catch (Exception ex)//If the file puts up a fight and refuses to be copied
                    {
                        MessageBox.Show("Couldn't add file.\nReason: " + ex.Message);
                    }
                }
                else//if it's root folder
                {
                    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata fodler
                    string newName = appData + "\\.locker\\" + fileName.Substring(fileName.LastIndexOf("\\") + 1);//create our destination path (.locker)
                    try
                    {
                        File.Copy(fileName, newName);//Send it on it's merry way
                    }
                    catch (Exception ex)//If it's the Grinch and refuses to be merry, even at Christmas
                    {
                        MessageBox.Show("Couldn't add file.\nReason: " + ex.Message);
                    }
                }
                refreshTree();//Recreate our directory tree, since there is something new that we need to show
            }
        }

        /*Click event for the save file button*/
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//Get the selected node
            if (node == null) return;//Failsafe
            saveFileDialog1.FileName = node.Name;//Give the save dialog the name of the selected file 
            if (node.Nodes.Count == 0 && node.Tag == null)//check if file is selected
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)//If they truly wish to save a copy of the file outside of their locker
                {                    
                    try
                    {
                        File.Copy(node.Name, saveFileDialog1.FileName);//Save a copy of the file outside of their locker
                    }
                    catch (Exception ex)//If something happens due to circumstances beyond our control
                    {
                        MessageBox.Show("Couldn't save file.\nReason: " + ex.Message);
                    }
                }
            }
            else//If they don't have a file selected
            {
                MessageBox.Show("Please select a file first!");
            }            
        }

        /*Click event for the new folder button*/
        private void btnNewDir_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//Get the selected node
            if (node == null) return;//Failsafe
            Rename ren = new Rename();//We reuse the rename form for this action too, since it has everything we need
            ren.Text = "Create new folder...";//We just change some of the text to suit it's new purpose
            ren.label1.Text = "Enter name for the new folder...";
            ren.label1.Location = new Point(5,11);
            if (node.Nodes.Count == 0 && node.Tag == null)//check if file is selected
            {
                node = node.Parent;//Get the parent of the file node, assuming that they want this new folder in the same directory as the selected file
            }
            if (ren.ShowDialog(this) == DialogResult.OK)//Once they've settled on a name for their new folder
            {
                string dirName = ren.txtName.Text;//Get the name they want
                if (dirName=="Locker")//If they've tried to name the folder "Locker"
                {
                    MessageBox.Show("Folder name cannot be \"Locker\"!");//This could cause some confusion
                }
                else if (dirName!="")//Make sure the name isn't empty
                {
                    string parnetPath = node.Tag.ToString();//Get the path to the parent directory                  
                    try
                    {
                        Directory.CreateDirectory(parnetPath + "\\" + dirName);//Create the new directory
                    }
                    catch (Exception ex)//If the heavens dost command we shall not
                    {
                        MessageBox.Show("Couldn't create folder.\nReason: " + ex.Message);
                    }
                }
                else//They gave us a blank name. 
                {
                    MessageBox.Show("Folder name cannot be blank!");
                }
            }
            refreshTree();//Recreate our directory tree to reflect the changes
        }

        /*Click event for the password button*/
        private void btnPassChange_Click(object sender, EventArgs e)
        {
            PassChange pc = new PassChange();//Show our dedicated password-changing form
            if (pc.ShowDialog(this) == DialogResult.OK)//Once they've finsihed with the form
            {
                if (pc.txtNew.Text != "")//Make sure there actually IS a new password
                {
                    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//PAth to appdata folder
                    try
                    {
                        StreamReader sr = new StreamReader(appData + "/.locker/pass.txt");//Access our super-secret pass.txt file
                        if (pc.txtOld.Text == sr.ReadLine())//if what they said was the old password matches what the old password acrtually is
                        {
                            sr.Close();//Stop reading pass.txt so we can write to it
                            StreamWriter sw = new StreamWriter(appData + "/.locker/pass.txt");
                            sw.WriteLine(pc.txtNew.Text);//Write the new password to the file
                            sw.Close();//Stop writing to the file
                            MessageBox.Show("Password changed successfully.");//Tell them everything went better than expected
                        }
                        else//The old password didn't match the one on file
                        {
                            sr.Close();//Stop reading from the file
                            MessageBox.Show("Original password was incorrect.\nTry again.");//Tell them they screwed up
                        }
                    }
                    catch(FileNotFoundException ex)
                    {
                        try
                        {
                            StreamWriter sw = new StreamWriter(appData + "/.locker/pass.txt");//begin writing to pass.txt
                            sw.WriteLine(pc.txtNew.Text);//write it to the file
                            sw.Close();//stop writing to the file
                            MessageBox.Show("You don't appear to have a password set.\nDid you delete the password file? ( ͡° ͜ʖ ͡°)\n\nDoesn't matter. We've just made the text you inputted your new password.");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Couldn't change password.\nReason: " + ex.Message);
                        }                        
                    }
                    catch (Exception ex)//If fate isn't on our side
                    {
                        MessageBox.Show("Couldn't change password.\nReason: " + ex.Message);
                    }                           
                }
                else//They tried to make their new password blank. 
                {
                    MessageBox.Show("New password cannot be blank!");
                }
            }
        }

        /*Click event for the expand all button*/
        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.treeView1.ExpandAll();//expand everything
        }

        /*Click event for the collapse all button*/
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.treeView1.CollapseAll();//collapse everything
        }

        /*Click event for the empty button*/
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to empty your locker?\nThis will permanently delete all of the files contained in your locker.\nThis cannot be undone.", "Reset Locker", MessageBoxButtons.YesNo);//Is this what they wanted to do, or are they just curious?
            if(dr == DialogResult.Yes)//If they understand what the consequences of their actions will be
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata folder
                try
                {
                    Directory.Delete(appData + "\\.locker", true);//locker clean out time. true means recursively delete all of the contents
                    MessageBox.Show("Success!\nLocker will now close.");//All done!
                    Application.Exit();//We're outta here
                }
                catch (Exception ex)//If something goes wrong that is entirely not our fault, I swear
                {
                    MessageBox.Show("Couldn't empty Locker.\nReason: " + ex.Message);
                }                
            }
        }

        /*Click event for the help button*/
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have encountered a problem with this application, please contact me via my website, the404.ml");
        }
        
        /*Click event for the about button*/
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Locker: Version 1.0.1\n09/27/18\nOwen Goodwin\nthe404.ml");
        }

        /*Click event for the move button*/
        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;//get the selected node
            if (node == null) return;//failsafe
            if (node.Nodes.Count == 0 && node.Tag == null)//If it's a file
            {
                FolderPicker fp = new FolderPicker();//Instance of our folder picker form
                if (fp.ShowDialog(this) == DialogResult.OK)//Once they choose a folder
                {
                    string newPath = fp.treeView1.SelectedNode.Tag.ToString();//This is the path to the destination folder
                    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata
                    string selectedFileName = node.Text;//Get the name of the file they want to move
                    string selectedFilePath = node.Name;//Get the path to the file they want to move
                    try
                    {
                        File.Move(selectedFilePath, newPath + "\\" + selectedFileName);//I like to move it move it
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't move file.\nReason: " + ex.Message);
                    }                    
                    refreshTree();//Refresh our directory tree
                }
            }
            else if (node.Tag != null && node.Text != "Locker")//if its a folder
            {
                FolderPicker fp = new FolderPicker();//Instance of our folder picker form
                if (fp.ShowDialog(this) == DialogResult.OK)//Once they choose a folder
                {
                    string newPath = fp.treeView1.SelectedNode.Tag.ToString();//Get path to the directory they wish to move to
                    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata
                    string selectedFileName = node.Text;//Get the name of the directory they wish to move
                    string selectedFilePath = node.Tag.ToString();//Get the path to the directory they wish to move              
                    try
                    {
                        Directory.Move(selectedFilePath, newPath + "\\" + selectedFileName);//Moving day
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't move folder.\nReason: " + ex.Message);
                    }
                    refreshTree();//refresh the directory tree
                }
            }
            else//if they try and move the root directory (.locker)
            {
                MessageBox.Show("You can't do that!");
            }
            
        }
    }
}