using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents;
using MapleLib.WzLib;

namespace HaCreator.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WzFile f = new WzFile(@"D:\MapleStory\Character.wz", WzMapleVersion.GMS);
            f.ParseWzFile();
            TreeNode node = new TreeNode(f.Name);
            treeViewMS1.Nodes.Add(node);
            R(node, f.WzDirectory);
            TreeNode node2 = new TreeNode(f.Name);
            treeView1.Nodes.Add(node2);
            R(node2, f.WzDirectory);

        }

        private void R(TreeNode node, WzDirectory dir)
        {
            foreach (WzDirectory subdir in dir.WzDirectories)
            {
                TreeNode newNode = new TreeNode(subdir.Name);
                node.Nodes.Add(newNode);
                R(newNode, subdir);
            }
            foreach (WzImage img in dir.WzImages)
            {
                TreeNode newNode = new TreeNode(img.Name);
                node.Nodes.Add(newNode);
            }
        }
    }
}
