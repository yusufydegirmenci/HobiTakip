using System;
using System.Drawing;
using System.Windows.Forms;

namespace HobiTakip
{
    public static class ThemeManager
    {
        // Light Theme Colors
        public static class LightTheme
        {
            public static Color BackgroundColor = Color.FromArgb(236, 240, 241);
            public static Color PanelColor = Color.White;
            public static Color TextColor = Color.FromArgb(52, 73, 94);
            public static Color HeaderColor = Color.FromArgb(41, 128, 185);
            public static Color ButtonPrimary = Color.FromArgb(41, 128, 185);
            public static Color ButtonSuccess = Color.FromArgb(46, 204, 113);
            public static Color ButtonDanger = Color.FromArgb(231, 76, 60);
            public static Color ButtonWarning = Color.FromArgb(230, 126, 34);
            public static Color ButtonSecondary = Color.FromArgb(95, 39, 205);
            public static Color BorderColor = Color.FromArgb(189, 195, 199);
        }

        // Dark Theme Colors
        public static class DarkTheme
        {
            public static Color BackgroundColor = Color.FromArgb(44, 62, 80);
            public static Color PanelColor = Color.FromArgb(52, 73, 94);
            public static Color TextColor = Color.FromArgb(236, 240, 241);
            public static Color HeaderColor = Color.FromArgb(52, 152, 219);
            public static Color ButtonPrimary = Color.FromArgb(52, 152, 219);
            public static Color ButtonSuccess = Color.FromArgb(39, 174, 96);
            public static Color ButtonDanger = Color.FromArgb(192, 57, 43);
            public static Color ButtonWarning = Color.FromArgb(211, 84, 0);
            public static Color ButtonSecondary = Color.FromArgb(142, 68, 173);
            public static Color BorderColor = Color.FromArgb(127, 140, 141);
        }

        public static string CurrentTheme { get; set; } = "Light";

        public static void ApplyTheme(Control control, string theme = null)
        {
            if (theme != null) CurrentTheme = theme;
            ApplyThemeToControl(control);
        }

        private static void ApplyThemeToControl(Control control)
        {
            var isDark = CurrentTheme == "Dark";
            
            // Renkleri al
            var bgColor = GetBackgroundColor();
            var panelColor = GetPanelColor();
            var textColor = GetTextColor();
            var headerColor = GetHeaderColor();

            // Form ana arka planı
            if (control is Form)
            {
                control.BackColor = bgColor;
            }
            // Panel arka planları
            else if (control is Panel)
            {
                control.BackColor = panelColor;
            }
            // ListView tema
            else if (control is ListView listView)
            {
                listView.BackColor = panelColor;
                listView.ForeColor = textColor;
            }
            // TextBox tema
            else if (control is TextBox textBox)
            {
                textBox.BackColor = panelColor;
                textBox.ForeColor = textColor;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            // ComboBox tema
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = panelColor;
                comboBox.ForeColor = textColor;
            }
            // Label tema
            else if (control is Label label)
            {
                // Renkli başlıkları koru
                if (IsHeaderColor(label.ForeColor))
                {
                    // Başlık renklerini güncelle
                    if (label.Font.Bold)
                    {
                        label.ForeColor = headerColor;
                    }
                }
                else
                {
                    label.ForeColor = textColor;
                }
            }
            // GroupBox tema
            else if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = textColor;
            }

            // Alt kontrollere de uygula
            foreach (Control child in control.Controls)
            {
                ApplyThemeToControl(child);
            }
        }

        private static bool IsHeaderColor(Color color)
        {
            return color == LightTheme.HeaderColor || 
                   color == DarkTheme.HeaderColor ||
                   color == LightTheme.ButtonSuccess ||
                   color == DarkTheme.ButtonSuccess;
        }

        public static Color GetButtonColor(string buttonType)
        {
            var isDark = CurrentTheme == "Dark";
            
            return buttonType.ToLower() switch
            {
                "primary" => isDark ? DarkTheme.ButtonPrimary : LightTheme.ButtonPrimary,
                "success" => isDark ? DarkTheme.ButtonSuccess : LightTheme.ButtonSuccess,
                "danger" => isDark ? DarkTheme.ButtonDanger : LightTheme.ButtonDanger,
                "warning" => isDark ? DarkTheme.ButtonWarning : LightTheme.ButtonWarning,
                "secondary" => isDark ? DarkTheme.ButtonSecondary : LightTheme.ButtonSecondary,
                _ => isDark ? DarkTheme.ButtonPrimary : LightTheme.ButtonPrimary
            };
        }

        public static Color GetTextColor()
        {
            return CurrentTheme == "Dark" ? DarkTheme.TextColor : LightTheme.TextColor;
        }

        public static Color GetBackgroundColor()
        {
            return CurrentTheme == "Dark" ? DarkTheme.BackgroundColor : LightTheme.BackgroundColor;
        }

        public static Color GetPanelColor()
        {
            return CurrentTheme == "Dark" ? DarkTheme.PanelColor : LightTheme.PanelColor;
        }

        public static Color GetHeaderColor()
        {
            return CurrentTheme == "Dark" ? DarkTheme.HeaderColor : LightTheme.HeaderColor;
        }
    }
}