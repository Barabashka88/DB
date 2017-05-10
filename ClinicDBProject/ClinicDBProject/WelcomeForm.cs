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
using Domain.Entities;

namespace ClinicDBProject
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            ClinicContext cont = new ClinicContext();
            Person p = new Person();
            p.FirstName = "123";
            p.LastName = "123";
            p.Address = "123";
            p.DateOfBirth = DateTime.Now;
            p.PhoneNumber = "123123123";
            cont.Persons.Add(p);
            cont.SaveChanges();
        }
    }
}
