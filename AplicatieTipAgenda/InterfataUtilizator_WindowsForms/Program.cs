using System;
using System.Windows.Forms;

public class MyForm : Form
{
    private Label lblTitlu;
    private Label lblNume;

    public MyForm()
    {
        // Inițializare și configurare lblTitlu
        lblTitlu = new Label();
        lblTitlu.Text = "Titlu:";
        lblTitlu.Top = 20;  // Poziția verticală
        lblTitlu.Left = 20; // Poziția orizontală
        lblTitlu.AutoSize = true; // Ajustează dimensiunea textului

        // Inițializare și configurare lblNume
        lblNume = new Label();
        lblNume.Text = "Nume:";
        lblNume.Top = 50;  // Poziția verticală sub lblTitlu
        lblNume.Left = 20; // Aceeași aliniere la stânga
        lblNume.AutoSize = true;

        // Adăugarea controalelor pe formă
        this.Controls.Add(lblTitlu);
        this.Controls.Add(lblNume);

        // Setări opționale pentru formă
        this.Text = "Exemplu Form";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new System.Drawing.Size(300, 200);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MyForm());
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(1039, 607);
            this.Name = "MyForm";
            this.ResumeLayout(false);

    }
}
