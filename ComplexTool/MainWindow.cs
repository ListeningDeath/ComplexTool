using System;
using System.Windows.Forms;

namespace ComplexTool
{
    public partial class MainWindow : Form
    {
        private Complex _cvtComplex;
        private Complex _calComplex1;
        private Complex _calComplex2;
        private Complex _resComplex;
        private bool _changedByHuman;
        public MainWindow()
        {
            InitializeComponent();
            _cvtComplex = new Complex { DecimalPlaces = 5 };
            _calComplex1 = new Complex { DecimalPlaces = 5 };
            _calComplex2 = new Complex { DecimalPlaces = 5 };
            _resComplex = new Complex { DecimalPlaces = 5 };
            _changedByHuman = true;
        }

        private void AlgebraChanged(object sender, EventArgs e)
        {
            if (!_changedByHuman)
            {
                return;
            }
            _changedByHuman = false;
            try
            {
                _cvtComplex.X = double.Parse(txtCvtReal.Text);
                _cvtComplex.Y = double.Parse(txtCvtImaginary.Text);
            }
            catch
            {
                if (txtCvtReal.Text == "")
                {
                    _cvtComplex.X = 0;
                }
                if (txtCvtImaginary.Text == "")
                {
                    _cvtComplex.Y = 0;
                }
            }
            txtCvtModule.Text = $@"{_cvtComplex.ShowModule}";
            txtCvtDegree.Text = $@"{_cvtComplex.ShowDegree}";
            _changedByHuman = true;
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                _calComplex1.X = double.Parse(txtCalReal1.Text);
                _calComplex1.Y = double.Parse(txtCalImaginary1.Text);
                _calComplex2.X = double.Parse(txtCalReal2.Text);
                _calComplex2.Y = double.Parse(txtCalImaginary2.Text);
            }
            catch
            {
                if (txtCalReal1.Text == "")
                {
                    _calComplex1.X = 0;
                }
                if (txtCalImaginary1.Text == "")
                {
                    _calComplex1.Y = 0;
                }
                if (txtCalReal2.Text == "")
                {
                    _calComplex2.X = 0;
                }
                if (txtCalImaginary2.Text == "")
                {
                    _calComplex2.Y = 0;
                }
            }
            try
            {
                if (rbPlus.Checked)
                {
                    _resComplex = _calComplex1 + _calComplex2;
                }
                if (rbMinus.Checked)
                {
                    _resComplex = _calComplex1 - _calComplex2;
                }
                if (rbMultiply.Checked)
                {
                    _resComplex = _calComplex1 * _calComplex2;
                }
                if (rbDivide.Checked)
                {
                    _resComplex = _calComplex1 / _calComplex2;
                }
                txtCalRes.Text = $@"{_resComplex.ShowString()} ";
            }
            catch (Exception)
            {
                txtCalRes.Text = @"Error";
            }
        }

        private void ToCvt(object sender, EventArgs e)
        {
            txtCvtReal.Text = $@"{_resComplex.ShowX}";
            txtCvtImaginary.Text = $@"{_resComplex.ShowY}"; 
        }

        private void DecimalPlacesChanged(object sender, EventArgs e)
        {
            try
            {
                //_resComplex.DecimalPlaces = int.Parse(txtDecimal.Text);
                _calComplex1.DecimalPlaces = int.Parse(txtDecimal.Text);
                _calComplex2.DecimalPlaces = int.Parse(txtDecimal.Text);
                _cvtComplex.DecimalPlaces = int.Parse(txtDecimal.Text);
                Calculate(null, null);
                AlgebraChanged(null, null);
                PolarChanged(null, null);
            }
            catch
            {
                // ignored
            }
        }

        private void ToCal1(object sender, EventArgs e)
        {
            txtCalReal1.Text = $@"{_cvtComplex.ShowX}";
            txtCalImaginary1.Text = $@"{_cvtComplex.ShowY}";
        }

        private void ToCal2(object sender, EventArgs e)
        {
            txtCalReal2.Text = $@"{_cvtComplex.ShowX}";
            txtCalImaginary2.Text = $@"{_cvtComplex.ShowY}";
        }

        private void PolarChanged(object sender, EventArgs e)
        {
            if (!_changedByHuman)
            {
                return;
            }
            _changedByHuman = false;
            try
            {
                _cvtComplex.Module = double.Parse(txtCvtModule.Text);
                _cvtComplex.Degree = double.Parse(txtCvtDegree.Text);
            }
            catch
            {
                if (txtCvtModule.Text == "")
                {
                    _cvtComplex.Module = 0;
                }
                if (txtCvtDegree.Text == "")
                {
                    _cvtComplex.Degree = 0;
                }
            }
            txtCvtReal.Text = $@"{_cvtComplex.ShowX}";
            txtCvtImaginary.Text = $@"{_cvtComplex.ShowY}";
            _changedByHuman = true;
        }
    }
}
