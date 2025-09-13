using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos.Utils
{
    public class GradenDesign
    {
        // GRADEN A BOTONES
        public void AplicarGradiente(Button boton, Color colorSuperior, Color colorInferior, LinearGradientMode direccion)
        {
            // Estilos básicos para personalizar el botón
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0; // Opcional: quita el borde estándar de Windows

            // Suscribimos el evento Paint SOLO una vez
            boton.Paint += (sender, e) =>
            {
                Button btn = (Button)sender;

                // Crear gradiente
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    btn.ClientRectangle,
                    colorSuperior,      // Color superior
                    colorInferior,      // Color inferior
                    direccion           // Dirección del gradiente
                ))
                {
                    // Dibujar fondo con gradiente
                    e.Graphics.FillRectangle(brush, btn.ClientRectangle);
                }

                // Dibujar texto centrado
                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    Color.White, // Color del texto
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            };
        }









    }
}
