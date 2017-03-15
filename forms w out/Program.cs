using System;
using System.Collections.Generic;
using static System.Collections.IEnumerable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class Program
{
    const int gridSize = 4;
    const bool evenSized = gridSize % 2 == 0;
    const int blockCount = gridSize * gridSize;
    const int last = blockCount - 1;
    const int buttonSize = 50;
    const int buttonMargin = 3;
    const int formEdge = 9;


  

    public static void Main(string[] args)
    {
        Program p = new Program();
        Form f = p.BuildForm();
        Application.Run(f);
    }

    Form BuildForm()
    {
        RichTextBox rtb = new RichTextBox
        {
            Size = new Size(500, 400),
            Location = new Point(0,100)
        };

        ToolStripContainer toolStripContainer1 = new ToolStripContainer
        {
            Location = new Point(0, 0),
            
        };

        ToolStrip toolStrip1 = new ToolStrip()
        {
        System.Collections.IEnumerable.toolStrip1.Items.Add("One")
        //toolStrip1.Items.Add("Two"),
        //toolStrip1.Items.Add("Three"),
        // Add the ToolStrip to the top panel of the ToolStripContainer.
        //toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1)
        };
      
        Form form = new Form
        {
            Text = "Program",
            ClientSize = new Size(width: 500, height: 500)
        };

        //Control.Add(toolStripContainer1);
        form.Controls.Add(toolStrip);
        form.Controls.Add(rtb);
        form.ResumeLayout();
        return form;
    }
    
}
