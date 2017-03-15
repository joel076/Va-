using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public class FifteenPuzzle
{
    const int gridSize = 4;
    const bool evenSized = gridSize % 2 == 0;
    const int blockCount = gridSize * gridSize;
    const int last = blockCount - 1;
    const int buttonSize = 50;
    const int buttonMargin = 3;
    const int formEdge = 9;
    static readonly Random rnd = new Random();
    static readonly Font buttonFont = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
    readonly Button[] buttons = new Button[blockCount];
    readonly int[] grid = new int[blockCount];
    readonly int[] positionOf = new int[blockCount];
    int moves = 0;
    DateTime start;

    public static void Main(string[] args)
    {
        FifteenPuzzle p = new FifteenPuzzle();
        Form f = p.BuildForm();
        Application.Run(f);
    }

    public FifteenPuzzle()
    {
        for (int i = 0; i < blockCount; i++)
        {
            grid[i] = i;
            positionOf[i] = i;
        }
    }

    Form BuildForm()
    {
        Button startButton = new Button
        {
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            Size = new Size(86, 23),
            Location = new Point(formEdge,
                (buttonSize + buttonMargin * 2) * gridSize + buttonMargin + formEdge),
            Text = "New Game",
            UseVisualStyleBackColor = true
        };
        startButton.Click += (sender, e) => Shuffle();

        int size = buttonSize * gridSize + buttonMargin * gridSize * 2 + formEdge * 2;
        Form form = new Form
        {
            Text = "Fifteen",
            ClientSize = new Size(width: size, height: size + buttonMargin * 2 + startButton.Height)
        };
        form.SuspendLayout();
        for (int index = 0; index < blockCount; index++)
        {
            Button button = new Button
            {
                Font = buttonFont,
                Size = new Size(buttonSize, buttonSize),
                Text = (index + 1).ToString(),
                UseVisualStyleBackColor = true
            };
            SetLocation(button, index);
            form.Controls.Add(button);
            buttons[index] = button;
            int i = index;
            button.Click += (sender, e) => ButtonClick(i);
        }
        form.Controls.Add(startButton);
        form.ResumeLayout();
        return form;
    }

    void ButtonClick(int i)
    {
        if (buttons[last].Visible) return;
        int target = positionOf[i];
        if (positionOf[i] / gridSize == positionOf[last] / gridSize)
        {
            while (positionOf[last] < target)
            {
                Swap(last, grid[positionOf[last] + 1]);
                moves++;
            }
            while (positionOf[last] > target)
            {
                Swap(last, grid[positionOf[last] - 1]);
                moves++;
            }
        }
        else if (positionOf[i] % gridSize == positionOf[last] % gridSize)
        {
            while (positionOf[last] < target)
            {
                Swap(last, grid[positionOf[last] + gridSize]);
                moves++;
            }
            while (positionOf[last] > target)
            {
                Swap(last, grid[positionOf[last] - gridSize]);
                moves++;
            }
        }
        if (Solved())
        {
            TimeSpan elapsed = DateTime.Now - start;
            elapsed = TimeSpan.FromSeconds(Math.Round(elapsed.TotalSeconds, 0));
            buttons[last].Visible = true;
            MessageBox.Show($"Solved in {moves} moves. Time: {elapsed}");
        }
    }

    bool Solved() => Enumerable.Range(0, blockCount - 1).All(i => positionOf[i] == i);

    static void SetLocation(Button button, int index)
    {
        int row = index / gridSize, column = index % gridSize;
        button.Location = new Point
        (
        (buttonSize + buttonMargin * 2) * column + buttonMargin + formEdge,
        (buttonSize + buttonMargin * 2) * row + buttonMargin + formEdge
        );
    }

    void Shuffle()
    {
        for (int i = 0; i < blockCount; i++)
        {
            int r = rnd.Next(i, blockCount);
            int g = grid[r];
            grid[r] = grid[i];
            grid[i] = g;
        }
        for (int i = 0; i < blockCount; i++)
        {
            positionOf[grid[i]] = i;
            SetLocation(buttons[grid[i]], i);
        }
        if (!Solvable()) Swap(0, 1);

        buttons[last].Visible = false;
        moves = 0;
        start = DateTime.Now;
    }

    bool Solvable()
    {
        bool parity = true;
        for (int i = 0; i < blockCount - 2; i++)
        {
            for (int j = i + 1; j < blockCount - 1; j++)
            {
                if (positionOf[j] < positionOf[i]) parity = !parity;
            }
        }
        if (evenSized && positionOf[last] / gridSize % 2 == 0) parity = !parity;
        return parity;
    }

    void Swap(int a, int b)
    {
        Point location = buttons[a].Location;
        buttons[a].Location = buttons[b].Location;
        buttons[b].Location = location;

        int p = positionOf[a];
        positionOf[a] = positionOf[b];
        positionOf[b] = p;

        grid[positionOf[a]] = a;
        grid[positionOf[b]] = b;
    }

}
