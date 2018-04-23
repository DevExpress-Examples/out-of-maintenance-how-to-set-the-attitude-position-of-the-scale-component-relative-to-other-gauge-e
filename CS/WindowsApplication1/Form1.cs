using System;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Base;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        decimal defaultX, defaultY;
        public Form1() {
            InitializeComponent();
            defaultX = Convert.ToDecimal(arcScaleComponent1.Center.X);
            defaultY = Convert.ToDecimal(arcScaleComponent1.Center.Y);
            ResetPosition();
        }
        private void ResetPosition() {
            spinEditX.Value = defaultX;
            spinEditY.Value = defaultY;
        }
        private void spinEditX_EditValueChanged(object sender, EventArgs e) {
            arcScaleComponent1.Center = new PointF2D(Convert.ToSingle(spinEditX.Value), arcScaleComponent1.Center.Y);
        }
        private void spinEditY_EditValueChanged(object sender, EventArgs e) {
            arcScaleComponent1.Center = new PointF2D(arcScaleComponent1.Center.X, Convert.ToSingle(spinEditY.Value));
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            ResetPosition();
        }
    }
}