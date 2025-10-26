using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int _cornerRadius = 15;
    private Color _borderColor = Color.Gray;
    private float _borderWidth = 1f;

    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            this.Invalidate(); // Redesenha o controle quando o valor muda
        }
    }

    public Color BorderColor
    {
        get { return _borderColor; }
        set
        {
            _borderColor = value;
            this.Invalidate();
        }
    }
    public float BorderWidth
    {
        get { return _borderWidth; }
        set
        {
            _borderWidth = value;
            this.Invalidate();
        }
    }

    // Método que é chamado sempre que o controle precisa ser desenhado
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e); // Chama o método da classe base

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; // Para bordas mais suaves

        // Retângulo que representa a área do painel
        Rectangle rect = this.ClientRectangle;

        // Cria o caminho (path) com os cantos arredondados
        using (GraphicsPath path = GetRoundedRectPath(rect, _cornerRadius))
        {
            // Define a região do controle para o formato do caminho.
            // Isso faz com que os cantos fiquem transparentes.
            this.Region = new Region(path);

            // Desenha a borda ao longo do caminho
            using (Pen pen = new Pen(_borderColor, _borderWidth))
            {
                // Para a borda não ser cortada, ajustamos o retângulo ligeiramente
                // A divisão por 2 centraliza a linha da borda
                Rectangle borderRect = new Rectangle(
                    rect.X, rect.Y,
                    rect.Width - (int)System.Math.Ceiling(_borderWidth),
                    rect.Height - (int)System.Math.Ceiling(_borderWidth));

                using (var borderPath = GetRoundedRectPath(borderRect, _cornerRadius))
                {
                    g.DrawPath(pen, borderPath);
                }
            }
        }
    }

    // Método auxiliar para criar o caminho do retângulo com cantos arredondados
    private GraphicsPath GetRoundedRectPath(Rectangle rect, int cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();

        // Garante que o raio não seja maior que o próprio controle
        int diameter = cornerRadius * 2;
        if (diameter > rect.Width) diameter = rect.Width;
        if (diameter > rect.Height) diameter = rect.Height;

        // Cria o caminho
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Canto superior esquerdo
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Canto superior direito
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Canto inferior direito
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Canto inferior esquerdo
        path.CloseFigure();

        return path;
    }
}

