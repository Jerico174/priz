using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace PRIZ
{
    [Serializable]
    public class NewTask
    {
        public string _name;
        public string _description;
        public string _given;
        public string _toFind;
        public string _phenomenas;

        public NewTask() { }

        public NewTask(string name, string given, Rectangle r, string oldTaskName, string currentModule,string phenomenas)
        {
            Task n = new Task();
            this._name = name;
            this._description = given;
            if (oldTaskName != name)
            {
                Directory.Move(@"modules\" + currentModule + @"\" + oldTaskName, @"modules\" + currentModule + @"\" + _name);
            }
            SerializeEdit(name, r, @"modules\" + currentModule + @"\" + _name, phenomenas);
        }

        private void SerializeEdit(string name, Rectangle r, string modulePath,string phenomenas)
        {
            string path = modulePath;
            Task n = new Task();
            n._name = this._name;
            n._description = this._description;
            n._toFind = this._toFind;
            n._given = this._given;
            n._phenomenas = this._phenomenas;
            FileStream fs = new FileStream(path + @"\main.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Task));
            xs.Serialize(fs, n);
            fs.Close();
            SaveImage(r, name, path);
        }
        public NewTask(string name, string given, Rectangle r, string phenomenas)
        {
            Task n = new Task();
            this._name = name;
            this._description = given;
            this._phenomenas = phenomenas;
            Serialize(name, r);
        }
        public void CreateFromXML(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Task));
            Task n = new Task();
            Task tempTask = (Task)xs.Deserialize(fs);
            n._name = tempTask._name;
            n._given = tempTask._given;
            n._toFind = tempTask._toFind;
            n._description = tempTask._description;
            n._phenomenas = tempTask._phenomenas;
            fs.Close();
        }
        public void Serialize(string name, Rectangle r)
        {
            string path = @"modules\" + FormNewModule._currentModuleName + @"\" + name + @"\main.xml";
            try
            {
                Task n = new Task();
                n._name = this._name;
                n._description = this._description;
                n._toFind = this._toFind;
                n._given = this._given;
                n._phenomenas = this._phenomenas;
                FileStream fs = new FileStream(path, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(Task));
                xs.Serialize(fs, n);
                fs.Close();
                SaveImage(r, name);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"modules\" + FormNewModule._currentModuleName + @"\" + name);
                FileStream fs = new FileStream(path, FileMode.Create);
                Task n = new Task();
                n._name = this._name;
                n._description = this._description;
                n._toFind = this._toFind;
                n._given = this._given;
                n._phenomenas = this._phenomenas;
                XmlSerializer xs = new XmlSerializer(typeof(Task));
                xs.Serialize(fs, n);
                fs.Close();
                SaveImage(r, name);
            }
        }
        public void SaveImage(Rectangle r, string name)
        {
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            b.Save(@"modules\" + FormNewModule._currentModuleName + @"\"+ name + @"\mainpic.png");
        }

        public void SaveImage(Rectangle r, string name, string modulePath)
        {
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            b.Save(modulePath + @"\mainpic.png");
        }
    }   
}
