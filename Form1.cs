using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace Database_and_Drawing_Testing
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int currentStep = 0;
        Point mousePos = new Point();
        Color currentColor = Color.Black;
        string currentType = "line";
        int[] points = { 0, 0, 0, 0, 0, 0 };

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "v1nxyrl7nC6j1CKQpTEJzMIekPSfufM2GSXS4axx",
            BasePath = "https://cross-language-canvas-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
            }
            catch (Exception)
            {
                throw;
            }
            RealtimeUpdates();
        }
        async public void RealtimeUpdates()
        {
            while (true)
            {
                FirebaseResponse res = await client.GetAsync(@"Room 1/Last Command");
                if (res.Body == "null")
                {
                    continue;
                }
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                Element element = new Element()
                {
                    color = Color.FromName(data.ElementAt(0).Value),
                    type = data.ElementAt(1).Value,
                    x1 = Convert.ToInt32(data.ElementAt(2).Value),
                    x2 = Convert.ToInt32(data.ElementAt(3).Value),
                    x3 = Convert.ToInt32(data.ElementAt(4).Value),
                    y1 = Convert.ToInt32(data.ElementAt(5).Value),
                    y2 = Convert.ToInt32(data.ElementAt(6).Value),
                    y3 = Convert.ToInt32(data.ElementAt(7).Value),

                };
                if (element.type == "line")
                {
                    AddLine(element);
                }
                if (element.type == "rect")
                {
                    AddRect(element);
                }
                if (element.type == "trigon")
                {
                    AddTrigon(element);
                }
            }
        }

        //Display Drawing
        public void AddLine(Element line)
        {
            Graphics myCanvas = pic_Canvas.CreateGraphics();
            
            Pen pen = new Pen(line.color, 3);

            myCanvas.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }
        public void AddRect(Element rect)
        {
            Graphics myCanvas = pic_Canvas.CreateGraphics();

            SolidBrush brush = new SolidBrush(rect.color);

            int width = Math.Max(rect.x1, rect.x2) - Math.Min(rect.x1, rect.x2);
            int height = Math.Max(rect.y1, rect.y2) - Math.Min(rect.y1, rect.y2);
            myCanvas.FillRectangle(brush, Math.Min(rect.x1, rect.x2), Math.Min(rect.y1, rect.y2), width, height);
        }
        public void AddTrigon(Element trigon)
        {
            Graphics myCanvas = pic_Canvas.CreateGraphics();

            SolidBrush brush = new SolidBrush(trigon.color);

            PointF point1 = new PointF(trigon.x1, trigon.y1);
            PointF point2 = new PointF(trigon.x2, trigon.y2);
            PointF point3 = new PointF(trigon.x3, trigon.y3);
            PointF[] trigonPoints = { point1, point2, point3 };

            myCanvas.FillPolygon(brush, trigonPoints, FillMode.Winding);
        }

        //Canvas Drawing
        private void pic_Canvas_Click(object sender, EventArgs e)
        {
            currentStep++;

            //Cursor
            MouseEventArgs me = (MouseEventArgs)e;
            mousePos = me.Location;
            pic_Canvas.Cursor = Cursors.Cross;

            //Set Points
            if (currentStep == 1)
            {
                points[0] = mousePos.X;
                points[1] = mousePos.Y;
            }
            if (currentStep == 2)
            {
                points[2] = mousePos.X;
                points[3] = mousePos.Y;
            }
            if (currentStep == 3)
            {
                points[4] = mousePos.X;
                points[5] = mousePos.Y;
            }

            //Check if Shape is Done
            if (currentType == "trigon")
            {
                if (currentStep > 2)
                {
                    MakeShape();
                }
            }
            else
            {
                if (currentStep > 1)
                {
                    MakeShape();
                }
            }

            void MakeShape()
            {
                currentStep = 0;
                pic_Canvas.Cursor = Cursors.Default;
                Element element = new Element()
                {
                    color = currentColor,
                    type = currentType,
                    x1 = points[0],
                    x2 = points[2],
                    x3 = points[4],
                    y1 = points[1],
                    y2 = points[3],
                    y3 = points[5],
                };
                var setter = client.Set("Room 1/Last Command", element);
            }
        }

        //Options
        private void btn_Select_Red_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            lbl_Color_Display.Text = $"Selected Color: {currentColor.Name}";
        }
        private void btn_Select_Orange_Click(object sender, EventArgs e)
        {
            currentColor = Color.OrangeRed;
            lbl_Color_Display.Text = $"Selected Color: Orange";
        }
        private void btn_Select_Yellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
            lbl_Color_Display.Text = $"Selected Color: {currentColor.Name}";
        }
        private void btn_Select_Green_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
            lbl_Color_Display.Text = $"Selected Color: {currentColor.Name}";
        }
        private void btn_Select_SkyBlue_Click(object sender, EventArgs e)
        {
            currentColor = Color.DeepSkyBlue;
            lbl_Color_Display.Text = $"Selected Color: Cyan";
        }
        private void btn_Select_Blue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
            lbl_Color_Display.Text = $"Selected Color: {currentColor.Name}";
        }
        private void btn_Select_Purple_Click(object sender, EventArgs e)
        {
            currentColor = Color.Indigo;
            lbl_Color_Display.Text = $"Selected Color: Purple";
        }
        private void btn_Select_Black_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            lbl_Color_Display.Text = $"Selected Color: {currentColor.Name}";
        }

        private void SelectShape(string type, string display)
        {
            currentType = type;
            lbl_Shape_Display.Text = $"Selected Color: {display}";
            currentStep = 0;
        }
        private void btn_Select_Line_Click(object sender, EventArgs e)
        {
            SelectShape("line", "Line");
        }
        private void btn_Select_Rect_Click(object sender, EventArgs e)
        {
            SelectShape("rect", "Rectangle");
        }
        private void btn_Select_Trigon_Click(object sender, EventArgs e)
        {
            SelectShape("trigon", "Triangle");
        }
        private void btn_Select_Circ_Click(object sender, EventArgs e)
        {
            SelectShape("circ", "Circle");
        }
    }
}
