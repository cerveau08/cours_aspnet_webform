using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using foadcours.Models;

namespace foadcours.Inscription
{
    public partial class frmService : System.Web.UI.Page
    {
        bdEtablissementEntities db = new bdEtablissementEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgService.DataSource = db.Service.ToList();
            dgService.DataBind();
        }

        protected void dgService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLibelle.Text = dgService.SelectedRow.Cells[2].Text;
            txtMontant.Text = dgService.SelectedRow.Cells[3].Text;
            txtType.Text = dgService.SelectedRow.Cells[4].Text;
        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.Libelle = txtLibelle.Text;
            s.Type = txtType.Text;
            s.Montant = !string.IsNullOrEmpty(txtMontant.Text) ? double.Parse(txtMontant.Text):0;
            db.Service.Add(s);
            db.SaveChanges();
            Server.Transfer("frmService.aspx");
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgService.SelectedRow.Cells[1].Text);
            Service s = db.Service.Find(id);
            s.Libelle = txtLibelle.Text;
            s.Type = txtType.Text;
            s.Montant = !string.IsNullOrEmpty(txtMontant.Text) ? double.Parse(txtMontant.Text) : 0;
            db.SaveChanges();
            Server.Transfer("frmService.aspx");
        }
    }
}