using Project.Date;
using Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UserContols
{
    public partial class PicketInfo : UserControl
    {
        private Picket _picket;
        public PicketInfo(Picket picket)
        {
            _picket = picket;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var measurement = context.Measurements
                    .Where(m => m.PicketID == _picket.PicketID)
                    .FirstOrDefault();

                if (measurement != null)
                {
                    idLbl.Text = _picket.PicketID.ToString();
                    LatitudeTxt.Text = _picket.Latitude.ToString("F6");
                    LongitudeTxt.Text = _picket.Longitude.ToString("F6");
                    UnitTxt.Text = measurement.Unit ?? "N/A";
                    ValueTxt.Text = measurement.Value.ToString("F2");
                    ElectrodeTypeTxt.Text = measurement.ElectrodeType ?? "N/A";
                }
                else
                {
                    // Если данных нет — можно очистить поля или показать "N/A"
                    idLbl.Text = _picket.PicketID.ToString();
                    LatitudeTxt.Text = _picket.Latitude.ToString("F6");
                    LongitudeTxt.Text = _picket.Longitude.ToString("F6");
                    UnitTxt.Text = "N/A";
                    ValueTxt.Text = "N/A";
                    ElectrodeTypeTxt.Text = "N/A";
                }
            }
        }

    }
}
