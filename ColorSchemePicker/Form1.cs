using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorSchemePicker
{
    public partial class ColorSchemePickerForm : Form
    {
        private static class ColorConversion
        {
            public static Color RGBToColor(double red, double green, double blue)
            {
                return Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
            }
            public static Color HSVToColor(double hue, double sat, double val)
            {
                double var_hue, var_1 = val, var_2 = val, var_3 = val;
                int var_i;

                hue /= 3.6;

                if (sat != 0)
                {
                    var_hue = hue * 6;
                    var_i = (int)Math.Floor(var_hue);
                    var_1 = val * (1 - sat);
                    var_2 = val * (1 - sat * (var_hue - var_i));
                    var_3 = val * (1 - sat * (1 - (var_hue - var_i)));

                    switch (var_i)
                    {
                        case 0: return ColorConversion.RGBToColor(val, var_3, var_1);
                        case 1: return ColorConversion.RGBToColor(var_2, val, var_1);
                        case 2: return ColorConversion.RGBToColor(var_1, val, var_3);
                        case 3: return ColorConversion.RGBToColor(var_1, var_2, val);
                        case 4: return ColorConversion.RGBToColor(var_3, var_1, val);
                        default: return ColorConversion.RGBToColor(val, var_1, var_2);
                    }
                }
                return RGBToColor(var_1, var_2, var_3);
            }
            public static void ColorToHSV(Color color, out double hue, out double sat, out double val)
            {
                double
                    r = color.R / (double)255,
                    g = color.G / (double)255,
                    b = color.B / (double)255;

                double minVal = Math.Min(Math.Min(r, g), b);
                double maxVal = Math.Max(Math.Max(r, g), b);
                double delta = maxVal - minVal;

                hue = 0;
                sat = 0;
                val = maxVal;

                if (delta != 0)
                {
                    sat = delta / (double)maxVal;
                    double del_R = (((maxVal - r) / 6d) + (delta / 2d)) / delta;
                    double del_G = (((maxVal - g) / 6d) + (delta / 2d)) / delta;
                    double del_B = (((maxVal - b) / 6d) + (delta / 2d)) / delta;

                    if (r == maxVal) { hue = del_B - del_G; }
                    else if (g == maxVal) { hue = (1 / 3d) + del_R - del_B; }
                    else if (b == maxVal) { hue = (2 / 3d) + del_G - del_R; }

                    if (hue < 0) { ++hue; }
                    if (hue > 1) { --hue; }
                }

                hue *= 3.6;
            }
            /// <summary>
            /// Inverse color by RGB values.
            /// If the original color and the inversed color are too similar RGB within &lt;0,4e6&gt; change the new color to yellow.
            /// </summary>
            /// <param name="color">Color to be inversed</param>
            /// <returns>Inversed color or yellow</returns>
            public static Color InverseColor(Color color)
            {
                Color newColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                if (Math.Abs(newColor.ToArgb() - color.ToArgb()) < 4e6)
                {
                    newColor = Color.Yellow;
                }
                return newColor;
            }
        }
        // Color schemes
        private class Scheme
        {
            private double[] baseSL, contrastSL;
            private string text;

            public string Text
            {
                get
                {
                    return text;
                }
            }
            public Scheme Value
            {
                get
                {
                    return this;
                }
            }
            public double BaseS
            {
                get
                {
                    return baseSL[0];
                }
            }
            public double BaseL
            {
                get
                {
                    return baseSL[1];
                }
            }
            public double ContrastS
            {
                get
                {
                    return contrastSL[0];
                }
            }
            public double ContrastL
            {
                get
                {
                    return contrastSL[1];
                }
            }

            public Scheme(string _text, double[] _baseSL, double[] _contrastSL)
            {
                this.text = _text;
                this.baseSL = _baseSL;
                this.contrastSL = _contrastSL;
            }
        }

        // Initialization
        public ColorSchemePickerForm()
        {
            InitializeComponent();

            cbScheme.Items.Add(new Scheme("Minimální kontrast", new double[] { 0, 0 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Nižší kontrast", new double[] { 0, 0 }, new double[] { 0.2, 0.2 }));
            cbScheme.Items.Add(new Scheme("Menší kontrast", new double[] { 0, 0 }, new double[] { 0.33, 0.33 }));
            cbScheme.Items.Add(new Scheme("Základní kontrast", new double[] { 0, 0 }, new double[] { 0.5, 0.5 }));
            cbScheme.Items.Add(new Scheme("Větší kontrast", new double[] { -0.1, -0.1 }, new double[] { 0.66, 0.66 }));
            cbScheme.Items.Add(new Scheme("Vysoký kontrast", new double[] { -0.1, -0.1 }, new double[] { 0.75, 0.75 }));
            cbScheme.Items.Add(new Scheme("Maximální kontrast", new double[] { 1, 1 }, new double[] { 1, 1 }));

            cbScheme.Items.Add(new Scheme("Středně tmavý", new double[] { 0.5, -0.44 }, new double[] { 0.4, 0.4 }));
            cbScheme.Items.Add(new Scheme("Tmavý", new double[] { 1, -0.7 }, new double[] { 0.25, 0.25 }));
            cbScheme.Items.Add(new Scheme("Velmi tmavý", new double[] { 1, -0.8 }, new double[] { 0.1, 0.1 }));

            cbScheme.Items.Add(new Scheme("Pastel", new double[] { -0.44, -0.125 }, new double[] { 0.25, 0.25 }));
            cbScheme.Items.Add(new Scheme("Středně tmavý pastel", new double[] { -0.44, -0.44 }, new double[] { 0.25, 0.25 }));
            cbScheme.Items.Add(new Scheme("Tmavý pastel", new double[] { -0.44, -0.7 }, new double[] { 0.25, 0.25 }));
            cbScheme.Items.Add(new Scheme("Velmi tmavý pastel", new double[] { -0.44, -0.8 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Světle bledý pastel", new double[] { -0.75, -0.1 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Bledý pastel", new double[] { -0.75, -0.44 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Tmavě bledý pastel", new double[] { -0.75, -0.7 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Velmi tmavý bledý pastel", new double[] { -0.8, -0.8 }, new double[] { 0.05, 0.05 }));

            cbScheme.Items.Add(new Scheme("Světle šedivý", new double[] { -0.95, -0.1 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Světle šedivý s barevným nádechem", new double[] { -0.95, -0.1 }, new double[] { 0.5, 0.5 }));
            cbScheme.Items.Add(new Scheme("Šedivý", new double[] { -0.95, -0.44 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Šedivý s barevným nádechem", new double[] { -0.95, -0.44 }, new double[] { 0.5, 0.5 }));
            cbScheme.Items.Add(new Scheme("Tmavě šedivý", new double[] { -0.95, -0.8 }, new double[] { 0.1, 0.1 }));
            cbScheme.Items.Add(new Scheme("Tmavě šedivý s barevným nádechem", new double[] { -0.95, -0.8 }, new double[] { 0.5, 0.5 }));

            cbScheme.DisplayMember = "Text";
            cbScheme.ValueMember = "Value";
            cbScheme.SelectedIndex = 3;
        }
        // Model computation
        private double HSVModification(double attr, double delta)
        {
            return delta > 0 ? attr + (1 - attr) * delta : attr * (delta + 1);
        }
        private double[][] ContrastModel(double shadow, double light)
        {
            double[][] shadowA = new double[2][] { new double[2] { -0.5, -0.5 }, new double[2] { 1, -0.7 } };
            double[][] lightA = new double[2][] { new double[2] { -0.5, 1 }, new double[2] { -0.9, 1 } };
            double[][] output = new double[4][] {
                new double[2]{shadowA[0][0] * shadow, shadowA[0][1] * shadow},
                new double[2]{shadowA[1][0] * shadow, shadowA[1][1] * shadow},
                new double[2]{lightA[0][0] * light, lightA[0][1] * light},
                new double[2]{lightA[1][0] * light, lightA[1][1] * light}
            };
            return output;
        }
        private Color getVariant(Color baseColor, double shadow, double light)
        {
            // RGB to HSV because Windows uses HSL, but we use HSV modification
            double outColorHue, outColorSat, outColorVal;
            ColorConversion.ColorToHSV(baseColor, out outColorHue, out outColorSat, out outColorVal);

            // HSV modification
            outColorSat = HSVModification(outColorSat, shadow);
            outColorVal = HSVModification(outColorVal, light);

            // HSV to RGB
            return ColorConversion.HSVToColor(outColorHue, outColorSat, outColorVal);
        }

        // Event Handlers
        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            string selColor = (sender as Label).Text;
            Clipboard.SetText(selColor);
            notifyIcon.ShowBalloonTip(2000, "Schránka změněna", "Kód barvy [" + selColor + "] byl uložen do schránky.", ToolTipIcon.Info);
        }
        private void something_Changed(object sender, EventArgs e)
        {
            Label[] labels = { label2, label3, label4, label5 };
            Color baseColor = ColorTranslator.FromHtml(lbColor.Text), newColor = Color.Empty;

            // Get Scheme & Model
            Scheme selScheme = (Scheme)cbScheme.SelectedItem;
            double[][] model = ContrastModel(selScheme.ContrastS, selScheme.ContrastL);

            // First box / color
            baseColor = getVariant(baseColor, selScheme.BaseS, selScheme.BaseL);
            label1.BackColor = baseColor;
            label1.ForeColor = ColorConversion.InverseColor(baseColor);
            label1.Text = ColorTranslator.ToHtml(baseColor);

            // Another boxes / colors
            for (int i = 0; i < labels.Length; ++i)
            {
                newColor = getVariant(baseColor, model[i][0], model[i][1]);
                labels[i].BackColor = newColor;
                labels[i].ForeColor = ColorConversion.InverseColor(newColor);
                labels[i].Text = ColorTranslator.ToHtml(newColor);
            }
        }
        private void lbColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                Color selColor = colorDialog1.Color;
                string resColor = ColorTranslator.ToHtml(selColor);

                if (resColor != lbColor.Text)
                {
                    lbColor.Text = resColor;
                    lbColor.BackColor = selColor;
                    lbColor.ForeColor = ColorConversion.InverseColor(selColor);
                }
            }
        }
    }
}