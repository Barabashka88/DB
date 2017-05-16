using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Concrete;

namespace ClinicDBProject
{
    public partial class DocWindow : Form
    {
        private ClinicRepository repository;
        
        public DocWindow(ClinicRepository repository)
        {
            this.repository = repository;
            InitializeComponent();
        }
    }
}
