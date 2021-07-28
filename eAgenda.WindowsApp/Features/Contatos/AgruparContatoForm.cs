using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class AgruparContatoForm : Form
    {
        public AgruparContatoForm()
        {
            InitializeComponent();
        }

        public AgruparContatoEnum TipoAgrupar
        {
            get
            {
                if (rdbAgruparCargo.Checked)
                    return AgruparContatoEnum.AgruparCargoContato;

                else if (rdbAgruparEmpresa.Checked)
                    return AgruparContatoEnum.AgruparEmpresaContato;

                else
                    return AgruparContatoEnum.TodosContato;
            }
        }
    }
}
