using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        private BusRoute _busRoute;

        private BusRoute BusRoute
        {
            get { return _busRoute; }

            set
            {
                _busRoute = value;
                updateForm();
            }
        }

        private void updateForm()
        {
            routeNum.Text = _busRoute.RouteNumber;

            if (_busRoute.Start != null)
            {
                startLocation.Text = _busRoute.Start.Location;
                startTime.Value = _busRoute.Start.Time;
            }

            if (_busRoute.Stop != null)
            {
                stopLocation.Text = _busRoute.Stop.Location;
                stopTime.Value = _busRoute.Stop.Time;
            }
        }

        public Form1()
        {
            InitializeComponent();
            _busRoute = new BusRoute();
        }

        private void serializeBinary_Click(object sender, EventArgs e)
        {
            // Update the StopInterval property of BusRoute.calc to illustrate that BusRoute.calc won't be serialized.
            BusRoute.updateCalcInterval();

            var saveFileDialog = new SaveFileDialog { DefaultExt = ".obj" };
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = saveFileDialog.FileName;
                var formatter = new BinaryFormatter();
                using (var fStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, BusRoute);
                }
            }
        }

        private void readBinary_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { DefaultExt = ".obj" };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                var formatter = new BinaryFormatter();
                using (var fStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    BusRoute = (BusRoute) formatter.Deserialize(fStream);
                }
            }
        }

        private void serializeXML_Click(object sender, EventArgs e)
        {
            // Update the StopInterval property of BusRoute.calc to illustrate that BusRoute.calc won't be serialized.
            BusRoute.updateCalcInterval();

            var saveFileDialog = new SaveFileDialog { DefaultExt = ".xml" };
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = saveFileDialog.FileName;
                var formatter = new XmlSerializer(typeof(BusRoute));
                using (var fStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, BusRoute);
                }
            }
        }

        private void readXML_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { DefaultExt = ".xml" };
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                var formatter = new XmlSerializer(typeof(BusRoute));
                using (var fStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    BusRoute = (BusRoute) formatter.Deserialize(fStream);
                }
            }
        }

        private void routeNum_TextChanged(object sender, EventArgs e)
        {
            BusRoute.RouteNumber = routeNum.Text;
        }

        private void startLocation_TextChanged(object sender, EventArgs e)
        {
            if (BusRoute.Start == null) BusRoute.Start = new BusStop();

            BusRoute.Start.Location = startLocation.Text;
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {
            if (BusRoute.Start == null) BusRoute.Start = new BusStop();

            BusRoute.Start.Time = startTime.Value;
        }

        private void stopLocation_TextChanged(object sender, EventArgs e)
        {
            if (BusRoute.Stop == null) BusRoute.Stop = new BusStop();

            BusRoute.Stop.Location = stopLocation.Text;
        }

        private void stopTime_ValueChanged(object sender, EventArgs e)
        {
            if (BusRoute.Stop == null) BusRoute.Stop = new BusStop();

            BusRoute.Stop.Time = stopTime.Value;
        }

    }
}
