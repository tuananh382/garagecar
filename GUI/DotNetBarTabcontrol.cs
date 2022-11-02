using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

public class DotNetBarTabcontrol : TabControl
{
    public DotNetBarTabcontrol()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        DoubleBuffered = true;
        SizeMode = TabSizeMode.Fixed;
        ItemSize = new Size(44, 136);
    }

    protected override void CreateHandle()
    {
        base.CreateHandle();
        Alignment = TabAlignment.Left;
    }

    public Pen ToPen(Color color)
    {
        return new Pen(color);
    }

    public Brush ToBrush(Color color)
    {
        return new SolidBrush(color);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Bitmap B = new Bitmap(Width, Height);
        Graphics G = Graphics.FromImage(B);
        try
        {
            
        }
        catch
        {
        }
        G.Clear(Color.White);
        G.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), new Rectangle(0, 0, ItemSize.Height + 4, Height));
        // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(Width - 1, 0), New Point(Width - 1, Height - 1))    'comment out to get rid of the borders
        // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 1, 0), New Point(Width - 1, 0))                   'comment out to get rid of the borders
        // G.DrawLine(New Pen(Color.FromArgb(170, 187, 204)), New Point(ItemSize.Height + 3, Height - 1), New Point(Width - 1, Height - 1)) 'comment out to get rid of the borders
        G.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(ItemSize.Height + 3, 0), new Point(ItemSize.Height + 3, 999));
        for (var i = 0; i <= TabCount - 1; i++)
        {
            if (i == SelectedIndex)
            {
                Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                ColorBlend myBlend = new ColorBlend();
                Color[] colors =
                {
                    Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240), Color.FromArgb(232, 232, 240),
                };
                myBlend.Colors = colors ;
                myBlend.Positions = new[] { 0.0F, 0.5F, 1.0F };
                LinearGradientBrush lgBrush = new LinearGradientBrush(x2, Color.Black, Color.Black, 90.0F);
                lgBrush.InterpolationColors = myBlend;
                G.FillRectangle(lgBrush, x2);
                G.DrawRectangle(new Pen(Color.FromArgb(170, 187, 204)), x2);


                G.SmoothingMode = SmoothingMode.HighQuality;
                Point[] p = new[] { new Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27) };
                G.FillPolygon(Brushes.White, p);
                G.DrawPolygon(new Pen(Color.FromArgb(170, 187, 204)), p);                
                if (ImageList != null)
                {
                    try
                    {
                        if (ImageList.Images[TabPages[i].ImageIndex] != null)
                        {                           
                            G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                            G.DrawString("      " + TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                        else
                            G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }
                    catch (Exception ex)
                    {
                        G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }
                }
                else
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });

                G.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                G.DrawLine(new Pen(Color.FromArgb(200, 200, 250)), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
            }
            else
            {
                Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1));
                G.FillRectangle(new SolidBrush(Color.FromArgb(246, 248, 252)), x2);
                G.DrawLine(new Pen(Color.FromArgb(170, 187, 204)), new Point(x2.Right, x2.Top), new Point(x2.Right, x2.Bottom));
                if (ImageList != null)
                {
                    try
                    {
                        if (ImageList.Images[TabPages[i].ImageIndex] != null)
                        {
                            G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                            G.DrawString("      " + TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                        }
                        else
                            G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }
                    catch (Exception ex)
                    {
                        G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
                    }
                }
                else
                    G.DrawString(TabPages[i].Text, Font, Brushes.DimGray, x2, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            }
        }
        PointF point = new PointF();
        point.X = 0;
        point.Y = 0;
        e.Graphics.DrawImage(B , point);
        G.Dispose(); 
        B.Dispose();   
    }
}
