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

        protected void dgService_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtLibelle.Text = dgService.SelectedRow.Cells[2].Text;
            txtMontant.Text = dgService.SelectedRow.Cells[3].Text;
            txtType.Text = dgService.SelectedRow.Cells[4].Text;
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgService.SelectedRow.Cells[1].Text);
            Service s = db.Service.Find(id);
            db.Service.Remove(s);
            db.SaveChanges();
            Server.Transfer("FrmService.aspx");
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Service.Select(x =>
            new { x.ID, x.Libelle, x.Montant, x.Type}).ToList();

            if (!string.IsNullOrEmpty(txtLibelle.Text))
            {
                liste = liste.Where(a => a.Libelle.ToUpper().Contains(txtLibelle.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(txtMontant.Text))
            {
                int montant = int.Parse(txtMontant.Text);
                liste = liste.Where(a => a.Montant == montant).ToList();
            }

            if (!string.IsNullOrEmpty(txtType.Text))
            {
                liste = liste.Where(a => a.Type.ToUpper().Contains(txtType.Text.ToUpper())).ToList();
            }

            dgService.DataSource = liste;
            dgService.DataBind();
        }

       /* protected void btnRechercherMotCles_Click(object sender, EventArgs e)
        {
            var liste = db.Service.Select(x =>
            new { x.ID, x.Libelle, x.Montant, x.Type }).ToList();

            if (!string.IsNullOrEmpty(txtMotCles.Text))
            {
                liste = liste.Where(a => a.Libelle.ToUpper().Contains(txtMotCles.Text.ToUpper()) || a.Montant == int.Parse(txtMotCles.Text) || a.Type.ToUpper().Contains(txtMotCles.Text.ToUpper())).ToList();
            }

            dgService.DataSource = liste;
            dgService.DataBind();
        }*/
    }
}