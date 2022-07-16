using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Show();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            label18.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            string hex = generateHexCode();
            label1.Text = hex + " -> ";
            Color y = ColorTranslator.FromHtml(hex);
            label2.BackColor = y;
            double hu = 0;
            double s = 0;
            double v = 0;
            ColorToHSV(y, out hu, out s, out v);
            s = s * 100;
            v = v * 100;
            string hsvCol1 = hu.ToString() + ", " + s.ToString() + ", " + v.ToString();
            label11.Text = "-> " + hsvCol1;
        }
        private string generateHexCode()
        {
            Random rand = new Random();
            int a = rand.Next(0, 15);
            int b = rand.Next(0, 15);
            int c = rand.Next(0, 15);
            int d = rand.Next(0, 15);
            int x = rand.Next(0, 15);
            int f = rand.Next(0, 15);
            string g = "";
            string h = "";
            string i = "";
            if (a > 9)
            {
                if (a == 10)
                {
                    g += "A";
                }
                else if (a == 11)
                {
                    g += "B";
                }
                else if (a == 12)
                {
                    g += "C";
                }
                else if (a == 13)
                {
                    g += "D";
                }
                else if (a == 14)
                {
                    g += "E";
                }
                else
                {
                    g += "F";
                }
            }
            else
            {
                g += a;
            }
            if (b > 9)
            {
                if (b == 10)
                {
                    g += "A";
                }
                else if (b == 11)
                {
                    g += "B";
                }
                else if (b == 12)
                {
                    g += "C";
                }
                else if (b == 13)
                {
                    g += "D";
                }
                else if (b == 14)
                {
                    g += "E";
                }
                else
                {
                    g += "F";
                }
            }
            else
            {
                g += b;
            }
            if (c > 9)
            {
                if (c == 10)
                {
                    h += "A";
                }
                else if (c == 11)
                {
                    h += "B";
                }
                else if (c == 12)
                {
                    h += "C";
                }
                else if (c == 13)
                {
                    h += "D";
                }
                else if (c == 14)
                {
                    h += "E";
                }
                else
                {
                    h += "F";
                }
            }
            else
            {
                h += c;
            }
            if (d > 9)
            {
                if (d == 10)
                {
                    h += "A";
                }
                else if (d == 11)
                {
                    h += "B";
                }
                else if (d == 12)
                {
                    h += "C";
                }
                else if (d == 13)
                {
                    h += "D";
                }
                else if (d == 14)
                {
                    h += "E";
                }
                else
                {
                    h += "F";
                }
            }
            else
            {
                h += d;
            }
            if (x > 9)
            {
                if (x == 10)
                {
                    i += "A";
                }
                else if (x == 11)
                {
                    i += "B";
                }
                else if (x == 12)
                {
                    i += "C";
                }
                else if (x == 13)
                {
                    i += "D";
                }
                else if (x == 14)
                {
                    i += "E";
                }
                else
                {
                    i += "F";
                }
            }
            else
            {
                i += x;
            }
            if (f > 9)
            {
                if (f == 10)
                {
                    i += "A";
                }
                else if (f == 11)
                {
                    i += "B";
                }
                else if (f == 12)
                {
                    i += "C";
                }
                else if (f == 13)
                {
                    i += "D";
                }
                else if (f == 14)
                {
                    i += "E";
                }
                else
                {
                    i += "F";
                }
            }
            else
            {
                i += f;
            }
            string hex = "#" + g + h + i;
            return hex;
        }
        private string generateSimilarHex(string hex)
        {
            Random r = new Random();
            char[] hexsplit = hex.ToCharArray(0, 7);
            string newhex = "";
            foreach (char x in hexsplit)
            {
                int y = r.Next(0, 1000);
                int z = r.Next(0, 1000);
                if (x == '#')
                {
                    newhex += "#";
                }
                else if (x == '0')
                {
                    if (z < 250)
                    {
                        newhex += "0";
                    }
                    else if (z >= 250 && z < 500)
                    {
                        newhex += "1";
                    }
                    else if (z >= 500 && z < 750)
                    {
                        newhex += "2";
                    }
                    else
                    {
                        newhex += "3";
                    }
                }
                else if (x == '1')
                {
                    if (y < 500)
                    {
                        newhex += "1";
                    }
                    else
                    {
                        if (z < 250)
                        {
                            newhex += "0";
                        }
                        else if (z >= 250 && z < 500)
                        {
                            newhex += "1";
                        }
                        else if (z >= 500 && z < 750)
                        {
                            newhex += "2";
                        }
                        else
                        {
                            newhex += "3";
                        }
                    }
                }
                else if (x == '2')
                {
                    if (y < 500)
                    {
                        if (z < 500)
                        {
                            newhex += "2";
                        }
                        else
                        {
                            newhex += "1";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "3";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "2";
                        }
                        else
                        {
                            newhex += "4";
                        }
                    }
                }
                else if (x == '3')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "3";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "2";
                        }
                        else
                        {
                            newhex += "1";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "3";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "4";
                        }
                        else
                        {
                            newhex += "5";
                        }
                    }
                }
                else if (x == '4')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "4";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "5";
                        }
                        else
                        {
                            newhex += "6";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "4";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "3";
                        }
                        else
                        {
                            newhex += "2";
                        }
                    }
                }
                else if (x == '5')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "5";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "4";
                        }
                        else
                        {
                            newhex += "3";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "5";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "6";
                        }
                        else
                        {
                            newhex += "7";
                        }
                    }
                }
                else if (x == '6')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "6";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "5";
                        }
                        else
                        {
                            newhex += "4";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "6";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "7";
                        }
                        else
                        {
                            newhex += "8";
                        }
                    }
                }
                else if (x == '7')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "7";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "6";
                        }
                        else
                        {
                            newhex += "5";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "7";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "8";
                        }
                        else
                        {
                            newhex += "9";
                        }
                    }
                }
                else if (x == '8')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "8";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "7";
                        }
                        else
                        {
                            newhex += "6";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "8";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "9";
                        }
                        else
                        {
                            newhex += "A";
                        }
                    }
                }
                else if (x == '9')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "9";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "8";
                        }
                        else
                        {
                            newhex += "7";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "9";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "A";
                        }
                        else
                        {
                            newhex += "B";
                        }
                    }
                }
                else if (x == 'A')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "A";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "9";
                        }
                        else
                        {
                            newhex += "8";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "A";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "B";
                        }
                        else
                        {
                            newhex += "C";
                        }
                    }
                }
                else if (x == 'B')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "B";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "A";
                        }
                        else
                        {
                            newhex += "9";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "B";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "C";
                        }
                        else
                        {
                            newhex += "D";
                        }
                    }
                }
                else if (x == 'C')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "C";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "B";
                        }
                        else
                        {
                            newhex += "A";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "C";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "D";
                        }
                        else
                        {
                            newhex += "E";
                        }
                    }
                }
                else if (x == 'D')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "D";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "C";
                        }
                        else
                        {
                            newhex += "B";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "D";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "E";
                        }
                        else
                        {
                            newhex += "F";
                        }
                    }
                }
                else if (x == 'E')
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "E";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "D";
                        }
                        else
                        {
                            newhex += "C";
                        }
                    }
                    else
                    {
                        if (z < 333)
                        {
                            newhex += "E";
                        }
                        else
                        {
                            newhex += "F";
                        }
                    }
                }
                else
                {
                    if (y < 500)
                    {
                        if (z < 333)
                        {
                            newhex += "F";
                        }
                        else if (z >= 333 && z < 666)
                        {
                            newhex += "E";
                        }
                        else
                        {
                            newhex += "D";
                        }
                    }
                    else
                    {
                        newhex += "F";
                    }
                }
            }
            return newhex;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            string x = label1.Text.Substring(0, 7);
            string a = generateSimilarHex(x);
            string b = generateSimilarHex(a);
            string c = generateSimilarHex(b);
            string d = generateSimilarHex(c);
            Color ac = ColorTranslator.FromHtml(a);
            Color bc = ColorTranslator.FromHtml(b);
            Color cc = ColorTranslator.FromHtml(c);
            Color dc = ColorTranslator.FromHtml(d);
            label4.Text = a + " ->";
            label6.Text = b + " ->";
            label8.Text = c + " ->";
            label10.Text = d + " ->";
            label3.BackColor = ac;
            label5.BackColor = bc;
            label7.BackColor = cc;
            label9.BackColor = dc;
            double hu = 0;
            double s = 0;
            double v = 0;
            ColorToHSV(ac, out hu, out s, out v);
            s = s * 100;
            v = v * 100;
            string hsvCol1 = hu.ToString() + ", " + s.ToString() + ", " + v.ToString();
            label12.Text = "-> " + hsvCol1;
            double hu2 = 0;
            double s2 = 0;
            double v2 = 0;
            ColorToHSV(bc, out hu2, out s2, out v2);
            s2 = s2 * 100;
            v2 = v2 * 100;
            string hsvCol2 = hu2.ToString() + ", " + s2.ToString() + ", " + v2.ToString();
            label13.Text = "-> " + hsvCol2;
            double hu3 = 0;
            double s3 = 0;
            double v3 = 0;
            ColorToHSV(cc, out hu3, out s3, out v3);
            s3 = s3 * 100;
            v3 = v3 * 100;
            string hsvCol3 = hu3.ToString() + ", " + s3.ToString() + ", " + v3.ToString();
            label14.Text = "-> " + hsvCol3;
            double hu4 = 0;
            double s4 = 0;
            double v4 = 0;
            ColorToHSV(dc, out hu4, out s4, out v4);
            s4 = s4 * 100;
            v4 = v4 * 100;
            string hsvCol4 = hu4.ToString() + ", " + s4.ToString() + ", " + v4.ToString();
            label15.Text = "-> " + hsvCol4;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Open()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Color Save Files (*.color)|*.color";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.OpenFile());
                string contents = reader.ReadToEnd();
                if (contents.Length == 9)
                {
                    try
                    {
                        label3.Hide();
                        label4.Hide();
                        label5.Hide();
                        label6.Hide();
                        label7.Hide();
                        label8.Hide();
                        label9.Hide();
                        label10.Hide();
                        label12.Hide();
                        label13.Hide();
                        label14.Hide();
                        label15.Hide();
                        button7.Hide();
                        button8.Hide();
                        button9.Hide();
                        button10.Hide();
                        button12.Hide();
                        button13.Hide();
                        button14.Hide();
                        button15.Hide();
                        string a = contents.Substring(0, 7);
                        Color b = ColorTranslator.FromHtml(a);
                        label1.Text = a + " ->";
                        label2.BackColor = b;
                        double hu = 0;
                        double s = 0;
                        double v = 0;
                        ColorToHSV(b, out hu, out s, out v);
                        s = s * 100;
                        v = v * 100;
                        string hsvCol = hu.ToString() + ", " + s.ToString() + ", " + v.ToString();
                        string up = hsvCol.ToUpper();
                        label11.Text = "-> " + up;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: File was incorrect format.");
                    }

                }
                else if (contents.Length == 45)
                {
                    try
                    {
                        label3.Show();
                        label4.Show();
                        label5.Show();
                        label6.Show();
                        label7.Show();
                        label8.Show();
                        label9.Show();
                        label10.Show();
                        label12.Show();
                        label13.Show();
                        label14.Show();
                        label15.Show();
                        button7.Show();
                        button8.Show();
                        button9.Show();
                        button10.Show();
                        button12.Show();
                        button13.Show();
                        button14.Show();
                        button15.Show();
                        string a = contents.Substring(0, 7);
                        string b = contents.Substring(9, 7);
                        string c = contents.Substring(18, 7);
                        string d = contents.Substring(27, 7);
                        string f = contents.Substring(36, 7);
                        Color ac = ColorTranslator.FromHtml(a);
                        Color bc = ColorTranslator.FromHtml(b);
                        Color cc = ColorTranslator.FromHtml(c);
                        Color dc = ColorTranslator.FromHtml(d);
                        Color fc = ColorTranslator.FromHtml(f);
                        label1.Text = a.ToUpper() + " ->";
                        label4.Text = b.ToUpper() + " ->";
                        label6.Text = c.ToUpper() + " ->";
                        label8.Text = d.ToUpper() + " ->";
                        label10.Text = f.ToUpper() + " ->";
                        label2.BackColor = ac;
                        label3.BackColor = bc;
                        label5.BackColor = cc;
                        label7.BackColor = dc;
                        label9.BackColor = fc;
                        double hu = 0;
                        double s = 0;
                        double v = 0;
                        ColorToHSV(ac, out hu, out s, out v);
                        s = s * 100;
                        v = v * 100;
                        string hsvCol1 = hu.ToString() + ", " + s.ToString() + ", " + v.ToString();
                        label11.Text = "-> " + hsvCol1;
                        double hu2 = 0;
                        double s2 = 0;
                        double v2 = 0;
                        ColorToHSV(bc, out hu2, out s2, out v2);
                        s2 = s2 * 100;
                        v2 = v2 * 100;
                        string hsvCol2 = hu2.ToString() + ", " + s2.ToString() + ", " + v2.ToString();
                        label12.Text = "-> " + hsvCol2;
                        double hu3 = 0;
                        double s3 = 0;
                        double v3 = 0;
                        ColorToHSV(cc, out hu3, out s3, out v3);
                        s3 = s3 * 100;
                        v3 = v3 * 100;
                        string hsvCol3 = hu3.ToString() + ", " + s3.ToString() + ", " + v3.ToString();
                        label13.Text = "-> " + hsvCol3;
                        double hu4 = 0;
                        double s4 = 0;
                        double v4 = 0;
                        ColorToHSV(dc, out hu4, out s4, out v4);
                        s4 = s4 * 100;
                        v4 = v4 * 100;
                        string hsvCol4 = hu4.ToString() + ", " + s4.ToString() + ", " + v4.ToString();
                        label14.Text = "-> " + hsvCol4;
                        double hu5 = 0;
                        double s5 = 0;
                        double v5 = 0;
                        ColorToHSV(fc, out hu5, out s5, out v5);
                        s5 = s5 * 100;
                        v5 = v5 * 100;
                        string hsvCol5 = hu5.ToString() + ", " + s5.ToString() + ", " + v5.ToString();
                        label15.Text = "-> " + hsvCol5;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: File was incorrect format.");
                    }

                }
                else
                {
                    MessageBox.Show("Error: File was incorrect format.");
                }
            }
        }
        private void Save()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "colors.color";
            save.Filter = "Color Save Files (*.color)|*.color|Plain Text Files (*.txt)|*.color";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                string a = label1.Text.Substring(0, 7);
                string b = label4.Text.Substring(0, 7);
                string c = label6.Text.Substring(0, 7);
                string d = label8.Text.Substring(0, 7);
                string f = label10.Text.Substring(0, 7);
                if (label4.Visible == true)
                {
                    writer.WriteLine(a);
                    writer.WriteLine(b);
                    writer.WriteLine(c);
                    writer.WriteLine(d);
                    writer.WriteLine(f);
                }
                else
                {
                    writer.WriteLine(a);
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                Color rgb = dialog.Color;
                int a = rgb.ToArgb();
                Color b = Color.FromArgb(a);
                string hex = ColorTranslator.ToHtml(b);
                Color hexcolor = ColorTranslator.FromHtml(hex);
                string h = ColorTranslator.ToHtml(hexcolor);
                label1.Text = h + " ->";
                label2.BackColor = hexcolor;
                double hu = 0;
                double s = 0;
                double v = 0;
                ColorToHSV(hexcolor, out hu, out s, out v);
                s = s * 100;
                v = v * 100;
                string hsvCol = hu.ToString() + ", " + s.ToString() + ", " + v.ToString();
                label11.Text = "-> " + hsvCol;
            }
        }
        private static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));
            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        private void button6_Click(object sender, EventArgs e) // hx1
        {
            string c = label1.Text.Substring(0, 7);
            Clipboard.SetText(c);
        }

        private void button7_Click(object sender, EventArgs e) // hx2
        {
            string c = label4.Text.Substring(0, 7);
            Clipboard.SetText(c);
        }

        private void button8_Click(object sender, EventArgs e) // hx3
        {
            string c = label6.Text.Substring(0, 7);
            Clipboard.SetText(c);
        }

        private void button9_Click(object sender, EventArgs e) // hx4
        {
            string c = label8.Text.Substring(0, 7);
            Clipboard.SetText(c);
        }

        private void button10_Click(object sender, EventArgs e) // hx5
        {
            string c = label10.Text.Substring(0, 7);
            Clipboard.SetText(c);
        }

        private void button11_Click(object sender, EventArgs e) // hsv1
        {
            string c = label11.Text.Substring(3, label11.Text.Length - 3);
            Clipboard.SetText(c);
        }

        private void button12_Click(object sender, EventArgs e) // hsv2
        {
            string c = label12.Text.Substring(3, label12.Text.Length - 3);
            Clipboard.SetText(c);
        }

        private void button13_Click(object sender, EventArgs e) // hsv3
        {
            string c = label13.Text.Substring(3, label13.Text.Length - 3);
            Clipboard.SetText(c);
        }

        private void button14_Click(object sender, EventArgs e) // hsv4
        {
            string c = label14.Text.Substring(3, label14.Text.Length - 3);
            Clipboard.SetText(c);
        }

        private void button15_Click(object sender, EventArgs e) // hsv5
        {
            string c = label15.Text.Substring(3, label15.Text.Length - 3);
            Clipboard.SetText(c);
        }
        private void label4_visibleChanged(object sender, EventArgs e)
        {
            if (label4.Visible == true)
            {
                Point b6 = new Point(12, 426);
                button6.Location = b6;
                Point b11 = new Point(557, 426);
                button11.Location = b11;
            }
            else
            {
                Point b6 = new Point(12, 199);
                button6.Location = b6;
                Point b11 = new Point(557, 199);
                button11.Location = b11;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "Show Update Info")
            {
                button16.Text = "Hide Update Info";
                label18.Show();
            }
            else
            {
                button16.Text = "Show Update Info";
                label18.Hide();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
