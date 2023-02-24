using WinFormMarqee.Controls;

namespace WinFormMarqee;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MarqueeLabel MLable = new MarqueeLabel(20)
        {
            AutoSize = false,
            Location = new System.Drawing.Point(12, 12),
            BackColor = System.Drawing.Color.AntiqueWhite,
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            FlatStyle = System.Windows.Forms.FlatStyle.Flat,
            Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
            ForeColor = System.Drawing.Color.Green,
            Name = "lblMarquee",
            Size = new System.Drawing.Size(776, 45),
            TabIndex = 0,
            Text = "This is a test of the Emergency Webcast System.    This is only a test.    Do not pass Go!    Do not collect $200!"
        };
        this.Controls.Add(MLable);
    }
}
